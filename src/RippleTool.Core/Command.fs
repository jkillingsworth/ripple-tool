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
    let private ofBool   = Bool

    let private ofIssuedCurrency currency =
        []
        |> required "currency" ofString currency.Code
        |> required "issuer" ofString currency.Issuer
        |> toObject

    let private ofNativeCurrency currency =
        []
        |> required "currency" ofString "XRP"
        |> toObject

    let private ofCurrency = function
        | IssuedCurrency currency -> ofIssuedCurrency currency
        | NativeCurrency currency -> ofNativeCurrency currency

    let private ofIssuedAmount value currency =
        []
        |> required "value" ofNumber value
        |> required "currency" ofString currency.Code
        |> required "issuer" ofString currency.Issuer
        |> toObject

    let private ofNativeAmount value currency =

        ofNumber value

    let private ofAmount = function
        | { Value = value; Currency = IssuedCurrency currency } -> ofIssuedAmount value currency
        | { Value = value; Currency = NativeCurrency currency } -> ofNativeAmount value currency

    let private ofLedger = function
        | Validated -> ofString "validated"
        | Closed    -> ofString "closed"
        | Current   -> ofString "current"

    let private ofRole = function
        | User    -> ofString "user"
        | Gateway -> ofString "gateway"

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

    let private ofFee (command : Fee) =
        []
        |> optional "id" ofString command.Id
        |> required "command" ofString "fee"
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
        |> optional "ledger_index" ofLedger command.Ledger
        |> toObject

    let private ofAccountInfo (command : AccountInfo) =
        []
        |> optional "id" ofString command.Id
        |> required "command" ofString "account_info"
        |> required "account" ofString command.Account
        |> optional "ledger_index" ofLedger command.Ledger
        |> toObject

    let private ofAccountLines (command : AccountLines) =
        []
        |> optional "id" ofString command.Id
        |> required "command" ofString "account_lines"
        |> required "account" ofString command.Account
        |> optional "ledger_index" ofLedger command.Ledger
        |> toObject

    let private ofAccountObjects (command : AccountObjects) =
        []
        |> optional "id" ofString command.Id
        |> required "command" ofString "account_objects"
        |> required "account" ofString command.Account
        |> optional "ledger_index" ofLedger command.Ledger
        |> toObject

    let private ofAccountOffers (command : AccountOffers) =
        []
        |> optional "id" ofString command.Id
        |> required "command" ofString "account_offers"
        |> required "account" ofString command.Account
        |> optional "ledger_index" ofLedger command.Ledger
        |> toObject

    let private ofAccountTransactions (command : AccountTransactions) =
        []
        |> optional "id" ofString command.Id
        |> required "command" ofString "account_tx"
        |> required "account" ofString command.Account
        |> optional "ledger_index" ofLedger command.Ledger
        |> required "ledger_index_min" ofNumber -1m
        |> required "ledger_index_max" ofNumber -1m
        |> optional "binary" ofBool command.Binary
        |> toObject

    let private ofGatewayBalances (command : GatewayBalances) =
        []
        |> optional "id" ofString command.Id
        |> required "command" ofString "gateway_balances"
        |> required "account" ofString command.Account
        |> optional "ledger_index" ofLedger command.Ledger
        |> toObject

    let private ofNoRippleCheck (command : NoRippleCheck) =
        []
        |> optional "id" ofString command.Id
        |> required "command" ofString "noripple_check"
        |> required "account" ofString command.Account
        |> optional "ledger_index" ofLedger command.Ledger
        |> required "role" ofRole command.Role
        |> toObject

    let private ofBookOffers (command : BookOffers) =
        []
        |> optional "id" ofString command.Id
        |> required "command" ofString "book_offers"
        |> optional "ledger_index" ofLedger command.Ledger
        |> optional "taker" ofString command.Taker
        |> optional "limit" ofUInt32 command.Limit
        |> required "taker_gets" ofCurrency command.TakerGets
        |> required "taker_pays" ofCurrency command.TakerPays
        |> toObject

    let private ofRipplePathFind (command : RipplePathFind) =
        []
        |> optional "id" ofString command.Id
        |> required "command" ofString "ripple_path_find"
        |> optional "ledger_index" ofLedger command.Ledger
        |> required "source_account" ofString command.SourceAccount
        |> required "destination_account" ofString command.DestinationAccount
        |> required "destination_amount" ofAmount command.DestinationAmount
        |> toObject

    let private ofSubmit (command : Submit) =
        []
        |> optional "id" ofString command.Id
        |> required "command" ofString "submit"
        |> required "tx_blob" ofString command.TransactionBlob
        |> toObject

    let private ofTransactionInfo (command : TransactionInfo) =
        []
        |> optional "id" ofString command.Id
        |> required "command" ofString "tx"
        |> required "transaction" ofString command.TransactionHash
        |> optional "binary" ofBool command.Binary
        |> toObject

    let ofCommand = function
        | Ping                command -> command |> ofPing
        | Random              command -> command |> ofRandom
        | Fee                 command -> command |> ofFee
        | ServerInfo          command -> command |> ofServerInfo
        | ServerState         command -> command |> ofServerState
        | AccountCurrencies   command -> command |> ofAccountCurrencies
        | AccountInfo         command -> command |> ofAccountInfo
        | AccountLines        command -> command |> ofAccountLines
        | AccountObjects      command -> command |> ofAccountObjects
        | AccountOffers       command -> command |> ofAccountOffers
        | AccountTransactions command -> command |> ofAccountTransactions
        | GatewayBalances     command -> command |> ofGatewayBalances
        | NoRippleCheck       command -> command |> ofNoRippleCheck
        | BookOffers          command -> command |> ofBookOffers
        | RipplePathFind      command -> command |> ofRipplePathFind
        | Submit              command -> command |> ofSubmit
        | TransactionInfo     command -> command |> ofTransactionInfo

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
