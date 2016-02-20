module RippleTool.TransactionSerialization

open RippleTool.Encoding
open RippleTool.TransactionTypes
open RippleTool.TransactionEncoding

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
