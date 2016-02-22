module RippleTool.Commands

open Chiron
open WebSocket4Net
open RippleTool.CommandTypes

//-------------------------------------------------------------------------------------------------

module private String =

    let ofLedger = function
        | Validated -> "validated"
        | Closed    -> "closed"
        | Current   -> "current"

    let ofRole = function
        | User    -> "user"
        | Gateway -> "gateway"

//-------------------------------------------------------------------------------------------------

module private Json =

    let private Object = Map >> Object

    let private ofPing (command : Ping) =

        let elements =
            [ "command", String "ping" ]

        Object elements

    let private ofRandom (command : Random) =

        let elements =
            [ "command", String "random" ]

        Object elements

    let private ofAccountCurrencies (command : AccountCurrencies) =

        let ledger = String.ofLedger command.Ledger

        let elements =
            [ "command", String "account_currencies"
              "account", String command.Account
              "ledger_index", String ledger ]

        Object elements

    let private ofAccountInfo (command : AccountInfo) =

        let ledger = String.ofLedger command.Ledger

        let elements =
            [ "command", String "account_info"
              "account", String command.Account
              "ledger_index", String ledger ]

        Object elements

    let private ofAccountLines (command : AccountLines) =

        let ledger = String.ofLedger command.Ledger

        let elements =
            [ "command", String "account_lines"
              "account", String command.Account
              "ledger_index", String ledger ]

        Object elements

    let private ofAccountObjects (command : AccountObjects) =

        let ledger = String.ofLedger command.Ledger

        let elements =
            [ "command", String "account_objects"
              "account", String command.Account
              "ledger_index", String ledger ]

        Object elements

    let private ofAccountOffers (command : AccountOffers) =

        let ledger = String.ofLedger command.Ledger

        let elements =
            [ "command", String "account_objects"
              "account", String command.Account
              "ledger_index", String ledger ]

        Object elements

    let private ofAccountTx (command : AccountTx) =

        let elements =
            [ "command", String "account_tx"
              "account", String command.Account
              "ledger_index_min", Number -1m
              "ledger_index_max", Number -1m ]

        Object elements

    let private ofGatewayBalances (command : GatewayBalances) =

        let ledger = String.ofLedger command.Ledger

        let elements =
            [ "command", String "gateway_balances"
              "account", String command.Account
              "ledger_index", String ledger ]

        Object elements

    let private ofNoRippleCheck (command : NoRippleCheck) =

        let ledger = String.ofLedger command.Ledger
        let role = String.ofRole command.Role

        let elements =
            [ "command", String "noripple_check"
              "account", String command.Account
              "ledger_index", String ledger
              "role", String role ]

        Object elements

    let private ofBookOffers (command : BookOffers) =

        let elementsTakerGets =
            [ "currency", String command.TakerGetsCurrency
              "issuer", String command.TakerGetsIssuer ]

        let elementsTakerPays =
            [ "currency", String command.TakerPaysCurrency
              "issuer", String command.TakerPaysIssuer ]

        let elements =
            [ "command", String "book_offers"
              "taker_gets", Object elementsTakerGets
              "taker_pays", Object elementsTakerPays ]

        Object elements

    let private ofRipplePathFind (command : RipplePathFind) =

        let elementsDestimationAmount =
            [ "value", Number command.DestinationAmount
              "currency", String command.DestinationCurrency
              "issuer", String command.DestinationIssuer ]

        let elements =
            [ "command", String "ripple_path_find"
              "source_account", String command.SourceAccount
              "destination_account", String command.DestinationAccount
              "destination_amount", Object elementsDestimationAmount ]

        Object elements

    let private ofSubmit (command : Submit) =

        let elements =
            [ "command", String "submit"
              "tx_blob", String command.TxBlob ]

        Object elements

    let private ofTx (command : Tx) =

        let elements =
            [ "command", String "tx"
              "transaction", String command.Transaction ]

        Object elements

    let ofCommand = function
        | Ping              command -> command |> ofPing
        | Random            command -> command |> ofRandom
        | AccountCurrencies command -> command |> ofAccountCurrencies
        | AccountInfo       command -> command |> ofAccountInfo
        | AccountLines      command -> command |> ofAccountLines
        | AccountObjects    command -> command |> ofAccountObjects
        | AccountOffers     command -> command |> ofAccountOffers
        | AccountTx         command -> command |> ofAccountTx
        | GatewayBalances   command -> command |> ofGatewayBalances
        | NoRippleCheck     command -> command |> ofNoRippleCheck
        | BookOffers        command -> command |> ofBookOffers
        | RipplePathFind    command -> command |> ofRipplePathFind
        | Submit            command -> command |> ofSubmit
        | Tx                command -> command |> ofTx

//-------------------------------------------------------------------------------------------------

let serialize = Json.ofCommand >> Json.format

let execute serverUri command =

    use ws = new WebSocket(serverUri)

    let computation = async {

        ws.Open()
        let! ea = Async.AwaitEvent(ws.Opened)

        ws.Send(command : string)
        let! ea = Async.AwaitEvent(ws.MessageReceived)
        let message = ea.Message

        ws.Close()
        let! ea = Async.AwaitEvent(ws.Closed)

        return message
    }

    ws.Error |> Event.add (fun ea -> raise ea.Exception)

    Async.RunSynchronously(computation, timeout = 5000)
