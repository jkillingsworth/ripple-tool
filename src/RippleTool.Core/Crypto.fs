module RippleTool.Crypto

open System
open System.Security.Cryptography
open Org.BouncyCastle.Asn1
open Org.BouncyCastle.Asn1.Sec
open Org.BouncyCastle.Crypto.Parameters
open Org.BouncyCastle.Crypto.Signers
open Org.BouncyCastle.Math
open RippleTool.Encoding

//-------------------------------------------------------------------------------------------------

let private eccParams = SecNamedCurves.GetByName("secp256k1")
let private eccBasePoint = eccParams.G
let private eccOrder = eccParams.N

//-------------------------------------------------------------------------------------------------

module private Binary =

    let ofBigint (input : BigInteger) =
        input.ToByteArrayUnsigned()

    let toBigint (input : byte[]) =
        BigInteger(1, input)

//-------------------------------------------------------------------------------------------------

let computeHash (input : byte[]) =
    use sha512 = SHA512.Create()
    input
    |> sha512.ComputeHash
    |> Array.take 32

//-------------------------------------------------------------------------------------------------

type Keys = { Prv : byte[]; Pub : byte[] }

let private appendSeqNumber input = Array.append input << Binary.ofUint32

let private computeKeysHash appendSeqNumber input =
    let generator i = Some (appendSeqNumber input i, i + 1u)
    0u
    |> Seq.unfold generator
    |> Seq.map computeHash
    |> Seq.map Binary.toBigint
    |> Seq.find (fun hash -> hash.CompareTo(eccOrder) < 0)

let computeRootKeys secretKeyBinary =

    let generatorPrvBigint = secretKeyBinary |> computeKeysHash appendSeqNumber
    let generatorPubEccPnt = eccBasePoint.Multiply(generatorPrvBigint)
    let generatorPrvBinary = generatorPrvBigint |> Binary.ofBigint
    let generatorPubBinary = generatorPubEccPnt.GetEncoded(true)

    { Prv = generatorPrvBinary; Pub = generatorPubBinary }

let computeAccountKeys n generatorKeys =

    let rootKeyPrvBigint = generatorKeys.Prv |> Binary.toBigint

    let appendSeqNumber input =
        appendSeqNumber input n |> appendSeqNumber

    let hashBigint = generatorKeys.Pub |> computeKeysHash appendSeqNumber

    let accountKeyPrvBigint = hashBigint.Add(rootKeyPrvBigint).Mod(eccOrder)
    let accountKeyPubEccPnt = eccBasePoint.Multiply(accountKeyPrvBigint)
    let accountKeyPrvBinary = accountKeyPrvBigint |> Binary.ofBigint
    let accountKeyPubBinary = accountKeyPubEccPnt.GetEncoded(true)

    { Prv = accountKeyPrvBinary; Pub = accountKeyPubBinary }

let computeAccountId accountKeys =
    use sha256 = SHA256.Create()
    use rmd160 = RIPEMD160.Create()
    accountKeys.Pub
    |> sha256.ComputeHash
    |> rmd160.ComputeHash

//-------------------------------------------------------------------------------------------------

let private computeSignatureEcc accountKeys input =

    let accountKeyPrvBigint = accountKeys.Prv |> Binary.toBigint
    let eccDomainParameters = ECDomainParameters(eccParams.Curve, eccParams.G, eccParams.N, eccParams.H)
    let eccPrvKeyParameters = ECPrivateKeyParameters(accountKeyPrvBigint, eccDomainParameters)

    let signer = ECDsaSigner()
    signer.Init(true, eccPrvKeyParameters)

    let sigs = signer.GenerateSignature(input)
    let r = sigs.[0]
    let s = sigs.[1]

    let sOther = eccOrder.Subtract(s)
    let s = if s.CompareTo(sOther) > 0 then sOther else s

    (r, s)

let private encodeToDer (r, s) =

    use stream = new IO.MemoryStream()
    let generator = DerSequenceGenerator(stream)
    generator.AddObject(DerInteger(r : BigInteger))
    generator.AddObject(DerInteger(s : BigInteger))
    generator.Close()
    stream.ToArray()

let computeSignature accountKeys input =
    input
    |> computeSignatureEcc accountKeys
    |> encodeToDer
