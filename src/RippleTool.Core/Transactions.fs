module RippleTool.Transactions

open System
open RippleTool.Encoding
open RippleTool.TransactionTypes

//-------------------------------------------------------------------------------------------------

module Binary =

    let rec private pow10 x n =
        match n with
        | n when n > 0 -> pow10 (x * 10m) (n - 1)
        | n when n < 0 -> pow10 (x / 10m) (n + 1)
        | _ -> x

    let rec private log10 x n =
        match x with
        | 0m -> n
        | x when x < 1.0m -> log10 (x * 10m) (n - 1)
        | x when x >= 10m -> log10 (x / 10m) (n + 1)
        | x -> n

    let private ofNativeAmount (input : NativeAmount) =

        let value = input

        let typeFlag = 0
        let signFlag = if value < Decimal.Zero then 0 else 1
        let valueAbs = if value < Decimal.Zero then Decimal.Negate(value) else value

        if (valueAbs > 4611686018427.387903m) then
            failwith "Native amount absolute value cannot exceed 4611686018427.387903."

        let mantissa = Decimal.Round(valueAbs, 6)
        let mantissa = pow10 mantissa <| 6

        let bits1 = uint64 typeFlag <<< 63
        let bits2 = uint64 signFlag <<< 62
        let bits3 = uint64 mantissa <<< 00

        let combined = Array.fold (|||) 0UL [| bits1; bits2; bits3 |]

        Binary.ofUint64 combined

    let private ofIssuedAmount (input : IssuedAmount) =

        let value = input.Value

        let typeFlag = 1
        let signFlag = if value > Decimal.Zero then 1 else 0
        let valueAbs = if value < Decimal.Zero then Decimal.Negate(value) else value

        let exponent = log10 valueAbs <| 0
        let mantissa = pow10 valueAbs <| 0 - exponent - 1
        let mantissa = Decimal.Round(mantissa, 16)
        let mantissa = pow10 mantissa <| 16
        let exponent = if value = Decimal.Zero then 0 else (97 - 15 + exponent)

        let bits1 = uint64 typeFlag <<< 63
        let bits2 = uint64 signFlag <<< 62
        let bits3 = uint64 exponent <<< 54
        let bits4 = uint64 mantissa <<< 00

        let combined = Array.fold (|||) 0UL [| bits1; bits2; bits3; bits4 |]

        let bytes1 = Binary.ofUint64 combined
        let bytes2 = Array.zeroCreate<byte> 12
        let bytes3 = input.Currency |> Seq.map byte |> Seq.toArray
        let bytes4 = Array.zeroCreate<byte> 5
        let bytes5 = Base58.decodeAccountId input.Issuer

        Array.concat [ bytes1; bytes2; bytes3; bytes4; bytes5 ]

    let private encodeLength = function

        | length when length <= 192u
            ->
            [| byte length |]

        | length when length <= 12480u
            ->
            let value = length - 193u
            let byte1 = byte ((value >>> 08) + 193u)
            let byte2 = byte ((value >>> 00) &&& 0xFFu)
            [| byte1; byte2 |]

        | length when length <= 918744u
            ->
            let value = length - 12481u
            let byte1 = byte ((value >>> 16) + 241u)
            let byte2 = byte ((value >>> 08) &&& 0xFFu)
            let byte3 = byte ((value >>> 00) &&& 0xFFu)
            [| byte1; byte2; byte3 |]

        | _ -> failwith "Cannot encode variable length data greater than 918744 bytes."

    let ofAmount = function
        | NativeAmount amount -> ofNativeAmount amount
        | IssuedAmount amount -> ofIssuedAmount amount

    let ofVariable (input : byte[]) =

        let binary = input
        let length = encodeLength (uint32 binary.Length)
        Array.concat [ length; binary ]

    let ofAccount (input : string) =

        let binary = Base58.decodeAccountId input
        let length = encodeLength (uint32 binary.Length)
        Array.concat [ length; binary ]

//-------------------------------------------------------------------------------------------------

type private TransactionType =
    | AccountSet    = 03us
    | OfferCancel   = 08us
    | OfferCreate   = 07us
    | Payment       = 00us
    | SetRegularKey = 05us
    | TrustSet      = 20us

