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

type TxModel() =

    inherit Model()

    let transaction = ref ""

    member this.Transaction
        with get () = !transaction
        and set value = set this value transaction <@ this.Transaction @>

    member this.Submit() =

        let command = { Transaction = !transaction }

        executeCommand (command |> Tx)
