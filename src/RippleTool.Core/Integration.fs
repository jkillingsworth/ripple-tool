module RippleTool.Integration

open System.Configuration

//-------------------------------------------------------------------------------------------------

let private reader = AppSettingsReader()

let configServerUri = reader.GetValue("serverUri", typeof<string>) :?> string
let configSecretKey = reader.GetValue("secretKey", typeof<string>) :?> string
let configAccountId = reader.GetValue("accountId", typeof<string>) :?> string

//-------------------------------------------------------------------------------------------------

let agentCommandExecution = CommandExecution.agentExecuteCommand configServerUri
let eventCommandExecutionResponse = CommandExecution.eventExecuteCommand.Publish
