module RippleTool.CommandTypes

//-------------------------------------------------------------------------------------------------

type Ping = unit

type Random = unit

type AccountCurrencies =
    { Account : string }

type AccountInfo =
    { Account : string }

type AccountLines =
    { Account : string }

type AccountOffers =
    { Account : string }

type AccountObjects =
    { Account : string }

type AccountTx =
    { Account : string }

type NoRippleCheck =
    { Account : string }

type GatewayBalances =
    { Account : string }

type Tx =
    { Transaction : string }

type RipplePathFind =
    { SourceAccount : string
      DestinationAccount : string
      DestinationAmount : float
      DestinationCurrency : string
      DestinationIssuer : string }

type Submit =
    { TxBlob : string }

type BookOffers =
    { TakerGetsCurrency : string
      TakerGetsIssuer : string
      TakerPaysCurrency : string
      TakerPaysIssuer : string }

//-------------------------------------------------------------------------------------------------

type Command =
    | Ping of Ping
    | Random of Random
    | AccountCurrencies of AccountCurrencies
    | AccountInfo of AccountInfo
    | AccountLines of AccountLines
    | AccountOffers of AccountOffers
    | AccountObjects of AccountObjects
    | AccountTx of AccountTx
    | NoRippleCheck of NoRippleCheck
    | GatewayBalances of GatewayBalances
    | Tx of Tx
    | RipplePathFind of RipplePathFind
    | Submit of Submit
    | BookOffers of BookOffers
