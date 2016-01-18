module RippleTool.TransactionSerialization

open RippleTool.TransactionTypes
open RippleTool.TransactionEncoding

//-------------------------------------------------------------------------------------------------

type private TransactionType =
    | Payment       = 00us
    | AccountSet    = 03us
    | SetRegularKey = 05us
    | OfferCreate   = 07us
    | OfferCancel   = 08us
    | TrustSet      = 20us

type private FieldType =
    | UInt16'TransactionType
    | UInt32'Flags
    | UInt32'Sequence
    | Amount'Limit
    | Amount'Fee
    | Variable'SigningPubKey
    | Variable'TxnSignature
    | Account'Account

type private Field = { Type : FieldType; Value : byte[] }

//-------------------------------------------------------------------------------------------------

let private fieldsFromPayment (transaction : Payment) =

    failwith "Not implemented"

let private fieldsFromAccountSet (transaction : AccountSet) =

    failwith "Not implemented"

let private fieldsFromSetRegularKey (transaction : SetRegularKey) =

    failwith "Not implemented"

let private fieldsFromOfferCreate (transaction : OfferCreate) =

    failwith "Not implemented"

let private fieldsFromOfferCancel (transaction : OfferCancel) =

    failwith "Not implemented"

let private fieldsFromTrustSet (transaction : TrustSet) =

    let transactionType = uint16 TransactionType.TrustSet

    let fields =
        [ { Type = UInt16'TransactionType; Value = toBinaryUInt16  transactionType }
          { Type = Account'Account;        Value = toBinaryAccount transaction.Account }
          { Type = Amount'Fee;             Value = toBinaryAmount  transaction.Fee }
          { Type = UInt32'Flags;           Value = toBinaryUInt32  transaction.Flags }
          { Type = UInt32'Sequence;        Value = toBinaryUInt32  transaction.Sequence }
          { Type = Amount'Limit;           Value = toBinaryAmount  transaction.LimitAmount }
        ]

    fields

//-------------------------------------------------------------------------------------------------

let private fieldsFromTransaction = function
    | Payment       transaction -> transaction |> fieldsFromPayment
    | AccountSet    transaction -> transaction |> fieldsFromAccountSet
    | SetRegularKey transaction -> transaction |> fieldsFromSetRegularKey
    | OfferCreate   transaction -> transaction |> fieldsFromOfferCreate
    | OfferCancel   transaction -> transaction |> fieldsFromOfferCancel
    | TrustSet      transaction -> transaction |> fieldsFromTrustSet

let private fieldOrdinal = function
    | UInt16'TransactionType -> (1, 2)
    | UInt32'Flags           -> (2, 2)
    | UInt32'Sequence        -> (2, 4)
    | Amount'Limit           -> (6, 3)
    | Amount'Fee             -> (6, 8)
    | Variable'SigningPubKey -> (7, 3)
    | Variable'TxnSignature  -> (7, 4)
    | Account'Account        -> (8, 1)

let private fieldToBytes field =

    let fieldType, fieldName = fieldOrdinal field.Type
    let fieldHead = [| byte <| (fieldType <<< 4) + fieldName |]
    Array.concat [ fieldHead; field.Value ]

let serialize transaction signingPublicKey signature =

    let signingFields = [ { Type = Variable'SigningPubKey; Value = toBinaryVariable signingPublicKey } ] 
    let signingFields =
        match signature with
        | Some signature
            -> signingFields @ [ { Type = Variable'TxnSignature; Value = toBinaryVariable signature } ]
        | _ -> signingFields

    transaction
    |> fieldsFromTransaction
    |> List.append signingFields
    |> List.sortBy (fun field -> fieldOrdinal field.Type)
    |> List.map fieldToBytes
    |> Array.concat
