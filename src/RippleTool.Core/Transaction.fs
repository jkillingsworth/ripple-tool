module RippleTool.Transaction

open System
open RippleTool.Encoding
open RippleTool.Types

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

    let private ofIssuedAmount value currency =

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

        let bytes1 = Binary.ofUInt64 combined
        let bytes2 = Array.zeroCreate<byte> 12
        let bytes3 = currency.Code |> Seq.map byte |> Seq.toArray
        let bytes4 = Array.zeroCreate<byte> 5
        let bytes5 = Base58.decodeAccountId currency.Issuer

        Array.concat [ bytes1; bytes2; bytes3; bytes4; bytes5 ]

    let private ofNativeAmount value currency =

        let typeFlag = 0
        let signFlag = if value < Decimal.Zero then 0 else 1
        let valueAbs = if value < Decimal.Zero then Decimal.Negate(value) else value

        if (valueAbs > 100000000000m) then
            failwith "Native amount absolute value cannot exceed 100000000000."

        let mantissa = Decimal.Round(valueAbs, 6)
        let mantissa = pow10 mantissa <| 6

        let bits1 = uint64 typeFlag <<< 63
        let bits2 = uint64 signFlag <<< 62
        let bits3 = uint64 mantissa <<< 00

        let combined = Array.fold (|||) 0UL [| bits1; bits2; bits3 |]

        Binary.ofUInt64 combined

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

    let ofEnum (input : 'T when 'T : enum<uint32>) =
        input
        |> LanguagePrimitives.EnumToValue
        |> Binary.ofUInt32

    let ofPercent (input : decimal) =
        input
        |> (*) 1000000000m
        |> Decimal.Round
        |> uint32
        |> Binary.ofUInt32

    let ofAmount = function
        | { Value = value; Currency = IssuedCurrency currency } -> ofIssuedAmount value currency
        | { Value = value; Currency = NativeCurrency currency } -> ofNativeAmount value currency

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
    | Payment       = 00us
    | AccountSet    = 03us
    | SetRegularKey = 05us
    | OfferCreate   = 07us
    | OfferCancel   = 08us
    | TrustSet      = 20us

type private FieldKind =
    | UInt16'TransactionType
    | UInt32'Flags
    | UInt32'SourceTag
    | UInt32'Sequence
    | UInt32'TransferRate
    | UInt32'DestinationTag
    | UInt32'QualityIn
    | UInt32'QualityOut
    | UInt32'LastLedgerSequence
    | UInt32'SetFlag
    | UInt32'ClearFlag
    | Amount'Amount
    | Amount'Limit
    | Amount'Fee
    | Variable'SigningPubKey
    | Variable'TxnSignature
    | Account'Account
    | Account'Destination

let private fieldOrdinal = function
    | UInt16'TransactionType    -> (1,  2)
    | UInt32'Flags              -> (2,  2)
    | UInt32'SourceTag          -> (2,  3)
    | UInt32'Sequence           -> (2,  4)
    | UInt32'TransferRate       -> (2, 11)
    | UInt32'DestinationTag     -> (2, 14)
    | UInt32'QualityIn          -> (2, 20)
    | UInt32'QualityOut         -> (2, 21)
    | UInt32'LastLedgerSequence -> (2, 27)
    | UInt32'SetFlag            -> (2, 33)
    | UInt32'ClearFlag          -> (2, 34)
    | Amount'Amount             -> (6,  1)
    | Amount'Limit              -> (6,  3)
    | Amount'Fee                -> (6,  8)
    | Variable'SigningPubKey    -> (7,  3)
    | Variable'TxnSignature     -> (7,  4)
    | Account'Account           -> (8,  1)
    | Account'Destination       -> (8,  3)

type private Field = { Kind : FieldKind; Data : byte[] }

//-------------------------------------------------------------------------------------------------

