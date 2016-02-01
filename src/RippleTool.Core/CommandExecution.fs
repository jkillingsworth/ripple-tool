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

type private Agent<'T> = MailboxProcessor<'T>

type State<'T> =
    | Get of AsyncReplyChannel<'T>
    | Set of 'T

let private agentTrackStateWithEvent (event : Event<'T>) state = Agent.Start(fun inbox ->
    let rec loop state =
        async {
            let! message = inbox.Receive()
            match message with
            | Get channel
                ->
                state |> channel.Reply
                return! loop state
            | Set state
                ->
                state |> event.Trigger
                return! loop state
    }

    loop state)

let eventExecuteCommandReq = new Event<string>()
let eventExecuteCommandRes = new Event<string>()
let agentExecuteCommandReq = agentTrackStateWithEvent eventExecuteCommandReq null
let agentExecuteCommandRes = agentTrackStateWithEvent eventExecuteCommandRes null
let agentExecuteCommand serverUri = Agent.Start(fun inbox ->
    async {
        while true do
            let! command = inbox.Receive()
            let req = serialize command
            agentExecuteCommandReq.Post (Set req)
            let res = execute serverUri req
            agentExecuteCommandRes.Post (Set res)
    })
