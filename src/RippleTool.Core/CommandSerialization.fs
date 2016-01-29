module RippleTool.CommandSerialization

open RippleTool.CommandTypes

//-------------------------------------------------------------------------------------------------

let serializePing (command : Ping) =
    """{ "command": "ping" }"""

let serializeRandom (command : Random) =
    """{ "command": "random" }"""

let serializeAccountCurrencies (command : AccountCurrencies) =
    sprintf
        """
        {
            "command": "account_currencies",
            "account": "%s",
            "ledger_index": "validated"
        }
        """
        command.Account

let serializeAccountInfo (command : AccountInfo) =
    sprintf
        """
        {
            "command": "account_info",
            "account": "%s",
            "ledger_index": "validated"
        }
        """
        command.Account

let serializeAccountLines (command : AccountLines) =
    sprintf
        """
        {
            "command": "account_lines",
            "account": "%s",
            "ledger_index": "validated"
        }
        """
        command.Account

let serializeAccountObjects (command : AccountObjects) =
    sprintf
        """
        {
            "command": "account_objects",
            "account": "%s",
            "ledger_index": "validated"
        }
        """
        command.Account

let serializeAccountOffers (command : AccountOffers) =
    sprintf
        """
        {
            "command": "account_offers",
            "account": "%s",
            "ledger_index": "validated"
        }
        """
        command.Account

let serializeAccountTx (command : AccountTx) =
    sprintf
        """
        {
            "command": "account_tx",
            "account": "%s",
            "ledger_index_min": -1,
            "ledger_index_max": -1
        }
        """
        command.Account

let serializeGatewayBalances (command : GatewayBalances) =
    sprintf
        """
        {
            "command": "gateway_balances",
            "account": "%s",
            "ledger_index": "validated"
        }
        """
        command.Account

let serializeNoRippleCheck (command : NoRippleCheck) =
    sprintf
        """
        {
            "command": "noripple_check",
            "account": "%s",
            "ledger_index": "validated",
            "role": "user"
        }
        """
        command.Account

let serializeBookOffers (command : BookOffers) =
    sprintf
        """
        {
            "command": "book_offers",
            "taker_gets": { "currency": "%s", "issuer": "%s" },
            "taker_pays": { "currency": "%s", "issuer": "%s" }
        }
        """
        command.TakerGetsCurrency
        command.TakerGetsIssuer
        command.TakerPaysCurrency
        command.TakerPaysIssuer

let serializeRipplePathFind (command : RipplePathFind) =
    sprintf
        """
        {
            "command": "ripple_path_find",
            "source_account": "%s",
            "destination_account": "%s",
            "destination_amount": {
                "value": "%f",
                "currency": "%s",
                "issuer": "%s"
            }
        }
        """
        command.SourceAccount
        command.DestinationAccount
        command.DestinationAmount
        command.DestinationCurrency
        command.DestinationIssuer

let serializeTx (command : Tx) =
    sprintf
        """
        {
            "command": "tx",
            "transaction": "%s"
        }
        """
        command.Transaction

let serializeSubmit (command : Submit) =
    sprintf
        """
        {
            "command": "submit",
            "tx_blob": "%s"
        }
        """
        command.TxBlob

//-------------------------------------------------------------------------------------------------

let serialize = function
    | Ping              command -> command |> serializePing
    | Random            command -> command |> serializeRandom
    | AccountCurrencies command -> command |> serializeAccountCurrencies
    | AccountInfo       command -> command |> serializeAccountInfo
    | AccountLines      command -> command |> serializeAccountLines
    | AccountObjects    command -> command |> serializeAccountObjects
    | AccountOffers     command -> command |> serializeAccountOffers
    | AccountTx         command -> command |> serializeAccountTx
    | GatewayBalances   command -> command |> serializeGatewayBalances
    | NoRippleCheck     command -> command |> serializeNoRippleCheck
    | BookOffers        command -> command |> serializeBookOffers
    | RipplePathFind    command -> command |> serializeRipplePathFind
    | Tx                command -> command |> serializeTx
    | Submit            command -> command |> serializeSubmit
