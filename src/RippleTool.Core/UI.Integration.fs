module RippleTool.UI.Integration

open System
open System.Configuration
open System.Threading
open Chiron
open RippleTool
open RippleTool.Encoding
open RippleTool.CommandTypes
open RippleTool.Commands

//-------------------------------------------------------------------------------------------------

module Config =

    let private reader = AppSettingsReader()

    let serverUri = reader.GetValue("serverUri", typeof<string>) :?> string
    let accountId = reader.GetValue("accountId", typeof<string>) :?> string
    let secretKey = reader.GetValue("secretKey", typeof<string>) :?> string

//-------------------------------------------------------------------------------------------------

type private Agent<'T> = MailboxProcessor<'T>

type private State<'T> =
    | Get of AsyncReplyChannel<'T>
    | Set of 'T

let private handleTrackState (event : Event<'T>) state = function
    | Get channel
        ->
        state |> channel.Reply
        state
    | Set state
        ->
        state |> event.Trigger
        state

let private agentTrackState event state = Agent.Start(fun inbox ->
    let rec loop state =
        async {
            let! message = inbox.Receive()
            return! message |> handleTrackState event state |> loop
    }
    loop state)

let private hookup (event : Event<'T>) (handler : Action<'T>) =

    let context = SynchronizationContext.Current

    let handler value =
        let callback obj = handler.Invoke(value)
        let callback = SendOrPostCallback(callback)
        context.Post(callback, value)

    Observable.subscribe handler event.Publish

//-------------------------------------------------------------------------------------------------

let private eventExecuteCommandErr = new Event<Exception>()
let private eventExecuteCommandReq = new Event<string>()
let private eventExecuteCommandRes = new Event<string>()
let private agentExecuteCommandReq = agentTrackState eventExecuteCommandReq null
let private agentExecuteCommandRes = agentTrackState eventExecuteCommandRes null

let private agentExecuteCommand = Agent.Start(fun inbox ->
    async {
        while true do
            let! req = inbox.Receive()
            agentExecuteCommandReq.Post(Set req)
            let! res = execute Config.serverUri req
            agentExecuteCommandRes.Post(Set res)
    })

agentExecuteCommand.Error |> Event.add eventExecuteCommandErr.Trigger

//-------------------------------------------------------------------------------------------------

let hookupEventExecuteCommandErr handler = handler |> hookup eventExecuteCommandErr
let hookupEventExecuteCommandReq handler = handler |> hookup eventExecuteCommandReq
let hookupEventExecuteCommandRes handler = handler |> hookup eventExecuteCommandRes

let executeRawJson =
    agentExecuteCommand.Post

let executeCommand =
    agentExecuteCommand.Post << serialize

let executeSubmitTransaction =
    let toSubmit blob = Submit { TxBlob = Binary.toHex blob }
    executeCommand << toSubmit << Transactions.sign Config.secretKey

let getJsonReq () =
    agentExecuteCommandReq.PostAndReply(Get)

let getJsonRes () =
    agentExecuteCommandRes.PostAndReply(Get)

let setJsonReq json =
    agentExecuteCommandReq.Post(Set json)

let setJsonRes json =
    agentExecuteCommandRes.Post(Set json)

let formatJson =
    Json.parse >> Json.formatWith JsonFormattingOptions.Pretty
