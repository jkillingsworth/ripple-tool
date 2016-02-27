module RippleTool.Types

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
