module RippleTool.Types

open System

//-------------------------------------------------------------------------------------------------

type IssuedCurrency = { Code : string; Issuer : string }
type NativeCurrency = NativeCurrency

type Currency =
    | IssuedCurrency of IssuedCurrency
    | NativeCurrency of NativeCurrency

type IssuedAmount = { Value : decimal; Currency : string; Issuer : string }
type NativeAmount = decimal

type Amount =
    | IssuedAmount of IssuedAmount
    | NativeAmount of NativeAmount

type Ledger =
    | Validated
    | Closed
    | Current

type Role =
    | User
    | Gateway

//-------------------------------------------------------------------------------------------------

[<Flags>]
type PaymentFlags =
    | None              = 0x00000000u
    | FullyCanonicalSig = 0x80000000u
    | NoRippleDirect    = 0x00010000u
    | PartialPayment    = 0x00020000u
    | LimitQuality      = 0x00040000u

type Payment =
    { Account : string
      Fee : Amount
      Sequence : uint32
      LastLedgerSequence : uint32 option
      Flags : PaymentFlags
      SourceTag : uint32 option
      DestinationTag : uint32 option
      Destination : string
      Amount : Amount }

type AccountSet = unit
type SetRegularKey = unit
type OfferCreate = unit
type OfferCancel = unit

[<Flags>]
type TrustSetFlags =
    | None              = 0x00000000u
    | FullyCanonicalSig = 0x80000000u
    | SetAuth           = 0x00010000u
    | SetNoRipple       = 0x00020000u
    | ClearNoRipple     = 0x00040000u
    | SetFreeze         = 0x00100000u
    | ClearFreeze       = 0x00200000u

type TrustSet =
    { Account : string
      Fee : Amount
      Sequence : uint32
      LastLedgerSequence : uint32 option
      Flags : TrustSetFlags
      LimitAmount : Amount
      QualityIn : decimal option
      QualityOut : decimal option }

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
    { Ledger : Ledger
      Taker : string option
      Limit : uint32 option
      TakerGets : Currency
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

type Transaction =
    | Payment           of Payment
    | AccountSet        of AccountSet
    | SetRegularKey     of SetRegularKey
    | OfferCreate       of OfferCreate
    | OfferCancel       of OfferCancel
    | TrustSet          of TrustSet

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
