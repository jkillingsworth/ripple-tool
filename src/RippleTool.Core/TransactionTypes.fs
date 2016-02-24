module RippleTool.TransactionTypes

open System

//-------------------------------------------------------------------------------------------------

type NativeAmount = decimal

type IssuedAmount = { Value : decimal; Currency : string; Issuer : string }

type Amount =
    | NativeAmount of NativeAmount
    | IssuedAmount of IssuedAmount

//-------------------------------------------------------------------------------------------------

type AccountSet = unit
type OfferCancel = unit
type OfferCreate = unit

[<Flags>]
type PaymentFlags =
    | None              = 0x00000000u
    | FullyCanonicalSig = 0x80000000u

type Payment =
    { Account : string
      Fee : Amount
      Sequence : uint32
      Flags : uint32
      Destination : string
      Amount : Amount }

type SetRegularKey = unit

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
      Flags : uint32
      LimitAmount : Amount }

//-------------------------------------------------------------------------------------------------

type Transaction =
    | AccountSet    of AccountSet
    | OfferCancel   of OfferCancel
    | OfferCreate   of OfferCreate
    | Payment       of Payment
    | SetRegularKey of SetRegularKey
    | TrustSet      of TrustSet
