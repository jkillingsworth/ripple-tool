module RippleTool.Command

open Chiron
open WebSocket4Net
open RippleTool.Types

//-------------------------------------------------------------------------------------------------

module private Json =

    let private required name toJson value elements =
        (name, toJson value) :: elements

    let private optional name toJson = function
        | Some value -> value |> required name toJson
        | None -> id

    let private toObject = Object << Map
    let private ofString = String
    let private ofNumber = Number
    let private ofUInt32 = Number << decimal

    let private ofLedger = String << function
        | Validated -> "validated"
        | Closed    -> "closed"
        | Current   -> "current"

    let private ofRole = String << function
        | User    -> "user"
        | Gateway -> "gateway"

    let private ofIssuedCurrency (currency : IssuedCurrency) =
        []
        |> required "currency" ofString currency.Code
        |> required "issuer" ofString currency.Issuer
        |> toObject

    let private ofNativeCurrency (currency : NativeCurrency) =
        []
        |> required "currency" ofString "XRP"
        |> toObject

    let private ofCurrency = function
        | IssuedCurrency currency -> ofIssuedCurrency currency
        | NativeCurrency currency -> ofNativeCurrency currency

    let private ofIssuedAmount (amount : IssuedAmount) =
        []
        |> required "value" ofNumber amount.Value
        |> required "currency" ofString amount.Currency
        |> required "issuer" ofString amount.Issuer
        |> toObject

    let private ofNativeAmount (amount : NativeAmount) =

        ofNumber amount

    let private ofAmount = function
        | IssuedAmount amount -> ofIssuedAmount amount
        | NativeAmount amount -> ofNativeAmount amount

    let private ofPing (command : Ping) =
        []
        |> optional "id" ofString command.Id
        |> required "command" ofString "ping"
        |> toObject

    let private ofRandom (command : Random) =
        []
        |> optional "id" ofString command.Id
        |> required "command" ofString "random"
        |> toObject

    let private ofServerInfo (command : ServerInfo) =
        []
        |> optional "id" ofString command.Id
        |> required "command" ofString "server_info"
        |> toObject

    let private ofServerState (command : ServerState) =
        []
        |> optional "id" ofString command.Id
        |> required "command" ofString "server_state"
        |> toObject

    let private ofAccountCurrencies (command : AccountCurrencies) =
        []
        |> optional "id" ofString command.Id
        |> required "command" ofString "account_currencies"
        |> required "account" ofString command.Account
        |> required "ledger_index" ofLedger command.Ledger
        |> toObject

    let private ofAccountInfo (command : AccountInfo) =
        []
        |> optional "id" ofString command.Id
        |> required "command" ofString "account_info"
        |> required "account" ofString command.Account
        |> required "ledger_index" ofLedger command.Ledger
        |> toObject

    let private ofAccountLines (command : AccountLines) =
        []
        |> optional "id" ofString command.Id
        |> required "command" ofString "account_lines"
        |> required "account" ofString command.Account
        |> required "ledger_index" ofLedger command.Ledger
        |> toObject

    let private ofAccountObjects (command : AccountObjects) =
        []
        |> optional "id" ofString command.Id
        |> required "command" ofString "account_objects"
        |> required "account" ofString command.Account
        |> required "ledger_index" ofLedger command.Ledger
        |> toObject

    let private ofAccountOffers (command : AccountOffers) =
        []
        |> optional "id" ofString command.Id
        |> required "command" ofString "account_offers"
        |> required "account" ofString command.Account
        |> required "ledger_index" ofLedger command.Ledger
        |> toObject

    let private ofAccountTx (command : AccountTx) =
        []
        |> optional "id" ofString command.Id
        |> required "command" ofString "account_tx"
        |> required "account" ofString command.Account
        |> required "ledger_index_min" ofNumber -1m
        |> required "ledger_index_max" ofNumber -1m
        |> toObject

    let private ofGatewayBalances (command : GatewayBalances) =
        []
        |> optional "id" ofString command.Id
        |> required "command" ofString "gateway_balances"
        |> required "account" ofString command.Account
        |> required "ledger_index" ofLedger command.Ledger
        |> toObject

    let private ofNoRippleCheck (command : NoRippleCheck) =
        []
        |> optional "id" ofString command.Id
        |> required "command" ofString "noripple_check"
        |> required "account" ofString command.Account
        |> required "ledger_index" ofLedger command.Ledger
        |> required "role" ofRole command.Role
        |> toObject

    let private ofBookOffers (command : BookOffers) =
        []
        |> optional "id" ofString command.Id
        |> required "command" ofString "book_offers"
        |> required "ledger_index" ofLedger command.Ledger
        |> optional "taker" ofString command.Taker
        |> optional "limit" ofUInt32 command.Limit
        |> required "taker_gets" ofCurrency command.TakerGets
        |> required "taker_pays" ofCurrency command.TakerPays
        |> toObject

    let private ofRipplePathFind (command : RipplePathFind) =
        []
        |> optional "id" ofString command.Id
        |> required "command" ofString "ripple_path_find"
        |> required "source_account" ofString command.SourceAccount
        |> required "destination_account" ofString command.DestinationAccount
        |> required "destination_amount" ofAmount command.DestinationAmount
        |> toObject

    let private ofSubmit (command : Submit) =
        []
        |> optional "id" ofString command.Id
        |> required "command" ofString "submit"
        |> required "tx_blob" ofString command.TxBlob
        |> toObject

    let private ofTx (command : Tx) =
        []
        |> optional "id" ofString command.Id
        |> required "command" ofString "tx"
        |> required "transaction" ofString command.Transaction
        |> toObject

    let ofCommand = function
        | Ping              command -> command |> ofPing
        | Random            command -> command |> ofRandom
        | ServerInfo        command -> command |> ofServerInfo
        | ServerState       command -> command |> ofServerState
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
    async {

        use ws = new WebSocket(serverUri)

        ws.Open()
        let! ea = Async.AwaitEvent(ws.Opened)

        ws.Send(command : string)
        let! ea = Async.AwaitEvent(ws.MessageReceived)
        let message = ea.Message

        ws.Close()
        let! ea = Async.AwaitEvent(ws.Closed)

        return message
    }