module private Fields =

    let private required kind toBinary value fields =
        { Kind = kind; Data = toBinary value } :: fields

    let private optional kind toBinary = function
        | Some value -> value |> required kind toBinary
        | None -> id

    let private ofPayment (transaction : Payment) =

        let transactionType = uint16 TransactionType.Payment
        []
        |> required UInt16'TransactionType    Binary.ofUInt16  transactionType
        |> required Account'Account           Binary.ofAccount transaction.Account
        |> required Amount'Fee                Binary.ofAmount  transaction.Fee
        |> required UInt32'Sequence           Binary.ofUInt32  transaction.Sequence
        |> optional UInt32'LastLedgerSequence Binary.ofUInt32  transaction.LastLedgerSequence
        |> required UInt32'Flags              Binary.ofEnum    transaction.Flags
        |> optional UInt32'SourceTag          Binary.ofUInt32  transaction.SourceTag
        |> optional UInt32'DestinationTag     Binary.ofUInt32  transaction.DestinationTag
        |> required Account'Destination       Binary.ofAccount transaction.Destination
        |> required Amount'Amount             Binary.ofAmount  transaction.Amount

    let private ofAccountSet (transaction : AccountSet) =

        let transactionType = uint16 TransactionType.AccountSet
        []
        |> required UInt16'TransactionType    Binary.ofUInt16  transactionType
        |> required Account'Account           Binary.ofAccount transaction.Account
        |> required Amount'Fee                Binary.ofAmount  transaction.Fee
        |> required UInt32'Sequence           Binary.ofUInt32  transaction.Sequence
        |> optional UInt32'LastLedgerSequence Binary.ofUInt32  transaction.LastLedgerSequence
        |> required UInt32'Flags              Binary.ofEnum    transaction.Flags
        |> optional UInt32'SetFlag            Binary.ofEnum    transaction.SetFlag
        |> optional UInt32'ClearFlag          Binary.ofEnum    transaction.ClearFlag
        |> optional UInt32'TransferRate       Binary.ofPercent transaction.TransferRate

    let private ofSetRegularKey (transaction : SetRegularKey) =

        failwith "Not implemented"

    let private ofOfferCreate (transaction : OfferCreate) =

        failwith "Not implemented"

    let private ofOfferCancel (transaction : OfferCancel) =

        failwith "Not implemented"

    let private ofTrustSet (transaction : TrustSet) =

        let transactionType = uint16 TransactionType.TrustSet
        []
        |> required UInt16'TransactionType    Binary.ofUInt16  transactionType
        |> required Account'Account           Binary.ofAccount transaction.Account
        |> required Amount'Fee                Binary.ofAmount  transaction.Fee
        |> required UInt32'Sequence           Binary.ofUInt32  transaction.Sequence
        |> optional UInt32'LastLedgerSequence Binary.ofUInt32  transaction.LastLedgerSequence
        |> required UInt32'Flags              Binary.ofEnum    transaction.Flags
        |> required Amount'Limit              Binary.ofAmount  transaction.LimitAmount
        |> optional UInt32'QualityIn          Binary.ofPercent transaction.QualityIn
        |> optional UInt32'QualityOut         Binary.ofPercent transaction.QualityOut

    let ofTransaction = function
        | Payment       transaction -> transaction |> ofPayment
        | AccountSet    transaction -> transaction |> ofAccountSet
        | SetRegularKey transaction -> transaction |> ofSetRegularKey
        | OfferCreate   transaction -> transaction |> ofOfferCreate
        | OfferCancel   transaction -> transaction |> ofOfferCancel
        | TrustSet      transaction -> transaction |> ofTrustSet

    let appendSigningPublicKey =
        Binary.ofVariable |> required Variable'SigningPubKey

    let appendSignature =
        Binary.ofVariable |> optional Variable'TxnSignature

    let sort =
        List.sortBy (fun field -> fieldOrdinal field.Kind)

//-------------------------------------------------------------------------------------------------

let private serializeFieldKind = function
    | fieldType, fieldName when fieldType > 15 -> [| byte (fieldName <<< 0); byte fieldType |]
    | fieldType, fieldName when fieldName > 15 -> [| byte (fieldType <<< 4); byte fieldName |]
    | fieldType, fieldName -> [| byte <| (fieldType <<< 4) + (fieldName <<< 0) |]

let private serializeField field =
    let binaryKind = field.Kind |> fieldOrdinal |> serializeFieldKind
    let binaryData = field.Data
    Array.concat [ binaryKind; binaryData ]

let serialize signingPublicKey signature transaction =

    transaction
    |> Fields.ofTransaction
    |> Fields.appendSigningPublicKey signingPublicKey
    |> Fields.appendSignature signature
    |> Fields.sort
    |> List.map serializeField
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

let sign secretKey transaction =

    let accountKeys = secretKey |> getAccountKeys 0u
    let signatureOf = computeSigningHash >> Crypto.computeSignature accountKeys >> Some
    let transactionBinary = transaction |> serialize accountKeys.Pub (None)
    let transactionBinary = transaction |> serialize accountKeys.Pub (signatureOf transactionBinary)

    transactionBinary
