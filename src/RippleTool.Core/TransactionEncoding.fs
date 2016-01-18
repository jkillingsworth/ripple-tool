module RippleTool.TransactionEncoding

open System
open System.Security.Cryptography
open RippleTool.TransactionTypes

//-------------------------------------------------------------------------------------------------

let private toBigEndian binary =

    if BitConverter.IsLittleEndian then
        binary |> Array.rev
    else
        binary

//-------------------------------------------------------------------------------------------------

module Base58 =

    let private alphabet = "rpshnaf39wBUDNEGHJKLM4PQRST7VWXYZ2bcdeCg65jkm8oFqi1tuvAxyz"

    let private versionAccountId = 0uy
    let private versionSecretKey = 33uy

    let private toBinaryNoSignIndicator (value : bigint) =

        let binary = value.ToByteArray()

        if (binary.[binary.Length - 1] = 0uy) then
            binary.[.. binary.Length - 1 - 1]
        else
            binary

    let private computeDoubleDigest (value : byte[]) =

        use provider = new SHA256CryptoServiceProvider()

        value
        |> provider.ComputeHash
        |> provider.ComputeHash

    let private decode (input : string) =

        let binaryPadding =
            input
            |> Seq.takeWhile (fun x -> x = alphabet.[0])
            |> Seq.length
            |> Array.zeroCreate<byte>

        let binaryInteger =
            input
            |> Seq.map (fun x -> alphabet.IndexOf(x))
            |> Seq.fold (fun acc x -> (acc * 58I) + bigint x) 0I
            |> toBinaryNoSignIndicator
            |> toBigEndian

        Array.concat [ binaryPadding; binaryInteger ]

    let private decodeChecked input version =

        let validateLength (buffer : byte[]) =
            let failure = buffer.Length < 4
            if (failure) then failwith "Input too short."

        let validateVersion (buffer : byte[]) =
            let failure = buffer.[0] <> version
            if (failure) then failwith "Version is wrong."

        let validateChecksum actual expect =
            let failure = actual <> expect
            if (failure) then failwith "Checksum does not validate."

        let buffer = decode input

        buffer |> validateLength
        buffer |> validateVersion

        let valueToHash = buffer.[.. buffer.Length - 4 - 1]
        let checksumActual = buffer.[buffer.Length - 4 ..]
        let checksumExpect = (computeDoubleDigest valueToHash).[.. 4 - 1]

        validateChecksum checksumActual checksumExpect

        buffer.[1 .. buffer.Length - 4 - 1]

    let decodeAccountId input =

        decodeChecked input versionAccountId

    let decodeSecretKey input =

        decodeChecked input versionSecretKey

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

let toBinaryUInt16 (value : uint16) =

    value
    |> BitConverter.GetBytes
    |> toBigEndian

let toBinaryUInt32 (value : uint32) =

    value
    |> BitConverter.GetBytes
    |> toBigEndian

let toBinaryUInt64 (value : uint64) =

    value
    |> BitConverter.GetBytes
    |> toBigEndian

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

//-------------------------------------------------------------------------------------------------

let toHex (binary : byte[]) =

    binary
    |> Array.map (sprintf "%02X")
    |> Array.fold (+) ""
