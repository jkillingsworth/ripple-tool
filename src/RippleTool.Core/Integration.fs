module RippleTool.Integration

open System.Configuration
open Chiron
open RippleTool.Commands

//-------------------------------------------------------------------------------------------------

let private reader = AppSettingsReader()

let configServerUri = reader.GetValue("serverUri", typeof<string>) :?> string
let configSecretKey = reader.GetValue("secretKey", typeof<string>) :?> string
let configAccountId = reader.GetValue("accountId", typeof<string>) :?> string

//-------------------------------------------------------------------------------------------------

let private agentExecuteCommand = agentExecuteCommand configServerUri

let eventExecuteCommandReq = eventExecuteCommandReq.Publish
let eventExecuteCommandRes = eventExecuteCommandRes.Publish

let executeCommand command =
    agentExecuteCommand.Post command

let executeSubmitTransaction transaction =
    let hex = Transactions.sign transaction configSecretKey
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