type private FieldType =
    | UInt16'TransactionType
    | UInt32'Flags
    | UInt32'Sequence
    | Amount'Amount
    | Amount'Limit
    | Amount'Fee
    | Variable'SigningPubKey
    | Variable'TxnSignature
    | Account'Account
    | Account'Destination

type private Field = { Type : FieldType; Value : byte[] }

//-------------------------------------------------------------------------------------------------

let private fieldsFromAccountSet (transaction : AccountSet) =

    failwith "Not implemented"

let private fieldsFromOfferCancel (transaction : OfferCancel) =

    failwith "Not implemented"

let private fieldsFromOfferCreate (transaction : OfferCreate) =

    failwith "Not implemented"

let private fieldsFromPayment (transaction : Payment) =

    let transactionType = uint16 TransactionType.Payment

    [ { Type = UInt16'TransactionType; Value = Binary.ofUint16  transactionType }
      { Type = Account'Account;        Value = Binary.ofAccount transaction.Account }
      { Type = Amount'Fee;             Value = Binary.ofAmount  transaction.Fee }
      { Type = UInt32'Sequence;        Value = Binary.ofUint32  transaction.Sequence }
      { Type = UInt32'Flags;           Value = Binary.ofUint32  transaction.Flags }
      { Type = Account'Destination;    Value = Binary.ofAccount transaction.Destination }
      { Type = Amount'Amount;          Value = Binary.ofAmount  transaction.Amount } ]

let private fieldsFromSetRegularKey (transaction : SetRegularKey) =

    failwith "Not implemented"

let private fieldsFromTrustSet (transaction : TrustSet) =

    let transactionType = uint16 TransactionType.TrustSet

    [ { Type = UInt16'TransactionType; Value = Binary.ofUint16  transactionType }
      { Type = Account'Account;        Value = Binary.ofAccount transaction.Account }
      { Type = Amount'Fee;             Value = Binary.ofAmount  transaction.Fee }
      { Type = UInt32'Sequence;        Value = Binary.ofUint32  transaction.Sequence }
      { Type = UInt32'Flags;           Value = Binary.ofUint32  transaction.Flags }
      { Type = Amount'Limit;           Value = Binary.ofAmount  transaction.LimitAmount } ]

//-------------------------------------------------------------------------------------------------

let private fieldsFromTransaction = function
    | AccountSet    transaction -> transaction |> fieldsFromAccountSet
    | OfferCancel   transaction -> transaction |> fieldsFromOfferCancel
    | OfferCreate   transaction -> transaction |> fieldsFromOfferCreate
    | Payment       transaction -> transaction |> fieldsFromPayment
    | SetRegularKey transaction -> transaction |> fieldsFromSetRegularKey
    | TrustSet      transaction -> transaction |> fieldsFromTrustSet

let private fieldOrdinal = function
    | UInt16'TransactionType -> (1, 2)
    | UInt32'Flags           -> (2, 2)
    | UInt32'Sequence        -> (2, 4)
    | Amount'Amount          -> (6, 1)
    | Amount'Limit           -> (6, 3)
    | Amount'Fee             -> (6, 8)
    | Variable'SigningPubKey -> (7, 3)
    | Variable'TxnSignature  -> (7, 4)
    | Account'Account        -> (8, 1)
    | Account'Destination    -> (8, 3)

let private fieldToBytes field =

    let fieldType, fieldName = fieldOrdinal field.Type
    let fieldHead = [| byte <| (fieldType <<< 4) + fieldName |]
    Array.concat [ fieldHead; field.Value ]

let serialize transaction signingPublicKey signature =

    let signingFields = [ { Type = Variable'SigningPubKey; Value = Binary.ofVariable signingPublicKey } ]
    let signingFields =
        match signature with
        | Some signature
            -> signingFields @ [ { Type = Variable'TxnSignature; Value = Binary.ofVariable signature } ]
        | _ -> signingFields

    transaction
    |> fieldsFromTransaction
    |> List.append signingFields
    |> List.sortBy (fun field -> fieldOrdinal field.Type)
    |> List.map fieldToBytes
    |> Array.concat

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
