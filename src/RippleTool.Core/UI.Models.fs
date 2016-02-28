module RippleTool.UI.Models

open System
open System.ComponentModel
open Microsoft.FSharp.Quotations.Patterns
open RippleTool.Types
open RippleTool.CommandTypes
open RippleTool.Integration

//-------------------------------------------------------------------------------------------------

let private propertyName = function
    | PropertyGet (_, info, _) -> info.Name
    | _ -> failwith "Expecting a property expression."

let private optional value map =
    match value with
    | value when value = "" -> None
    | value -> value |> map |> Some

//-------------------------------------------------------------------------------------------------

type Model() =

    let propertyChanged = Event<_, _>()

    interface INotifyPropertyChanged with

        [<CLIEvent>]
        member this.PropertyChanged = propertyChanged.Publish

    member this.OnPropertyChanged(expr) =
        let name = propertyName expr
        let args = PropertyChangedEventArgs(name)
        propertyChanged.Trigger(this, args)

//-------------------------------------------------------------------------------------------------

type BookOffersModel() =

    inherit Model()

    let mutable taker = ""
    let mutable limit = ""
    let mutable takerGetsIssued = true
    let mutable takerGetsNative = false
    let mutable takerGetsCurrency = ""
    let mutable takerGetsIssuer = ""
    let mutable takerPaysIssued = true
    let mutable takerPaysNative = false
    let mutable takerPaysCurrency = ""
    let mutable takerPaysIssuer = ""

    member this.Taker
        with get () = taker
        and set value =
            taker <- value
            this.OnPropertyChanged(<@ this.Taker @>)

    member this.Limit
        with get () = limit
        and set value =
            limit <- value
            this.OnPropertyChanged(<@ this.Limit @>)

    member this.TakerGetsIssued
        with get () = takerGetsIssued
        and set value =
            takerGetsIssued <- value
            takerGetsNative <- not value
            this.OnPropertyChanged(<@ this.TakerGetsIssued @>)
            this.OnPropertyChanged(<@ this.TakerGetsNative @>)

    member this.TakerGetsNative
        with get () = takerGetsNative
        and set value =
            takerGetsIssued <- not value
            takerGetsNative <- value
            this.OnPropertyChanged(<@ this.TakerGetsIssued @>)
            this.OnPropertyChanged(<@ this.TakerGetsNative @>)

    member this.TakerGetsCurrency
        with get () = takerGetsCurrency
        and set value =
            takerGetsCurrency <- value
            this.OnPropertyChanged(<@ this.TakerGetsCurrency @>)

    member this.TakerGetsIssuer
        with get () = takerGetsIssuer
        and set value =
            takerGetsIssuer <- value
            this.OnPropertyChanged(<@ this.TakerGetsIssuer @>)

    member this.TakerPaysIssued
        with get () = takerPaysIssued
        and set value =
            takerPaysIssued <- value
            takerPaysNative <- not value
            this.OnPropertyChanged(<@ this.TakerPaysIssued @>)
            this.OnPropertyChanged(<@ this.TakerPaysNative @>)

    member this.TakerPaysNative
        with get () = takerPaysNative
        and set value =
            takerPaysIssued <- not value
            takerPaysNative <- value
            this.OnPropertyChanged(<@ this.TakerPaysIssued @>)
            this.OnPropertyChanged(<@ this.TakerPaysNative @>)

    member this.TakerPaysCurrency
        with get () = takerPaysCurrency
        and set value =
            takerPaysCurrency <- value
            this.OnPropertyChanged(<@ this.TakerPaysCurrency @>)

    member this.TakerPaysIssuer
        with get () = takerPaysIssuer
        and set value =
            takerPaysIssuer <- value
            this.OnPropertyChanged(<@ this.TakerPaysIssuer @>)

    member this.Submit() =

        let taker = optional taker id
        let limit = optional limit UInt32.Parse

        let takerGets =
            match takerGetsIssued with
            | true  -> IssuedCurrency { Code = takerGetsCurrency; Issuer = takerGetsIssuer }
            | false -> NativeCurrency NativeCurrency.NativeCurrency

        let takerPays =
            match takerPaysIssued with
            | true  -> IssuedCurrency { Code = takerPaysCurrency; Issuer = takerPaysIssuer }
            | false -> NativeCurrency NativeCurrency.NativeCurrency

        let command =
            { Taker = taker
              Limit = limit
              TakerGets = takerGets
              TakerPays = takerPays }

        executeCommand (command |> BookOffers)

//-------------------------------------------------------------------------------------------------

type RipplePathFindModel() =

    inherit Model()

    let mutable sourceAccount = ""
    let mutable destinationAccount = ""
    let mutable destinationAmountIssued = true
    let mutable destinationAmountNative = false
    let mutable destinationAmountValue = ""
    let mutable destinationAmountCurrency = ""
    let mutable destinationAmountIssuer = ""

    member this.SourceAccount
        with get () = sourceAccount
        and set value =
            sourceAccount <- value
            this.OnPropertyChanged(<@ this.SourceAccount @>)

    member this.DestinationAccount
        with get () = destinationAccount
        and set value =
            destinationAccount <- value
            this.OnPropertyChanged(<@ this.DestinationAccount @>)

    member this.DestinationAmountIssued
        with get () = destinationAmountIssued
        and set value =
            destinationAmountIssued <- value
            destinationAmountNative <- not value
            this.OnPropertyChanged(<@ this.DestinationAmountIssued @>)
            this.OnPropertyChanged(<@ this.DestinationAmountNative @>)

    member this.DestinationAmountNative
        with get () = destinationAmountNative
        and set value =
            destinationAmountIssued <- not value
            destinationAmountNative <- value
            this.OnPropertyChanged(<@ this.DestinationAmountIssued @>)
            this.OnPropertyChanged(<@ this.DestinationAmountNative @>)

    member this.DestinationAmountValue
        with get () = destinationAmountValue
        and set value =
            destinationAmountValue <- value
            this.OnPropertyChanged(<@ this.DestinationAmountValue @>)

    member this.DestinationAmountCurrency
        with get () = destinationAmountCurrency
        and set value =
            destinationAmountCurrency <- value
            this.OnPropertyChanged(<@ this.DestinationAmountCurrency @>)

    member this.DestinationAmountIssuer
        with get () = destinationAmountIssuer
        and set value =
            destinationAmountIssuer <- value
            this.OnPropertyChanged(<@ this.DestinationAmountIssuer @>)

    member this.Submit() =

        let destinationAmount =
            match destinationAmountIssued with
            | true  ->
                let amount = { Value = Decimal.Parse destinationAmountValue; Currency = destinationAmountCurrency; Issuer = destinationAmountIssuer }
                IssuedAmount amount
            | false ->
                let amount = Decimal.Parse destinationAmountValue
                NativeAmount amount

        let command =
            { SourceAccount = sourceAccount
              DestinationAccount = destinationAccount
              DestinationAmount = destinationAmount }

        executeCommand (command |> RipplePathFind)

//-------------------------------------------------------------------------------------------------

type TxModel() =

    inherit Model()

    let mutable transaction = ""

    member this.Transaction
        with get () = transaction
        and set value =
            transaction <- value
            this.OnPropertyChanged(<@ this.Transaction @>)

    member this.Submit() =

        let command = { Transaction = transaction }

        executeCommand (command |> Tx)
