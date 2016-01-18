module RippleTool.CommandExecution

open WebSocket4Net
open RippleTool.CommandTypes
open RippleTool.CommandSerialization

//-------------------------------------------------------------------------------------------------

let private execute serverUri command =

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

let eventExecuteCommand = new Event<string>()

let agentExecuteCommand serverUri = MailboxProcessor.Start(fun inbox ->
    async {
        while true do
            let! command = inbox.Receive()
            command
            |> serialize
            |> execute serverUri
            |> eventExecuteCommand.Trigger
    })
