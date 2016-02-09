module RippleTool.TransactionSigning

open System
open System.Security.Cryptography
open Org.BouncyCastle.Asn1
open Org.BouncyCastle.Asn1.Sec
open Org.BouncyCastle.Crypto.Parameters
open Org.BouncyCastle.Crypto.Signers
open Org.BouncyCastle.Math
open RippleTool.Encoding
open RippleTool.TransactionSerialization

//-------------------------------------------------------------------------------------------------

let private ecParameters = SecNamedCurves.GetByName("secp256k1")
let private ecOrder = ecParameters.N
let private ecBasePoint = ecParameters.G

let private computeHalfSha512 (input : byte[]) =

    use provider = new SHA512CryptoServiceProvider()
    let hashFull = provider.ComputeHash(input)
    let hashHalf = hashFull.[.. (256 / 8) - 1]

    hashHalf

let private appendSequenceNumber i input =

    Array.concat [ input; Binary.ofUint32 i ]

let private secretKeyToBigInt secretKey =

    let secretKeyBinary = Base58.decodeSecretKey secretKey

    let rec loop i input =
        let keyBinary = input |> appendSequenceNumber i |> computeHalfSha512
        let keyBigInt = BigInteger(1, keyBinary)
        if (keyBigInt.CompareTo(ecOrder) < 0) then keyBigInt else input |> loop (i + 1u)

    secretKeyBinary |> loop 0u

let private createEcdsaSignature input secretKey =

    let generatorPrvBigInt = secretKeyToBigInt secretKey
    let generatorPubBinary = ecBasePoint.Multiply(generatorPrvBigInt).GetEncoded(true)

    let n = 0u

    let rec loop i input =
        let keyBinary = input |> appendSequenceNumber n |> appendSequenceNumber i |> computeHalfSha512
        let keyBigInt = BigInteger(1, keyBinary)
        if (keyBigInt.CompareTo(ecOrder) < 0) then keyBigInt else input |> loop (i + 1u)

    let hashBigInt = generatorPubBinary |> loop 0u
    let prvKeyBigInt = hashBigInt.Add(generatorPrvBigInt).Mod(ecOrder)

    let ecDomainParameters = ECDomainParameters(ecParameters.Curve, ecParameters.G, ecParameters.N, ecParameters.H)
    let ecPrivateKeyParameters = ECPrivateKeyParameters(prvKeyBigInt, ecDomainParameters)

    let signer = ECDsaSigner()
    signer.Init(true, ecPrivateKeyParameters)

    let sigs = signer.GenerateSignature(input)
    let r = sigs.[0]
    let s = sigs.[1]

    let sOther = ecOrder.Subtract(s)
    let s = if s.CompareTo(sOther) > 0 then sOther else s

    (r, s)

let private encodeToDer (r, s) =

    use stream = new System.IO.MemoryStream()
    let generator = DerSequenceGenerator(stream)
    generator.AddObject(DerInteger(r : BigInteger))
    generator.AddObject(DerInteger(s : BigInteger))
    generator.Close()
    stream.ToArray()

let private computeSigningHash serializedTransaction =

    let prefix = Text.Encoding.UTF8.GetBytes("STX\u0000")
    let binary = Array.concat [ prefix; serializedTransaction ]
    computeHalfSha512 binary

let private computeSignature serializedTransaction secretKey =

    let signingHash = computeSigningHash serializedTransaction
    let (r, s) = createEcdsaSignature signingHash secretKey
    encodeToDer (r, s)

let private computeSigningPubKey secretKey =

    let generatorPrvBigInt = secretKeyToBigInt secretKey
    let generatorPubBinary = ecBasePoint.Multiply(generatorPrvBigInt).GetEncoded(true)

    let n = 0u

    let rec loop i input =
        let keyBinary = input |> appendSequenceNumber n |> appendSequenceNumber i |> computeHalfSha512
        let keyBigInt = BigInteger(1, keyBinary)
        if (keyBigInt.CompareTo(ecOrder) < 0) then keyBigInt else input |> loop (i + 1u)

    let hashBigInt = generatorPubBinary |> loop 0u

    let generatorPubEcPoint = ecBasePoint.Multiply(generatorPrvBigInt)
    let pubKeyBinary = ecBasePoint.Multiply(hashBigInt).Add(generatorPubEcPoint).GetEncoded(true)

    pubKeyBinary

let sign transaction secretKey =

    let signingPublicKey = computeSigningPubKey secretKey
    let transactionBinary = serialize transaction signingPublicKey (None)
    let signature = computeSignature transactionBinary secretKey
    let transactionBinary = serialize transaction signingPublicKey (Some signature)

    transactionBinary |> Binary.toHex
