module Program

open WebSocket4Net

//-------------------------------------------------------------------------------------------------

let ping =
    """{ "command": "ping" }"""

let random =
    """{ "command": "random" }"""

//-------------------------------------------------------------------------------------------------

let execute command =

    let computation = async {

        let ws = new WebSocket("wss://s1.ripple.com")

        ws.Open()
        let! ea = Async.AwaitEvent(ws.Opened)

        ws.Send(command : string)
        let! ea = Async.AwaitEvent(ws.MessageReceived)
        let message = ea.Message

        ws.Close()
        let! ea = Async.AwaitEvent(ws.Closed)

        return message
    }

    Async.RunSynchronously(computation, timeout = 5000)

//-------------------------------------------------------------------------------------------------

printfn "%s" <| execute ping
