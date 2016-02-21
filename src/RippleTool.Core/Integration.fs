module RippleTool.Integration

open System.Configuration
open Chiron
open RippleTool.Commands

//-------------------------------------------------------------------------------------------------

module Config =

    let private reader = AppSettingsReader()

    let serverUri = reader.GetValue("serverUri", typeof<string>) :?> string
    let secretKey = reader.GetValue("secretKey", typeof<string>) :?> string
    let accountId = reader.GetValue("accountId", typeof<string>) :?> string

//-------------------------------------------------------------------------------------------------

let private agentExecuteCommand = agentExecuteCommand Config.serverUri

let eventExecuteCommandReq = eventExecuteCommandReq.Publish
let eventExecuteCommandRes = eventExecuteCommandRes.Publish

let executeCommand command =
    agentExecuteCommand.Post command

let executeSubmitTransaction transaction =
    let hex = Transactions.sign transaction Config.secretKey
    let command = CommandTypes.Submit { TxBlob = hex }
    executeCommand command

let getJsonReq () =
    agentExecuteCommandReq.PostAndReply (fun channel -> Get channel)

let getJsonRes () =
    agentExecuteCommandRes.PostAndReply (fun channel -> Get channel)

let setJsonReq json =
    agentExecuteCommandReq.Post (Set json)

let setJsonRes json =
    agentExecuteCommandRes.Post (Set json)

//-------------------------------------------------------------------------------------------------

let formatJson = Json.parse >> Json.formatWith JsonFormattingOptions.Pretty
