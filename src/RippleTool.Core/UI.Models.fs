module RippleTool.UI.Models

open System
open System.ComponentModel
open Microsoft.FSharp.Quotations.Patterns
open RippleTool.Types
open RippleTool.CommandTypes
open RippleTool.TransactionTypes
open RippleTool.Integration

//-------------------------------------------------------------------------------------------------

[<AbstractClass>]
type Model() =

    let propertyName = function
        | PropertyGet (_, info, _) -> info.Name
        | _ -> failwith "Expecting a property expression."

    let propertyChanged = Event<_, _>()

    interface INotifyPropertyChanged with

        [<CLIEvent>]
        member this.PropertyChanged = propertyChanged.Publish

    member this.OnPropertyChanged(expr) =
        let name = propertyName expr
        let args = PropertyChangedEventArgs(name)
        propertyChanged.Trigger(this, args)

//-------------------------------------------------------------------------------------------------

let private set (this : Model) value field expr =
    field := value
    this.OnPropertyChanged(expr)

let private optional value map =
    match value with
    | value when value = "" -> None
    | value -> value |> map |> Some

let private toCurrency code issuer = function
    | true  -> IssuedCurrency <| { Code = code; Issuer = issuer }
    | false -> NativeCurrency <| NativeCurrency.NativeCurrency

let private toIssuedAmount value currency issuer =
    IssuedAmount <| { Value = Decimal.Parse value; Currency = currency; Issuer = issuer }

let private toNativeAmount value =
    NativeAmount <| Decimal.Parse value

let private toAmount value currency issuer = function
    | true  -> toIssuedAmount value currency issuer
    | false -> toNativeAmount value

let private combineFlag flag (add : 'T) (acc : 'T) : 'T =
    let add = LanguagePrimitives.EnumToValue(add)
    let acc = LanguagePrimitives.EnumToValue(acc)
    let res = if flag then acc ||| add else acc
    LanguagePrimitives.EnumOfValue(res)

//-------------------------------------------------------------------------------------------------

type LedgerOption = { Value : Ledger; Display : string }

type LedgerOptions() as this =

    inherit BindingList<LedgerOption>()

    do this.Add({ Value = Ledger.Validated; Display = "Validated" })
    do this.Add({ Value = Ledger.Current;   Display = "Current" })
    do this.Add({ Value = Ledger.Closed;    Display = "Closed" })

//-------------------------------------------------------------------------------------------------

type AccountCurrenciesModel() =

    inherit Model()

    let ledger = ref Ledger.Validated
    let account = ref ""

    member this.Ledger
        with get () = !ledger
        and set value = set this value ledger <@ this.Ledger @>

    member this.Account
        with get () = !account
        and set value = set this value account <@ this.Account @>

    member this.Submit() =

        let command : AccountCurrencies =
            { Ledger = !ledger
              Account = !account }

        executeCommand (command |> AccountCurrencies)

//-------------------------------------------------------------------------------------------------

type BookOffersModel() =

    inherit Model()

    let taker = ref ""
    let limit = ref ""
    let takerGetsIsIssued = ref true
    let takerGetsIsNative = ref false
    let takerGetsCurrency = ref ""
    let takerGetsIssuer = ref ""
    let takerPaysIsIssued = ref true
    let takerPaysIsNative = ref false
    let takerPaysCurrency = ref ""
    let takerPaysIssuer = ref ""

    member this.Taker
        with get () = !taker
        and set value = set this value taker <@ this.Taker @>

    member this.Limit
        with get () = !limit
        and set value = set this value limit <@ this.Limit @>

    member this.TakerGetsIsIssued
        with get () = !takerGetsIsIssued
        and set value =
            let issued, native = (value, not value)
            set this issued takerGetsIsIssued <@ this.TakerGetsIsIssued @>
            set this native takerGetsIsNative <@ this.TakerGetsIsNative @>

    member this.TakerGetsIsNative
        with get () = !takerGetsIsNative
        and set value =
            let issued, native = (not value, value)
            set this issued takerGetsIsIssued <@ this.TakerGetsIsIssued @>
            set this native takerGetsIsNative <@ this.TakerGetsIsNative @>

    member this.TakerGetsCurrency
        with get () = !takerGetsCurrency
        and set value = set this value takerGetsCurrency <@ this.TakerGetsCurrency @>

    member this.TakerGetsIssuer
        with get () = !takerGetsIssuer
        and set value = set this value takerGetsIssuer <@ this.TakerGetsIssuer @>

    member this.TakerPaysIsIssued
        with get () = !takerPaysIsIssued
        and set value =
            let issued, native = (value, not value)
            set this issued takerPaysIsIssued <@ this.TakerPaysIsIssued @>
            set this native takerPaysIsNative <@ this.TakerPaysIsNative @>

    member this.TakerPaysIsNative
        with get () = !takerPaysIsNative
        and set value =
            let issued, native = (not value, value)
            set this issued takerPaysIsIssued <@ this.TakerPaysIsIssued @>
            set this native takerPaysIsNative <@ this.TakerPaysIsNative @>

    member this.TakerPaysCurrency
        with get () = !takerPaysCurrency
        and set value = set this value takerPaysCurrency <@ this.TakerPaysCurrency @>

    member this.TakerPaysIssuer
        with get () = !takerPaysIssuer
        and set value = set this value takerPaysIssuer <@ this.TakerPaysIssuer @>

    member this.Submit() =

        let taker = optional !taker id
        let limit = optional !limit UInt32.Parse

        let takerGets =
            !takerGetsIsIssued
            |> toCurrency !takerGetsCurrency !takerGetsIssuer

        let takerPays =
            !takerPaysIsIssued
            |> toCurrency !takerPaysCurrency !takerPaysIssuer

        let command =
            { Taker = taker
              Limit = limit
              TakerGets = takerGets
              TakerPays = takerPays }

        executeCommand (command |> BookOffers)

