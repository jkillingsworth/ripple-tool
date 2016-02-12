module RippleTool.TransactionSigning

open System
open Org.BouncyCastle.Asn1
open Org.BouncyCastle.Crypto.Parameters
open Org.BouncyCastle.Crypto.Signers
open Org.BouncyCastle.Math
open RippleTool.Encoding
open RippleTool.TransactionSerialization

//-------------------------------------------------------------------------------------------------

let private createEcdsaSignature input (accountKeys : Crypto.Keys) =

    let prvKeyBigInt = BigInteger(1, accountKeys.Prv)

    let ecParameters = Crypto.ecParameters
    let ecDomainParameters = ECDomainParameters(ecParameters.Curve, ecParameters.G, ecParameters.N, ecParameters.H)
    let ecPrivateKeyParameters = ECPrivateKeyParameters(prvKeyBigInt, ecDomainParameters)

    let signer = ECDsaSigner()
    signer.Init(true, ecPrivateKeyParameters)

    let sigs = signer.GenerateSignature(input)
    let r = sigs.[0]
    let s = sigs.[1]

    let sOther = Crypto.ecOrder.Subtract(s)
    let s = if s.CompareTo(sOther) > 0 then sOther else s

    (r, s)

let private encodeToDer (r, s) =

    use stream = new System.IO.MemoryStream()
    let generator = DerSequenceGenerator(stream)
    generator.AddObject(DerInteger(r : BigInteger))
    generator.AddObject(DerInteger(s : BigInteger))
    generator.Close()
    stream.ToArray()

//-------------------------------------------------------------------------------------------------

let private computeSigningHash serializedTransaction =

    let prefix = Text.Encoding.UTF8.GetBytes("STX\u0000")
    let binary = Array.concat [ prefix; serializedTransaction ]
    Crypto.computeHash binary

let private computeSignature serializedTransaction accountKeys =

    let signingHash = computeSigningHash serializedTransaction
    let (r, s) = createEcdsaSignature signingHash accountKeys
    encodeToDer (r, s)

let sign transaction secretKey =

    let accountKeys =
        secretKey
        |> Base58.decodeSecretKey
        |> Crypto.computeRootKeys
        |> Crypto.computeAccountKeys 0u

    let signingPublicKey = accountKeys.Pub
    let transactionBinary = serialize transaction signingPublicKey (None)
    let signature = computeSignature transactionBinary accountKeys
    let transactionBinary = serialize transaction signingPublicKey (Some signature)

    transactionBinary |> Binary.toHex
