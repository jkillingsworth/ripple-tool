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

type Keys = { Prv : byte[]; Pub : byte[] }

let computeHash (input : byte[]) =
    use sha512 = SHA512.Create()
    input
    |> sha512.ComputeHash
    |> Array.take 32

let private appendSeqNumber input = Array.append input << Binary.ofUint32

let private computeHashLoop appendSeqNumber input =
    let generator i = Some (appendSeqNumber input i, i + 1u)
    0u
    |> Seq.unfold generator
    |> Seq.map computeHash
    |> Seq.map Binary.toBigint
    |> Seq.find (fun hash -> hash.CompareTo(ecOrder) < 0)

let computeRootKeys secretKeyBinary =

    let generatorPrvBigint = secretKeyBinary |> computeHashLoop appendSeqNumber
    let generatorPubEccPnt = ecBasePoint.Multiply(generatorPrvBigint)
    let generatorPrvBinary = generatorPrvBigint |> Binary.ofBigint
    let generatorPubBinary = generatorPubEccPnt.GetEncoded(true)

    { Prv = generatorPrvBinary; Pub = generatorPubBinary }

let computeAccountKeys n generatorKeys =

    let rootKeyPrvBigint = generatorKeys.Prv |> Binary.toBigint

    let appendSeqNumber input =
        appendSeqNumber <| appendSeqNumber input n

    let hashBigint = generatorKeys.Pub |> computeHashLoop appendSeqNumber

    let accountKeyPrvBigint = hashBigint.Add(rootKeyPrvBigint).Mod(ecOrder)
    let accountKeyPubEccPnt = ecBasePoint.Multiply(accountKeyPrvBigint)
    let accountKeyPrvBinary = accountKeyPrvBigint |> Binary.ofBigint
    let accountKeyPubBinary = accountKeyPubEccPnt.GetEncoded(true)

    { Prv = accountKeyPrvBinary; Pub = accountKeyPubBinary }
