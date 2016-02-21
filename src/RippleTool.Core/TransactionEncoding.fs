module RippleTool.TransactionEncoding

open System
open RippleTool.Encoding
open RippleTool.TransactionTypes

//-------------------------------------------------------------------------------------------------

module Binary =

    let rec private pow10 x n =
        match n with
        | n when n > 0 -> pow10 (x * 10m) (n - 1)
        | n when n < 0 -> pow10 (x / 10m) (n + 1)
        | _ -> x

    let rec private log10 x n =
        match x with
        | 0m -> n
        | x when x < 1.0m -> log10 (x * 10m) (n - 1)
        | x when x >= 10m -> log10 (x / 10m) (n + 1)
        | x -> n

    let private ofNativeAmount (input : NativeAmount) =

        let value = input

        let typeFlag = 0
        let signFlag = if value < Decimal.Zero then 0 else 1
        let valueAbs = if value < Decimal.Zero then Decimal.Negate(value) else value

        let mantissa = Decimal.Round(valueAbs, 6)
        let mantissa = pow10 mantissa <| 6

        let bits1 = uint64 typeFlag <<< 63
        let bits2 = uint64 signFlag <<< 62
        let bits3 = uint64 mantissa <<< 00

        let combined = Array.fold (|||) 0UL [| bits1; bits2; bits3 |]

        Binary.ofUint64 combined

    let private ofIssuedAmount (input : IssuedAmount) =

        let value = input.Value

        let typeFlag = 1
        let signFlag = if value > Decimal.Zero then 1 else 0
        let valueAbs = if value < Decimal.Zero then Decimal.Negate(value) else value

        let exponent = log10 valueAbs <| 0
        let mantissa = pow10 valueAbs <| 0 - exponent - 1
        let mantissa = Decimal.Round(mantissa, 16)
        let mantissa = pow10 mantissa <| 16
        let exponent = if value = Decimal.Zero then 0 else (97 - 15 + exponent)

        let bits1 = uint64 typeFlag <<< 63
        let bits2 = uint64 signFlag <<< 62
        let bits3 = uint64 exponent <<< 54
        let bits4 = uint64 mantissa <<< 00

        let combined = Array.fold (|||) 0UL [| bits1; bits2; bits3; bits4 |]

        let bytes1 = Binary.ofUint64 combined
        let bytes2 = Array.zeroCreate<byte> 12
        let bytes3 = input.Currency |> Seq.map byte |> Seq.toArray
        let bytes4 = Array.zeroCreate<byte> 5
        let bytes5 = Base58.decodeAccountId input.Issuer

        Array.concat [ bytes1; bytes2; bytes3; bytes4; bytes5 ]

    let private encodeLength = function

        | length when length <= 192u
            ->
            [| byte length |]

        | length when length <= 12480u
            ->
            let value = length - 193u
            let byte1 = byte ((value >>> 08) + 193u)
            let byte2 = byte ((value >>> 00) &&& 0xFFu)
            [| byte1; byte2 |]

        | length when length <= 918744u
            ->
            let value = length - 12481u
            let byte1 = byte ((value >>> 16) + 241u)
            let byte2 = byte ((value >>> 08) &&& 0xFFu)
            let byte3 = byte ((value >>> 00) &&& 0xFFu)
            [| byte1; byte2; byte3 |]

        | _ -> failwith "Cannot encode variable length data greater than 918744 bytes."

    let ofAmount = function
        | NativeAmount amount -> ofNativeAmount amount
        | IssuedAmount amount -> ofIssuedAmount amount

    let ofVariable (input : byte[]) =

        let binary = input
        let length = encodeLength (uint32 binary.Length)
        Array.concat [ length; binary ]

    let ofAccount (input : string) =

        let binary = Base58.decodeAccountId input
        let length = encodeLength (uint32 binary.Length)
        Array.concat [ length; binary ]
