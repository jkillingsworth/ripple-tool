module Program

open WebSocket4Net
open CommandTypes
open CommandSerialization

//-------------------------------------------------------------------------------------------------

let execute command =

    use ws = new WebSocket(Config.serverUri)

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

let command = Ping()
printfn "%s" <| execute (serialize command)
