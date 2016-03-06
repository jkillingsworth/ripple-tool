module RippleTool.TransactionTypes

open System
open RippleTool.Types

//-------------------------------------------------------------------------------------------------

[<Flags>]
type PaymentFlags =
    | None              = 0x00000000u
    | FullyCanonicalSig = 0x80000000u

type Payment =
    { Account : string
      Fee : Amount
      Sequence : uint32
      Flags : PaymentFlags
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
    | SetNoRipple       = 0x00020000u
    | ClearNoRipple     = 0x00040000u

type TrustSet =
    { Account : string
      Fee : Amount
      Sequence : uint32
      Flags : TrustSetFlags
      LimitAmount : Amount }

//-------------------------------------------------------------------------------------------------

type Transaction =
    | Payment       of Payment
    | AccountSet    of AccountSet
    | SetRegularKey of SetRegularKey
    | OfferCreate   of OfferCreate
    | OfferCancel   of OfferCancel
    | TrustSet      of TrustSet
