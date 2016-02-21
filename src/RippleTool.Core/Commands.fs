module RippleTool.Commands

open Chiron
open WebSocket4Net
open RippleTool.CommandTypes

//-------------------------------------------------------------------------------------------------

let private stringOfLedger = function
    | Validated -> "validated"
    | Closed    -> "closed"
    | Current   -> "current"

let private stringOfRole = function
    | User    -> "user"
    | Gateway -> "gateway"

//-------------------------------------------------------------------------------------------------

let private Object = Map >> Object

let private commandToJsonPing (command : Ping) =
    Object [ "command", String "ping" ]

let private commandToJsonRandom (command : Random) =
    Object [ "command", String "random" ]

let private commandToJsonAccountCurrencies (command : AccountCurrencies) =

    let ledger = stringOfLedger command.Ledger

    let elements =
        [ "command", String "account_currencies"
          "account", String command.Account
          "ledger_index", String ledger ]

    Object elements

let private commandToJsonAccountInfo (command : AccountInfo) =

    let ledger = stringOfLedger command.Ledger

    let elements =
        [ "command", String "account_info"
          "account", String command.Account
          "ledger_index", String ledger ]

    Object elements

let private commandToJsonAccountLines (command : AccountLines) =

    let ledger = stringOfLedger command.Ledger

    let elements =
        [ "command", String "account_lines"
          "account", String command.Account
          "ledger_index", String ledger ]

    Object elements

let private commandToJsonAccountObjects (command : AccountObjects) =

    let ledger = stringOfLedger command.Ledger

    let elements =
        [ "command", String "account_objects"
          "account", String command.Account
          "ledger_index", String ledger ]

    Object elements

let private commandToJsonAccountOffers (command : AccountOffers) =

    let ledger = stringOfLedger command.Ledger

    let elements =
        [ "command", String "account_objects"
          "account", String command.Account
          "ledger_index", String ledger ]

    Object elements

let private commandToJsonAccountTx (command : AccountTx) =

    let elements =
        [ "command", String "account_tx"
          "account", String command.Account
          "ledger_index_min", Number -1m
          "ledger_index_max", Number -1m ]

    Object elements

let private commandToJsonGatewayBalances (command : GatewayBalances) =

    let ledger = stringOfLedger command.Ledger

    let elements =
        [ "command", String "gateway_balances"
          "account", String command.Account
          "ledger_index", String ledger ]

    Object elements

let private commandToJsonNoRippleCheck (command : NoRippleCheck) =

    let ledger = stringOfLedger command.Ledger
    let role = stringOfRole command.Role

    let elements =
        [ "command", String "noripple_check"
          "account", String command.Account
          "ledger_index", String ledger
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

//-------------------------------------------------------------------------------------------------

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

//-------------------------------------------------------------------------------------------------

type private Agent<'T> = MailboxProcessor<'T>

type State<'T> =
    | Get of AsyncReplyChannel<'T>
    | Set of 'T

let private agentTrackStateWithEvent (event : Event<'T>) state = Agent.Start(fun inbox ->
    let rec loop state =
        async {
            let! message = inbox.Receive()
            match message with
            | Get channel
                ->
                state |> channel.Reply
                return! loop state
            | Set state
                ->
                state |> event.Trigger
                return! loop state
    }

    loop state)

let eventExecuteCommandReq = new Event<string>()
let eventExecuteCommandRes = new Event<string>()
let agentExecuteCommandReq = agentTrackStateWithEvent eventExecuteCommandReq null
let agentExecuteCommandRes = agentTrackStateWithEvent eventExecuteCommandRes null
let agentExecuteCommand serverUri = Agent.Start(fun inbox ->
    async {
        while true do
            let! command = inbox.Receive()
            let req = serialize command
            agentExecuteCommandReq.Post (Set req)
            let res = execute serverUri req
            agentExecuteCommandRes.Post (Set res)
    })
