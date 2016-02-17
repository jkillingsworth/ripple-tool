module RippleTool.Tests.TransactionEncoding

open NUnit.Framework
open FsUnit
open RippleTool.Encoding
open RippleTool.TransactionTypes
open RippleTool.TransactionEncoding

//-------------------------------------------------------------------------------------------------

[<Test>]
let ``Binary of native amount 000`` () =

    let input = NativeAmount 000u
    let expected = Binary.ofHex "4000000000000000"
    input |> Binary.ofAmount |> should equal expected

[<Test>]
let ``Binary of native amount 001`` () =

    let input = NativeAmount 001u
    let expected = Binary.ofHex "4000000000000001"
    input |> Binary.ofAmount |> should equal expected

[<Test>]
let ``Binary of native amount 255`` () =

    let input = NativeAmount 255u
    let expected = Binary.ofHex "40000000000000FF"
    input |> Binary.ofAmount |> should equal expected

[<Test>]
let ``Binary of native amount 256`` () =

    let input = NativeAmount 256u
    let expected = Binary.ofHex "4000000000000100"
    input |> Binary.ofAmount |> should equal expected

[<Test>]
let ``Binary of native amount 999`` () =

    let input = NativeAmount 999u
    let expected = Binary.ofHex "40000000000003E7"
    input |> Binary.ofAmount |> should equal expected

//-------------------------------------------------------------------------------------------------

[<Test>]
let ``Binary of issued amount 000.000 USD`` () =

    // 8000000000000000 1 <<< 63
    // 0000000000000000 0 <<< 62
    // 0000000000000000 0 <<< 54
    // 0000000000000000 0
    // ----------------
    // 8000000000000000

    let input =
        IssuedAmount
            { Value = 000.000m; Currency = "USD"; Issuer = "rHb9CJAWyB4rj91VRWn96DkukG4bwdtyTh" }

    let expected =
        Array.concat
            [ Binary.ofHex "8000000000000000"
              Binary.ofHex "0000000000000000000000005553440000000000"
              Binary.ofHex "B5F762798A53D543A014CAF8B297CFF8F2F937E8" ]

    input |> Binary.ofAmount |> should equal expected

[<Test>]
let ``Binary of issued amount 000.001 USD`` () =

    // 8000000000000000 1 <<< 63
    // 4000000000000000 1 <<< 62
    // 13C0000000000000 (97 - 18) <<< 54
    // 00038D7EA4C68000 1000000000000000
    // ----------------
    // D3C38D7EA4C68000

    let input =
        IssuedAmount
            { Value = 000.001m; Currency = "USD"; Issuer = "rHb9CJAWyB4rj91VRWn96DkukG4bwdtyTh" }

    let expected =
        Array.concat
            [ Binary.ofHex "D3C38D7EA4C68000"
              Binary.ofHex "0000000000000000000000005553440000000000"
              Binary.ofHex "B5F762798A53D543A014CAF8B297CFF8F2F937E8" ]

    input |> Binary.ofAmount |> should equal expected

[<Test>]
let ``Binary of issued amount 000.010 USD`` () =

    // 8000000000000000 1 <<< 63
    // 4000000000000000 1 <<< 62
    // 1400000000000000 (97 - 17) <<< 54
    // 00038D7EA4C68000 1000000000000000
    // ----------------
    // D4038D7EA4C68000

    let input =
        IssuedAmount
            { Value = 000.010m; Currency = "USD"; Issuer = "rHb9CJAWyB4rj91VRWn96DkukG4bwdtyTh" }

    let expected =
        Array.concat
            [ Binary.ofHex "D4038D7EA4C68000"
              Binary.ofHex "0000000000000000000000005553440000000000"
              Binary.ofHex "B5F762798A53D543A014CAF8B297CFF8F2F937E8" ]

    input |> Binary.ofAmount |> should equal expected

[<Test>]
let ``Binary of issued amount 000.100 USD`` () =

    // 8000000000000000 1 <<< 63
    // 4000000000000000 1 <<< 62
    // 1440000000000000 (97 - 16) <<< 54
    // 00038D7EA4C68000 1000000000000000
    // ----------------
    // D4438D7EA4C68000

    let input =
        IssuedAmount
            { Value = 000.100m; Currency = "USD"; Issuer = "rHb9CJAWyB4rj91VRWn96DkukG4bwdtyTh" }

    let expected =
        Array.concat
            [ Binary.ofHex "D4438D7EA4C68000"
              Binary.ofHex "0000000000000000000000005553440000000000"
              Binary.ofHex "B5F762798A53D543A014CAF8B297CFF8F2F937E8" ]

    input |> Binary.ofAmount |> should equal expected

