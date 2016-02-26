module RippleTool.CommandTypes

//-------------------------------------------------------------------------------------------------

type NativeCurrency = NativeCurrency
type IssuedCurrency = { Code : string; Issuer : string }

type Currency =
    | NativeCurrency of NativeCurrency
    | IssuedCurrency of IssuedCurrency

type NativeAmount = decimal
type IssuedAmount = { Value : decimal; Currency : string; Issuer : string }

type Amount =
    | NativeAmount of NativeAmount
    | IssuedAmount of IssuedAmount

type Ledger =
    | Validated
    | Closed
    | Current

type Role =
    | User
    | Gateway

//-------------------------------------------------------------------------------------------------

type Ping = Ping

type Random = Random

type ServerInfo = ServerInfo

type ServerState = ServerState

type AccountCurrencies =
    { Account : string
      Ledger : Ledger }

type AccountInfo =
    { Account : string
      Ledger : Ledger }

type AccountLines =
    { Account : string
      Ledger : Ledger }

type AccountObjects =
    { Account : string
      Ledger : Ledger }

type AccountOffers =
    { Account : string
      Ledger : Ledger }

type AccountTx =
    { Account : string }

type GatewayBalances =
    { Account : string
      Ledger : Ledger }

type NoRippleCheck =
    { Account : string
      Ledger : Ledger
      Role : Role }

type BookOffers =
    { TakerGets : Currency
      TakerPays : Currency }

type RipplePathFind =
    { SourceAccount : string
      DestinationAccount : string
      DestinationAmount : Amount }

type Submit =
    { TxBlob : string }

type Tx =
    { Transaction : string }

//-------------------------------------------------------------------------------------------------

type Command =
    | Ping              of Ping
    | Random            of Random
    | ServerInfo        of ServerInfo
    | ServerState       of ServerState
    | AccountCurrencies of AccountCurrencies
    | AccountInfo       of AccountInfo
    | AccountLines      of AccountLines
    | AccountObjects    of AccountObjects
    | AccountOffers     of AccountOffers
    | AccountTx         of AccountTx
    | GatewayBalances   of GatewayBalances
    | NoRippleCheck     of NoRippleCheck
    | BookOffers        of BookOffers
    | RipplePathFind    of RipplePathFind
    | Submit            of Submit
    | Tx                of Tx
