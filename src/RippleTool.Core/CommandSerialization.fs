module RippleTool.CommandSerialization

open Chiron
open RippleTool.CommandTypes

//-------------------------------------------------------------------------------------------------

let private Object = Map >> Object

let private commandToJsonPing (command : Ping) =
    Object [ "command", String "ping" ]

let private commandToJsonRandom (command : Random) =
    Object [ "command", String "random" ]

let private commandToJsonAccountCurrencies (command : AccountCurrencies) =

    let elements =
        [ "command", String "account_currencies"
          "account", String command.Account
          "ledger_index", String "validated" ]

    Object elements

let private commandToJsonAccountInfo (command : AccountInfo) =

    let elements =
        [ "command", String "account_info"
          "account", String command.Account
          "ledger_index", String "validated" ]

    Object elements

let private commandToJsonAccountLines (command : AccountLines) =

    let elements =
        [ "command", String "account_lines"
          "account", String command.Account
          "ledger_index", String "validated" ]

    Object elements

let private commandToJsonAccountObjects (command : AccountObjects) =

    let elements =
        [ "command", String "account_objects"
          "account", String command.Account
          "ledger_index", String "validated" ]

    Object elements

let private commandToJsonAccountOffers (command : AccountOffers) =

    let elements =
        [ "command", String "account_objects"
          "account", String command.Account
          "ledger_index", String "validated" ]

    Object elements

let private commandToJsonAccountTx (command : AccountTx) =

    let elements =
        [ "command", String "account_tx"
          "account", String command.Account
          "ledger_index_min", Number -1m
          "ledger_index_max", Number -1m ]

    Object elements

let private commandToJsonGatewayBalances (command : GatewayBalances) =

    let elements =
        [ "command", String "gateway_balances"
          "account", String command.Account
          "ledger_index", String "validated" ]

    Object elements

let private commandToJsonNoRippleCheck (command : NoRippleCheck) =

    let role =
        match command.Role with
        | User    -> "user"
        | Gateway -> "gateway"

    let elements =
        [ "command", String "noripple_check"
          "account", String command.Account
          "ledger_index", String "validated"
          "role", String role ]

    Object elements

let private commandToJsonBookOffers (command : BookOffers) =

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

let private commandToJsonRipplePathFind (command : RipplePathFind) =

    let elementsDestimationAmount =
        [ "value", Number command.DestinationAmount
          "currency", String command.DestinationCurrency
          "issuer", String command.DestinationIssuer ]

    let elements =
        [ "command", String "ripple_path_find"
          "source_account", String command.SourceAccount
          "destination_account", String command.DestinationAccount
          "destination_amount", Object elementsDestimationAmount  ]

    Object elements

let private commandToJsonSubmit (command : Submit) =

    let elements =
        [ "command", String "submit"
          "tx_blob", String command.TxBlob ]

    Object elements

let private commandToJsonTx (command : Tx) =

    let elements =
        [ "command", String "tx"
          "transaction", String command.Transaction ]

    Object elements

//-------------------------------------------------------------------------------------------------

let private commandToJson = function
    | Ping              command -> command |> commandToJsonPing
    | Random            command -> command |> commandToJsonRandom
    | AccountCurrencies command -> command |> commandToJsonAccountCurrencies
    | AccountInfo       command -> command |> commandToJsonAccountInfo
    | AccountLines      command -> command |> commandToJsonAccountLines
    | AccountObjects    command -> command |> commandToJsonAccountObjects
    | AccountOffers     command -> command |> commandToJsonAccountOffers
    | AccountTx         command -> command |> commandToJsonAccountTx
    | GatewayBalances   command -> command |> commandToJsonGatewayBalances
    | NoRippleCheck     command -> command |> commandToJsonNoRippleCheck
    | BookOffers        command -> command |> commandToJsonBookOffers
    | RipplePathFind    command -> command |> commandToJsonRipplePathFind
    | Submit            command -> command |> commandToJsonSubmit
    | Tx                command -> command |> commandToJsonTx

let serialize = commandToJson >> Json.format
