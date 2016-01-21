module Program

open RippleTool
open RippleTool.CommandTypes

//-------------------------------------------------------------------------------------------------

Integration.eventCommandExecutionResponse|> Event.add (printfn "%s")
Integration.agentCommandExecution.Post <| Ping()

System.Console.ReadKey() |> ignore