[<Test>]
let ``Binary of issued amount 001.000 USD`` () =

    // 8000000000000000 1 <<< 63
    // 4000000000000000 1 <<< 62
    // 1480000000000000 (97 - 15) <<< 54
    // 00038D7EA4C68000 1000000000000000
    // ----------------
    // D4838D7EA4C68000

    let input =
        IssuedAmount
            { Value = 001.000m; Currency = "USD"; Issuer = "rHb9CJAWyB4rj91VRWn96DkukG4bwdtyTh" }

    let expected =
        Array.concat
            [ Binary.ofHex "D4838D7EA4C68000"
              Binary.ofHex "0000000000000000000000005553440000000000"
              Binary.ofHex "B5F762798A53D543A014CAF8B297CFF8F2F937E8" ]

    input |> Binary.ofAmount |> should equal expected

[<Test>]
let ``Binary of issued amount 010.000 USD`` () =

    // 8000000000000000 1 <<< 63
    // 4000000000000000 1 <<< 62
    // 14C0000000000000 (97 - 14) <<< 54
    // 00038D7EA4C68000 1000000000000000
    // ----------------
    // D4C38D7EA4C68000

    let input =
        IssuedAmount
            { Value = 010.000m; Currency = "USD"; Issuer = "rHb9CJAWyB4rj91VRWn96DkukG4bwdtyTh" }

    let expected =
        Array.concat
            [ Binary.ofHex "D4C38D7EA4C68000"
              Binary.ofHex "0000000000000000000000005553440000000000"
              Binary.ofHex "B5F762798A53D543A014CAF8B297CFF8F2F937E8" ]

    input |> Binary.ofAmount |> should equal expected

[<Test>]
let ``Binary of issued amount 100.000 USD`` () =

    // 8000000000000000 1 <<< 63
    // 4000000000000000 1 <<< 62
    // 1500000000000000 (97 - 13) <<< 54
    // 00038D7EA4C68000 1000000000000000
    // ----------------
    // D5038D7EA4C68000

    let input =
        IssuedAmount
            { Value = 100.000m; Currency = "USD"; Issuer = "rHb9CJAWyB4rj91VRWn96DkukG4bwdtyTh" }

    let expected =
        Array.concat
            [ Binary.ofHex "D5038D7EA4C68000"
              Binary.ofHex "0000000000000000000000005553440000000000"
              Binary.ofHex "B5F762798A53D543A014CAF8B297CFF8F2F937E8" ]

    input |> Binary.ofAmount |> should equal expected

[<Test>]
let ``Binary of issued amount 123.456 BTC`` () =

    // 8000000000000000 1 <<< 63
    // 4000000000000000 1 <<< 62
    // 1500000000000000 (97 - 13) <<< 54
    // 000462D366410000 1234560000000000
    // ----------------
    // D50462D366410000

    let input =
        IssuedAmount
            { Value = 123.456m; Currency = "BTC"; Issuer = "rHb9CJAWyB4rj91VRWn96DkukG4bwdtyTh" }

    let expected =
        Array.concat
            [ Binary.ofHex "D50462D366410000"
              Binary.ofHex "0000000000000000000000004254430000000000"
              Binary.ofHex "B5F762798A53D543A014CAF8B297CFF8F2F937E8" ]

    input |> Binary.ofAmount |> should equal expected

[<Test>]
let ``Binary of issued amount 999.999 BTC`` () =

    // 8000000000000000 1 <<< 63
    // 4000000000000000 1 <<< 62
    // 1500000000000000 (97 - 13) <<< 54
    // 002386F01BB51C00 9999990000000000
    // ----------------
    // D52386F01BB51C00

    let input =
        IssuedAmount
            { Value = 999.999m; Currency = "BTC"; Issuer = "rHb9CJAWyB4rj91VRWn96DkukG4bwdtyTh" }

    let expected =
        Array.concat
            [ Binary.ofHex "D52386F01BB51C00"
              Binary.ofHex "0000000000000000000000004254430000000000"
              Binary.ofHex "B5F762798A53D543A014CAF8B297CFF8F2F937E8" ]

    input |> Binary.ofAmount |> should equal expected

//-------------------------------------------------------------------------------------------------

[<Test>]
let ``Binary of variable length data with length 000000`` () =

    let input = 0xAAuy |> Array.replicate 000000
    let expected = input |> Array.append [| 0x00uy |]
    input |> Binary.ofVariable |> should equal expected

[<Test>]
let ``Binary of variable length data with length 000001`` () =

    let input = 0xAAuy |> Array.replicate 000001
    let expected = input |> Array.append [| 0x01uy |]
    input |> Binary.ofVariable |> should equal expected