//-------------------------------------------------------------------------------------------------

type RipplePathFindModel() =

    inherit Model()

    let sourceAccount = ref ""
    let destinationAccount = ref ""
    let destinationAmountIsIssued = ref true
    let destinationAmountIsNative = ref false
    let destinationAmountValue = ref ""
    let destinationAmountCurrency = ref ""
    let destinationAmountIssuer = ref ""

    member this.SourceAccount
        with get () = !sourceAccount
        and set value = set this value sourceAccount <@ this.SourceAccount @>

    member this.DestinationAccount
        with get () = !destinationAccount
        and set value = set this value destinationAccount <@ this.DestinationAccount @>

    member this.DestinationAmountIsIssued
        with get () = !destinationAmountIsIssued
        and set value =
            let issued, native = (value, not value)
            set this issued destinationAmountIsIssued <@ this.DestinationAmountIsIssued @>
            set this native destinationAmountIsNative <@ this.DestinationAmountIsNative @>

    member this.DestinationAmountIsNative
        with get () = !destinationAmountIsNative
        and set value =
            let issued, native = (not value, value)
            set this issued destinationAmountIsIssued <@ this.DestinationAmountIsIssued @>
            set this native destinationAmountIsNative <@ this.DestinationAmountIsNative @>

    member this.DestinationAmountValue
        with get () = !destinationAmountValue
        and set value = set this value destinationAmountValue <@ this.DestinationAmountValue @>

    member this.DestinationAmountCurrency
        with get () = !destinationAmountCurrency
        and set value = set this value destinationAmountCurrency <@ this.DestinationAmountCurrency @>

    member this.DestinationAmountIssuer
        with get () = !destinationAmountIssuer
        and set value = set this value destinationAmountIssuer <@ this.DestinationAmountIssuer @>

    member this.Submit() =

        let destinationAmount =
            !destinationAmountIsIssued
            |> toAmount !destinationAmountValue !destinationAmountCurrency !destinationAmountIssuer

        let command =
            { SourceAccount = !sourceAccount
              DestinationAccount = !destinationAccount
              DestinationAmount = destinationAmount }

        executeCommand (command |> RipplePathFind)

//-------------------------------------------------------------------------------------------------

