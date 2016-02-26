module RippleTool.Types

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
