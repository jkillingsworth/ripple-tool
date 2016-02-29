module RippleTool.UI.Models

open System
open System.ComponentModel
open Microsoft.FSharp.Quotations.Patterns
open RippleTool.Types
open RippleTool.CommandTypes
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

let private optional value map =
    match value with
    | value when value = "" -> None
    | value -> value |> map |> Some

let private toCurrency code issuer = function
    | true  -> IssuedCurrency <| { Code = code; Issuer = issuer }
    | false -> NativeCurrency <| NativeCurrency.NativeCurrency

let private toAmount value currency issuer = function
    | true  -> IssuedAmount <| { Value = Decimal.Parse value; Currency = currency; Issuer = issuer }
    | false -> NativeAmount <| Decimal.Parse value

let private set (this : Model) value field expr =
    field := value
    this.OnPropertyChanged(expr)

//-------------------------------------------------------------------------------------------------

type BookOffersModel() =

    inherit Model()

    let taker = ref ""
    let limit = ref ""
    let takerGetsIssued = ref true
    let takerGetsNative = ref false
    let takerGetsCurrency = ref ""
    let takerGetsIssuer = ref ""
    let takerPaysIssued = ref true
    let takerPaysNative = ref false
    let takerPaysCurrency = ref ""
    let takerPaysIssuer = ref ""

    member this.Taker
        with get () = !taker
        and set value = set this value taker <@ this.Taker @>

    member this.Limit
        with get () = !limit
        and set value = set this value limit <@ this.Limit @>

    member this.TakerGetsIssued
        with get () = !takerGetsIssued
        and set value =
            let issued, native = (value, not value)
            set this issued takerGetsIssued <@ this.TakerGetsIssued @>
            set this native takerGetsNative <@ this.TakerGetsNative @>

    member this.TakerGetsNative
        with get () = !takerGetsNative
        and set value =
            let issued, native = (not value, value)
            set this issued takerGetsIssued <@ this.TakerGetsIssued @>
            set this native takerGetsNative <@ this.TakerGetsNative @>

    member this.TakerGetsCurrency
        with get () = !takerGetsCurrency
        and set value = set this value takerGetsCurrency <@ this.TakerGetsCurrency @>

    member this.TakerGetsIssuer
        with get () = !takerGetsIssuer
        and set value = set this value takerGetsIssuer <@ this.TakerGetsIssuer @>

    member this.TakerPaysIssued
        with get () = !takerPaysIssued
        and set value =
            let issued, native = (value, not value)
            set this issued takerPaysIssued <@ this.TakerPaysIssued @>
            set this native takerPaysNative <@ this.TakerPaysNative @>

    member this.TakerPaysNative
        with get () = !takerPaysNative
        and set value =
            let issued, native = (not value, value)
            set this issued takerPaysIssued <@ this.TakerPaysIssued @>
            set this native takerPaysNative <@ this.TakerPaysNative @>

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
            !takerGetsIssued
            |> toCurrency !takerGetsCurrency !takerGetsIssuer

        let takerPays =
            !takerPaysIssued
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
    let destinationAmountIssued = ref true
    let destinationAmountNative = ref false
    let destinationAmountValue = ref ""
    let destinationAmountCurrency = ref ""
    let destinationAmountIssuer = ref ""

    member this.SourceAccount
        with get () = !sourceAccount
        and set value = set this value sourceAccount <@ this.SourceAccount @>

    member this.DestinationAccount
        with get () = !destinationAccount
        and set value = set this value destinationAccount <@ this.DestinationAccount @>

    member this.DestinationAmountIssued
        with get () = !destinationAmountIssued
        and set value =
            let issued, native = (value, not value)
            set this issued destinationAmountIssued <@ this.DestinationAmountIssued @>
            set this native destinationAmountNative <@ this.DestinationAmountNative @>

    member this.DestinationAmountNative
        with get () = !destinationAmountNative
        and set value =
            let issued, native = (not value, value)
            set this issued destinationAmountIssued <@ this.DestinationAmountIssued @>
            set this native destinationAmountNative <@ this.DestinationAmountNative @>

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
            !destinationAmountIssued
            |> toAmount !destinationAmountValue !destinationAmountCurrency !destinationAmountIssuer

        let command =
            { SourceAccount = !sourceAccount
              DestinationAccount = !destinationAccount
              DestinationAmount = destinationAmount }

        executeCommand (command |> RipplePathFind)

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
