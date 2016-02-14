module RippleTool.TransactionSigning

open System
open RippleTool.Encoding
open RippleTool.TransactionSerialization

//-------------------------------------------------------------------------------------------------

let private computeSigningHash transactionBinary =

    let prefix = Text.Encoding.UTF8.GetBytes("STX\u0000")
    let binary = Array.concat [ prefix; transactionBinary ]
    Crypto.computeHash binary

let private getAccountKeys n secretKey =
    secretKey
    |> Base58.decodeSecretKey
    |> Crypto.computeRootKeys
    |> Crypto.computeAccountKeys n

let sign transaction secretKey =

    let accountKeys = secretKey |> getAccountKeys 0u
    let transactionBinary = serialize transaction accountKeys.Pub (None)
    let signature = transactionBinary |> computeSigningHash |> Crypto.computeSignature accountKeys
    let transactionBinary = serialize transaction accountKeys.Pub (Some signature)

    transactionBinary |> Binary.toHex
