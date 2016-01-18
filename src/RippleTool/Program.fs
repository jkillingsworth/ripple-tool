module Program

open RippleTool
open RippleTool.CommandTypes

//-------------------------------------------------------------------------------------------------

let executionAgent = CommandExecution.agentExecuteCommand Config.serverUri
let executionEvent = CommandExecution.eventExecuteCommand.Publish

executionEvent|> Event.add (printfn "%s")
executionAgent.Post <| Ping()

System.Console.ReadKey() |> ignore
