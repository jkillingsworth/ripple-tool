module Program

open WebSocket4Net
open Config

//-------------------------------------------------------------------------------------------------

let ping =
    """{ "command": "ping" }"""

let random =
    """{ "command": "random" }"""

let accountCurrencies account =
    sprintf
        """
        {
            "command": "account_currencies",
            "account": "%s",
            "ledger_index": "validated"
        }
        """
        account

let accountInfo account =
    sprintf
        """
        {
            "command": "account_info",
            "account": "%s",
            "ledger_index": "validated"
        }
        """
        account

let accountLines account =
    sprintf
        """
        {
            "command": "account_lines",
            "account": "%s",
            "ledger_index": "validated"
        }
        """
        account

let accountOffers account =
    sprintf
        """
        {
            "command": "account_offers",
            "account": "%s",
            "ledger_index": "validated"
        }
        """
        account

let accountObjects account =
    sprintf
        """
        {
            "command": "account_objects",
            "account": "%s",
            "ledger_index": "validated"
        }
        """
        account

let accountTx account =
    sprintf
        """
        {
            "command": "account_tx",
            "account": "%s",
            "ledger_index_min": -1,
            "ledger_index_max": -1
        }
        """
        account

let noRippleCheck account =
    sprintf
        """
        {
            "command": "noripple_check",
            "account": "%s",
            "ledger_index": "validated",
            "role": "user"
        }
        """
        account

let gatewayBalances account =
    sprintf
        """
        {
            "command": "gateway_balances",
            "account": "%s",
            "ledger_index": "validated"
        }
        """
        account

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

printfn "%s" <| execute ping
