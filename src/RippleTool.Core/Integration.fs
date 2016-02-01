module RippleTool.Integration

open System.Configuration
open Chiron
open CommandExecution

//-------------------------------------------------------------------------------------------------

let private reader = AppSettingsReader()

let configServerUri = reader.GetValue("serverUri", typeof<string>) :?> string
let configSecretKey = reader.GetValue("secretKey", typeof<string>) :?> string
let configAccountId = reader.GetValue("accountId", typeof<string>) :?> string

//-------------------------------------------------------------------------------------------------

let agentCommandExecution = CommandExecution.agentExecuteCommand configServerUri
let eventCommandExecutionReq = CommandExecution.eventExecuteCommandReq.Publish
let eventCommandExecutionRes = CommandExecution.eventExecuteCommandRes.Publish

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
