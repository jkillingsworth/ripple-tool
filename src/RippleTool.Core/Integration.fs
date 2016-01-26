module RippleTool.Integration

open System.Configuration
open Chiron

//-------------------------------------------------------------------------------------------------

let private reader = AppSettingsReader()

let configServerUri = reader.GetValue("serverUri", typeof<string>) :?> string
let configSecretKey = reader.GetValue("secretKey", typeof<string>) :?> string
let configAccountId = reader.GetValue("accountId", typeof<string>) :?> string

//-------------------------------------------------------------------------------------------------

let agentCommandExecution = CommandExecution.agentExecuteCommand configServerUri
let eventCommandExecutionRequest = CommandExecution.eventExecuteCommandRequest.Publish
let eventCommandExecutionResponse = CommandExecution.eventExecuteCommandResponse.Publish

//-------------------------------------------------------------------------------------------------

let formatJson = Json.parse >> Json.formatWith JsonFormattingOptions.Pretty
