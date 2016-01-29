module RippleTool.TransactionTypes

open System

//-------------------------------------------------------------------------------------------------

type NativeAmount = uint32

type IssuedAmount = { Value : float; Currency : string; Issuer : string }

type Amount =
    | NativeAmount of NativeAmount
    | IssuedAmount of IssuedAmount

//-------------------------------------------------------------------------------------------------

type AccountSet = unit
type OfferCancel = unit
type OfferCreate = unit
type Payment = unit
type SetRegularKey = unit

[<Flags>]
type TrustSetFlags =
    | FullyCanonicalSig = 0x80000000u
    | SetNoRipple       = 0x00020000u
    | ClearNoRipple     = 0x00040000u

type TrustSet =
    { Account : string
      Fee : Amount
      Flags : uint32
      Sequence : uint32
      LimitAmount : Amount }

//-------------------------------------------------------------------------------------------------

type Transaction =
    | AccountSet of AccountSet
    | OfferCancel of OfferCancel
    | OfferCreate of OfferCreate
    | Payment of Payment
    | SetRegularKey of SetRegularKey
    | TrustSet of TrustSet
