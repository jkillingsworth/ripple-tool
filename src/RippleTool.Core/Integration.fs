﻿module RippleTool.Integration

open System.Configuration
open Chiron
open RippleTool.Encoding
open RippleTool.Commands

//-------------------------------------------------------------------------------------------------

module Config =

    let private reader = AppSettingsReader()

    let serverUri = reader.GetValue("serverUri", typeof<string>) :?> string
    let secretKey = reader.GetValue("secretKey", typeof<string>) :?> string
    let accountId = reader.GetValue("accountId", typeof<string>) :?> string

//-------------------------------------------------------------------------------------------------

type private Agent<'T> = MailboxProcessor<'T>

type private State<'T> =
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

let private hookup (event : Event<'T>) = event.Publish.AddHandler
let private unhook (event : Event<'T>) = event.Publish.RemoveHandler

let private eventExecuteCommandReq = new Event<string>()
let private eventExecuteCommandRes = new Event<string>()
let private agentExecuteCommandReq = agentTrackStateWithEvent eventExecuteCommandReq null
let private agentExecuteCommandRes = agentTrackStateWithEvent eventExecuteCommandRes null

let private agentExecuteCommand = Agent.Start(fun inbox ->
    async {
        while true do
            let! req = inbox.Receive()
            agentExecuteCommandReq.Post (Set req)
            let! res = execute Config.serverUri req
            agentExecuteCommandRes.Post (Set res)
    })

Event.add raise agentExecuteCommand.Error

//-------------------------------------------------------------------------------------------------

let hookupEventExecuteCommandReq handler = handler |> hookup eventExecuteCommandReq
let unhookEventExecuteCommandReq handler = handler |> unhook eventExecuteCommandReq
let hookupEventExecuteCommandRes handler = handler |> hookup eventExecuteCommandRes
let unhookEventExecuteCommandRes handler = handler |> unhook eventExecuteCommandRes

let executeRawJson command =
    command
    |> agentExecuteCommand.Post

let executeCommand command =
    command
    |> serialize
    |> agentExecuteCommand.Post

let executeSubmitTransaction transaction =
    let blob = Transactions.sign transaction Config.secretKey
    let command = CommandTypes.Submit { TxBlob = Binary.toHex blob }
    executeCommand command

let getJsonReq () =
    agentExecuteCommandReq.PostAndReply (fun channel -> Get channel)

let getJsonRes () =
    agentExecuteCommandRes.PostAndReply (fun channel -> Get channel)

let setJsonReq json =
    agentExecuteCommandReq.Post (Set json)

let setJsonRes json =
    agentExecuteCommandRes.Post (Set json)

let formatJson =
    Json.parse >> Json.formatWith JsonFormattingOptions.Pretty
