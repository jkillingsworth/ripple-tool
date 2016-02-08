module RippleTool.Tests.Encoding

open NUnit.Framework
open FsUnit
open RippleTool.Encoding

//-------------------------------------------------------------------------------------------------

[<Test>]
let ``Hex, string to binary`` () =

    let input = "466F6F626172"
    let expected = [| 0x46uy; 0x6Fuy; 0x6Fuy; 0x62uy; 0x61uy; 0x72uy |]

    input |> Hex.stringToBinary |> should equal expected

[<Test>]
let ``Hex, binary to string`` () =

    let input = [| 0x46uy; 0x6Fuy; 0x6Fuy; 0x62uy; 0x61uy; 0x72uy |]
    let expected = "466F6F626172"

    input |> Hex.binaryToString |> should equal expected
