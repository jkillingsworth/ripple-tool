module RippleTool.TransactionEncoding

open System
open System.Security.Cryptography
open RippleTool.Encoding
open RippleTool.TransactionTypes

//-------------------------------------------------------------------------------------------------

let private endcodeValueLength = function

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

let toBinaryUInt16 = Binary.ofUint16

let toBinaryUInt32 = Binary.ofUint32

let toBinaryUInt64 = Binary.ofUint64

let toBinaryAmount = function

    | NativeAmount amount
        ->
        let x1 = 0x4000000000000000UL
        let x2 = uint64 amount
        toBinaryUInt64 (x1 ||| x2)

    | IssuedAmount amount
        ->
        let value = amount.Value.ToString().TrimStart('0')
        let index = match value.IndexOf(".") with -1 -> value.Length | i -> i

        let exponent = index - 16
        let mantissa = UInt64.Parse(value.Replace(".", "").PadRight(16, '0'))

        let x1 = 0xC000000000000000UL
        let x2 = uint64 (97 + exponent) <<< 54
        let x3 = mantissa
        let bytes1 = toBinaryUInt64 (x1 ||| x2 ||| x3)

        let bytes2 = Array.zeroCreate<byte> 12
        let bytes3 = amount.Currency |> Seq.map (fun x -> byte x) |> Seq.toArray
        let bytes4 = Array.zeroCreate<byte> 5

        let bytes5 = Base58.decodeAccountId amount.Issuer

        Array.concat [ bytes1; bytes2; bytes3; bytes4; bytes5 ]

let toBinaryVariable (value : byte[]) =

    let binary = value
    let length = endcodeValueLength (uint32 binary.Length)
    Array.concat [ length; binary ]

let toBinaryAccount (value : string) =

    let binary = Base58.decodeAccountId value
    let length = endcodeValueLength (uint32 binary.Length)
    Array.concat [ length; binary ]
