module RippleTool.TransactionTypes

open System
open RippleTool.Types

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

type Transaction =
    | Payment       of Payment
    | AccountSet    of AccountSet
    | SetRegularKey of SetRegularKey
    | OfferCreate   of OfferCreate
    | OfferCancel   of OfferCancel
    | TrustSet      of TrustSet