[<Test>]
let ``Binary of variable length data with length 000191`` () =

    let input = 0xAAuy |> Array.replicate 000191
    let expected = input |> Array.append [| 0xBFuy |]
    input |> Binary.ofVariable |> should equal expected

[<Test>]
let ``Binary of variable length data with length 000192`` () =

    let input = 0xAAuy |> Array.replicate 000192
    let expected = input |> Array.append [| 0xC0uy |]
    input |> Binary.ofVariable |> should equal expected

[<Test>]
let ``Binary of variable length data with length 000193`` () =

    let input = 0xAAuy |> Array.replicate 000193
    let expected = input |> Array.append [| 0xC1uy; 0x00uy |]
    input |> Binary.ofVariable |> should equal expected

[<Test>]
let ``Binary of variable length data with length 000194`` () =

    let input = 0xAAuy |> Array.replicate 000194
    let expected = input |> Array.append [| 0xC1uy; 0x01uy |]
    input |> Binary.ofVariable |> should equal expected

[<Test>]
let ``Binary of variable length data with length 000448`` () =

    let input = 0xAAuy |> Array.replicate 000448
    let expected = input |> Array.append [| 0xC1uy; 0xFFuy |]
    input |> Binary.ofVariable |> should equal expected

[<Test>]
let ``Binary of variable length data with length 000449`` () =

    let input = 0xAAuy |> Array.replicate 000449
    let expected = input |> Array.append [| 0xC2uy; 0x00uy |]
    input |> Binary.ofVariable |> should equal expected

[<Test>]
let ``Binary of variable length data with length 012479`` () =

    let input = 0xAAuy |> Array.replicate 012479
    let expected = input |> Array.append [| 0xF0uy; 0xFEuy |]
    input |> Binary.ofVariable |> should equal expected

[<Test>]
let ``Binary of variable length data with length 012480`` () =

    let input = 0xAAuy |> Array.replicate 012480
    let expected = input |> Array.append [| 0xF0uy; 0xFFuy |]
    input |> Binary.ofVariable |> should equal expected

[<Test>]
let ``Binary of variable length data with length 012481`` () =

    let input = 0xAAuy |> Array.replicate 012481
    let expected = input |> Array.append [| 0xF1uy; 0x00uy; 0x00uy |]
    input |> Binary.ofVariable |> should equal expected

[<Test>]
let ``Binary of variable length data with length 012482`` () =

    let input = 0xAAuy |> Array.replicate 012482
    let expected = input |> Array.append [| 0xF1uy; 0x00uy; 0x01uy |]
    input |> Binary.ofVariable |> should equal expected

[<Test>]
let ``Binary of variable length data with length 078016`` () =

    let input = 0xAAuy |> Array.replicate 078016
    let expected = input |> Array.append [| 0xF1uy; 0xFFuy; 0xFFuy |]
    input |> Binary.ofVariable |> should equal expected

[<Test>]
let ``Binary of variable length data with length 078017`` () =

    let input = 0xAAuy |> Array.replicate 078017
    let expected = input |> Array.append [| 0xF2uy; 0x00uy; 0x00uy |]
    input |> Binary.ofVariable |> should equal expected

[<Test>]
let ``Binary of variable length data with length 918743`` () =

    let input = 0xAAuy |> Array.replicate 918743
    let expected = input |> Array.append [| 0xFEuy; 0xD4uy; 0x16uy |]
    input |> Binary.ofVariable |> should equal expected

[<Test>]
let ``Binary of variable length data with length 918744`` () =

    let input = 0xAAuy |> Array.replicate 918744
    let expected = input |> Array.append [| 0xFEuy; 0xD4uy; 0x17uy |]
    input |> Binary.ofVariable |> should equal expected

[<Test>]
let ``Binary of variable length data with length 918745`` () =

    let input = 0xAAuy |> Array.replicate 918745
    let action () = input |> Binary.ofVariable |> ignore
    action |> should throw typeof<System.Exception>

[<Test>]
let ``Binary of variable length data with length 929984`` () =

    let input = 0xAAuy |> Array.replicate 929984
    let action () = input |> Binary.ofVariable |> ignore
    action |> should throw typeof<System.Exception>

[<Test>]
let ``Binary of variable length data with length 929985`` () =

    let input = 0xAAuy |> Array.replicate 929985
    let action () = input |> Binary.ofVariable |> ignore
    action |> should throw typeof<System.Exception>

//-------------------------------------------------------------------------------------------------

[<Test>]
let ``Binary of account`` () =

    let input = "rHb9CJAWyB4rj91VRWn96DkukG4bwdtyTh"

    let expected =
        Array.concat
            [ Binary.ofHex "14"
              Binary.ofHex "B5F762798A53D543A014CAF8B297CFF8F2F937E8" ]

    input |> Binary.ofAccount |> should equal expected