type SubmitPaymentModel() =

    inherit Model()

    let account = ref ""
    let fee = ref ""
    let sequence = ref ""
    let flagFullyCanonicalSig = ref true
    let destination = ref ""
    let amountIsIssued = ref true
    let amountIsNative = ref false
    let amountValue = ref ""
    let amountCurrency = ref ""
    let amountIssuer = ref ""

    member this.Account
        with get () = !account
        and set value = set this value account <@ this.Account @>

    member this.Fee
        with get () = !fee
        and set value = set this value fee <@ this.Fee @>

    member this.Sequence
        with get () = !sequence
        and set value = set this value sequence <@ this.Sequence @>

    member this.FlagFullyCanonicalSig
        with get () = !flagFullyCanonicalSig
        and set value = set this value flagFullyCanonicalSig <@ this.FlagFullyCanonicalSig @>

    member this.Destination
        with get () = !destination
        and set value = set this value destination <@ this.Destination @>

    member this.AmountIsIssued
        with get () = !amountIsIssued
        and set value =
            let issued, native = (value, not value)
            set this issued amountIsIssued <@ this.AmountIsIssued @>
            set this native amountIsNative <@ this.AmountIsNative @>

    member this.AmountIsNative
        with get () = !amountIsNative
        and set value =
            let issued, native = (not value, value)
            set this issued amountIsIssued <@ this.AmountIsIssued @>
            set this native amountIsNative <@ this.AmountIsNative @>

    member this.AmountValue
        with get () = !amountValue
        and set value = set this value amountValue <@ this.AmountValue @>

    member this.AmountCurrency
        with get () = !amountCurrency
        and set value = set this value amountCurrency <@ this.AmountCurrency @>

    member this.AmountIssuer
        with get () = !amountIssuer
        and set value = set this value amountIssuer <@ this.AmountIssuer @>

    member this.Submit() =

        let fee = toNativeAmount !fee

        let flags =
            PaymentFlags.None
            |> combineFlag !flagFullyCanonicalSig PaymentFlags.FullyCanonicalSig

        let amount =
            !amountIsIssued
            |> toAmount !amountValue !amountCurrency !amountIssuer

        let transaction =
            { Account = !account
              Fee = fee
              Sequence = UInt32.Parse !sequence
              Flags = uint32 flags
              Destination = !destination
              Amount = amount }

        executeSubmitTransaction (transaction |> Payment)

//-------------------------------------------------------------------------------------------------

type SubmitTrustSetModel() =

    inherit Model()

    let account = ref ""
    let fee = ref ""
    let sequence = ref ""
    let flagFullyCanonicalSig = ref true
    let flagSetNoRipple = ref false
    let flagClearNoRipple = ref false
    let limitAmountValue = ref ""
    let limitAmountCurrency = ref ""
    let limitAmountIssuer = ref ""

    member this.Account
        with get () = !account
        and set value = set this value account <@ this.Account @>

    member this.Fee
        with get () = !fee
        and set value = set this value fee <@ this.Fee @>

    member this.Sequence
        with get () = !sequence
        and set value = set this value sequence <@ this.Sequence @>

    member this.FlagFullyCanonicalSig
        with get () = !flagFullyCanonicalSig
        and set value = set this value flagFullyCanonicalSig <@ this.FlagFullyCanonicalSig @>

    member this.FlagSetNoRipple
        with get () = !flagSetNoRipple
        and set value = set this value flagSetNoRipple <@ this.FlagSetNoRipple @>

    member this.FlagClearNoRipple
        with get () = !flagClearNoRipple
        and set value = set this value flagClearNoRipple <@ this.FlagClearNoRipple @>

    member this.LimitAmountValue
        with get () = !limitAmountValue
        and set value = set this value limitAmountValue <@ this.LimitAmountValue @>

    member this.LimitAmountCurrency
        with get () = !limitAmountCurrency
        and set value = set this value limitAmountCurrency <@ this.LimitAmountCurrency @>

    member this.LimitAmountIssuer
        with get () = !limitAmountIssuer
        and set value = set this value limitAmountIssuer <@ this.LimitAmountIssuer @>

    member this.Submit() =

        let fee = toNativeAmount !fee

        let flags =
            TrustSetFlags.None
            |> combineFlag !flagFullyCanonicalSig TrustSetFlags.FullyCanonicalSig
            |> combineFlag !flagSetNoRipple       TrustSetFlags.SetNoRipple
            |> combineFlag !flagClearNoRipple     TrustSetFlags.ClearNoRipple

        let limitAmount =
            toIssuedAmount !limitAmountValue !limitAmountCurrency !limitAmountIssuer

        let transaction =
            { Account = !account
              Fee = fee
              Sequence = UInt32.Parse !sequence
              Flags = uint32 flags
              LimitAmount = limitAmount }

        executeSubmitTransaction (transaction |> TrustSet)

//-------------------------------------------------------------------------------------------------

type TxModel() =

    inherit Model()

    let transaction = ref ""

    member this.Transaction
        with get () = !transaction
        and set value = set this value transaction <@ this.Transaction @>

    member this.Submit() =

        let command = { Transaction = !transaction }

        executeCommand (command |> Tx)
