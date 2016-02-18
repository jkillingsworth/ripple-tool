module RippleTool.TransactionEncoding

open System
open RippleTool.Encoding
open RippleTool.TransactionTypes

//-------------------------------------------------------------------------------------------------

module Binary =

    let private ofNativeAmount (input : NativeAmount) =

        let x1 = uint64 0 <<< 63
        let x2 = uint64 1 <<< 62
        let x3 = uint64 input
        Binary.ofUint64 (x1 ||| x2 ||| x3)

    let private ofIssuedAmount (input : IssuedAmount) =

        let value = input.Value.ToString(".0###########################")

        let exponent =
            match value.IndexOf(".") with
            | 0 -> 1 - value.Length
            | i -> i - 1

        let exponent = 97 - 15 + exponent

        let mantissa = "0." + value.Replace(".", "").TrimStart('0')
        let mantissa = Decimal.Parse(mantissa)
        let mantissa = Decimal.Round(mantissa, 16)
        let mantissa = Decimal.Multiply(mantissa, 10000000000000000m)

        let combined =
            match input.Value with
            | x when x = Decimal.Zero
                -> uint64 1 <<< 63
            | _ ->
                let x1 = uint64 1 <<< 63
                let x2 = uint64 1 <<< 62
                let x3 = uint64 exponent <<< 54
                let x4 = uint64 mantissa <<< 00
                (x1 ||| x2 ||| x3 ||| x4)

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
