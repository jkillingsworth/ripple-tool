module RippleTool.CommandTypes

//-------------------------------------------------------------------------------------------------

type Role = User | Gateway

type Ping = unit

type Random = unit

type AccountCurrencies =
    { Account : string }

type AccountInfo =
    { Account : string }

type AccountLines =
    { Account : string }

type AccountObjects =
    { Account : string }

type AccountOffers =
    { Account : string }

type AccountTx =
    { Account : string }

type GatewayBalances =
    { Account : string }

type NoRippleCheck =
    { Account : string
      Role : Role }

type BookOffers =
    { TakerGetsCurrency : string
      TakerGetsIssuer : string
      TakerPaysCurrency : string
      TakerPaysIssuer : string }

type RipplePathFind =
    { SourceAccount : string
      DestinationAccount : string
      DestinationAmount : decimal
      DestinationCurrency : string
      DestinationIssuer : string }

type Submit =
    { TxBlob : string }

type Tx =
    { Transaction : string }

//-------------------------------------------------------------------------------------------------

type Command =
    | Ping of Ping
    | Random of Random
    | AccountCurrencies of AccountCurrencies
    | AccountInfo of AccountInfo
    | AccountLines of AccountLines
    | AccountObjects of AccountObjects
    | AccountOffers of AccountOffers
    | AccountTx of AccountTx
    | GatewayBalances of GatewayBalances
    | NoRippleCheck of NoRippleCheck
    | BookOffers of BookOffers
    | RipplePathFind of RipplePathFind
    | Submit of Submit
    | Tx of Tx
