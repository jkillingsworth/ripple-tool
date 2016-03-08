module RippleTool.Encoding

open System
open System.Security.Cryptography

//-------------------------------------------------------------------------------------------------

module Binary =

    let private reverseIfPlatformIsNotBigEndian binary =
        if BitConverter.IsLittleEndian then
            binary |> Array.rev
        else
            binary

    let private removeSignIndicator (binary : byte[]) =
        if (binary.[0] = 0uy && binary.Length > 1) then
            binary.[1 ..]
        else
            binary

    let private appendSignIndicator (binary : byte[]) =
        if (binary.[0] > 127uy) then
            binary |> Array.append [| 0uy |]
        else
            binary

    let private convertWith conversion binary = conversion (binary, 0)

    let ofBigint (input : bigint) =
        input.ToByteArray()
        |> reverseIfPlatformIsNotBigEndian
        |> removeSignIndicator

    let toBigint (input : byte[]) =
        input
        |> appendSignIndicator
        |> reverseIfPlatformIsNotBigEndian
        |> bigint

    let ofUInt16 (input : uint16) =
        input
        |> BitConverter.GetBytes
        |> reverseIfPlatformIsNotBigEndian

    let toUInt16 (input : byte[]) =
        input
        |> reverseIfPlatformIsNotBigEndian
        |> convertWith BitConverter.ToUInt16

    let ofUInt32 (input : uint32) =
        input
        |> BitConverter.GetBytes
        |> reverseIfPlatformIsNotBigEndian

    let toUInt32 (input : byte[]) =
        input
        |> reverseIfPlatformIsNotBigEndian
        |> convertWith BitConverter.ToUInt32

    let ofUInt64 (input : uint64) =
        input
        |> BitConverter.GetBytes
        |> reverseIfPlatformIsNotBigEndian

    let toUInt64 (input : byte[]) =
        input
        |> reverseIfPlatformIsNotBigEndian
        |> convertWith BitConverter.ToUInt64

    let ofHex (input : string) =
        input
        |> Array.ofSeq
        |> Array.chunkBySize 2
        |> Array.map String
        |> Array.map (fun x -> Byte.Parse(x, Globalization.NumberStyles.AllowHexSpecifier))

    let toHex (input : byte[]) =
        input
        |> Array.map (sprintf "%02X")
        |> String.Concat

//-------------------------------------------------------------------------------------------------

module Base58 =

    let alphabet = "rpshnaf39wBUDNEGHJKLM4PQRST7VWXYZ2bcdeCg65jkm8oFqi1tuvAxyz"

    type private Version =
        | AccountId     = 00uy
        | SecretKey     = 33uy
        | AccountKeyPrv = 34uy
        | AccountKeyPub = 35uy
        | RootKeyPub    = 41uy

    let private computeHashsum version payload =
        use sha256 = SHA256.Create()
        payload
        |> Array.append version
        |> sha256.ComputeHash
        |> sha256.ComputeHash
        |> Array.take 4

    let ofBigint (input : bigint) =

        let generator = function
            | state when state = 0I -> None
            | state ->
                let modulo = state % 58I
                let divide = state / 58I
                Some (modulo, divide)

        let includeZeroPlaceholder chars =
            if Array.isEmpty chars then [| alphabet.[0] |] else chars

        input
        |> Array.unfold generator
        |> Array.map (fun x -> alphabet.[int x])
        |> Array.rev
        |> includeZeroPlaceholder
        |> String

    let toBigint (input : string) =
        input
        |> Seq.map (fun x -> alphabet.IndexOf(x))
        |> Seq.fold (fun acc x -> (acc * 58I) + bigint x) 0I

    let private encode version (input : byte[]) =

        let binaryVersion = [| byte version |]
        let binaryPayload = input
        let binaryHashsum = computeHashsum binaryVersion binaryPayload

        let binary = Array.concat [ binaryVersion; binaryPayload; binaryHashsum ]

        let encodedPadding =
            binary
            |> Array.takeWhile (fun x -> x = 0x00uy)
            |> Array.map (fun _ -> alphabet.[0])
            |> String

        let encodedInteger =
            binary
            |> Binary.toBigint
            |> ofBigint

        encodedPadding + encodedInteger

    let private decode version (input : string) =

        let decodedPadding =
            input
            |> Seq.takeWhile (fun x -> x = alphabet.[0])
            |> Seq.length
            |> Array.zeroCreate<byte>

        let decodedInteger =
            input
            |> toBigint
            |> Binary.ofBigint

        let binary = Array.concat [ decodedPadding; decodedInteger ]
        let length = binary.Length - 4

        let binaryVersion = binary.[0 .. 0]
        let binaryPayload = binary.[1 .. length - 1]
        let binaryHashsum = binary.[length ..]

        if binaryVersion <> [| byte version |]
            then failwith "Invalid version."

        if binaryHashsum <> computeHashsum binaryVersion binaryPayload
            then failwith "Invalid hashsum."

        binaryPayload

    let encodeAccountId = encode Version.AccountId
    let encodeSecretKey = encode Version.SecretKey
    let encodeAccountKeyPrv = encode Version.AccountKeyPrv
    let encodeAccountKeyPub = encode Version.AccountKeyPub
    let encodeRootKeyPub = encode Version.RootKeyPub

    let decodeAccountId = decode Version.AccountId
    let decodeSecretKey = decode Version.SecretKey
    let decodeAccountKeyPrv = decode Version.AccountKeyPrv
    let decodeAccountKeyPub = decode Version.AccountKeyPub
    let decodeRootKeyPub = decode Version.RootKeyPub
