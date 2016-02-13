module RippleTool.Crypto

open System.Security.Cryptography
open Org.BouncyCastle.Asn1.Sec
open Org.BouncyCastle.Math
open RippleTool.Encoding

//-------------------------------------------------------------------------------------------------

let ecParameters = SecNamedCurves.GetByName("secp256k1")
let ecBasePoint = ecParameters.G
let ecOrder = ecParameters.N

//-------------------------------------------------------------------------------------------------

module private Binary =

    let ofBigint (input : BigInteger) =
        input.ToByteArrayUnsigned()

    let toBigint (input : byte[]) =
        BigInteger(1, input)

//-------------------------------------------------------------------------------------------------

let private appendSeqNumber input = Array.append input << Binary.ofUint32

type Keys = { Prv : byte[]; Pub : byte[] }

let computeHash (input : byte[]) =
    use sha512 = SHA512.Create()
    input
    |> sha512.ComputeHash
    |> Array.take 32

let private computeKeysHash appendSeqNumber input =
    let generator i = Some (appendSeqNumber input i, i + 1u)
    0u
    |> Seq.unfold generator
    |> Seq.map computeHash
    |> Seq.map Binary.toBigint
    |> Seq.find (fun hash -> hash.CompareTo(ecOrder) < 0)

let computeRootKeys secretKeyBinary =

    let generatorPrvBigint = secretKeyBinary |> computeKeysHash appendSeqNumber
    let generatorPubEccPnt = ecBasePoint.Multiply(generatorPrvBigint)
    let generatorPrvBinary = generatorPrvBigint |> Binary.ofBigint
    let generatorPubBinary = generatorPubEccPnt.GetEncoded(true)

    { Prv = generatorPrvBinary; Pub = generatorPubBinary }

let computeAccountKeys n generatorKeys =

    let rootKeyPrvBigint = generatorKeys.Prv |> Binary.toBigint

    let appendSeqNumber input =
        appendSeqNumber input n |> appendSeqNumber

    let hashBigint = generatorKeys.Pub |> computeKeysHash appendSeqNumber

    let accountKeyPrvBigint = hashBigint.Add(rootKeyPrvBigint).Mod(ecOrder)
    let accountKeyPubEccPnt = ecBasePoint.Multiply(accountKeyPrvBigint)
    let accountKeyPrvBinary = accountKeyPrvBigint |> Binary.ofBigint
    let accountKeyPubBinary = accountKeyPubEccPnt.GetEncoded(true)

    { Prv = accountKeyPrvBinary; Pub = accountKeyPubBinary }

let computeAccountId accountKeys =
    use sha256 = SHA256.Create()
    use rmd160 = RIPEMD160.Create()
    accountKeys.Pub
    |> sha256.ComputeHash
    |> rmd160.ComputeHash
