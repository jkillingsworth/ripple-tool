module RippleTool.Tests.Encoding

open NUnit.Framework
open FsUnit
open RippleTool.Encoding

//-------------------------------------------------------------------------------------------------

[<Test>]
let ``Binary of bigint 000`` () =
    000I |> Binary.ofBigint |> should equal [| 0x00uy |]

[<Test>]
let ``Binary of bigint 001`` () =
    001I |> Binary.ofBigint |> should equal [| 0x01uy |]

[<Test>]
let ``Binary of bigint 127`` () =
    127I |> Binary.ofBigint |> should equal [| 0x7Fuy |]

[<Test>]
let ``Binary of bigint 128`` () =
    128I |> Binary.ofBigint |> should equal [| 0x80uy |]

[<Test>]
let ``Binary of bigint 255`` () =
    255I |> Binary.ofBigint |> should equal [| 0xFFuy |]

[<Test>]
let ``Binary of bigint 256`` () =
    256I |> Binary.ofBigint |> should equal [| 0x01uy; 0x00uy |]

[<Test>]
let ``Binary of bigint 999`` () =
    999I |> Binary.ofBigint |> should equal [| 0x03uy; 0xE7uy |]

//-------------------------------------------------------------------------------------------------

[<Test>]
let ``Binary to bigint 000`` () =
    [| 0x00uy |] |> Binary.toBigint |> should equal 000I

[<Test>]
let ``Binary to bigint 001`` () =
    [| 0x01uy |] |> Binary.toBigint |> should equal 001I

[<Test>]
let ``Binary to bigint 127`` () =
    [| 0x7Fuy |] |> Binary.toBigint |> should equal 127I

[<Test>]
let ``Binary to bigint 128`` () =
    [| 0x80uy |] |> Binary.toBigint |> should equal 128I

[<Test>]
let ``Binary to bigint 255`` () =
    [| 0xFFuy |] |> Binary.toBigint |> should equal 255I

[<Test>]
let ``Binary to bigint 256`` () =
    [| 0x01uy; 0x00uy |] |> Binary.toBigint |> should equal 256I

[<Test>]
let ``Binary to bigint 999`` () =
    [| 0x03uy; 0xE7uy |] |> Binary.toBigint |> should equal 999I

//-------------------------------------------------------------------------------------------------

[<Test>]
let ``Binary of uint16 000`` () =
    000us |> Binary.ofUint16 |> should equal [| 0x00uy; 0x00uy |]

[<Test>]
let ``Binary of uint16 001`` () =
    001us |> Binary.ofUint16 |> should equal [| 0x00uy; 0x01uy |]

[<Test>]
let ``Binary of uint16 255`` () =
    255us |> Binary.ofUint16 |> should equal [| 0x00uy; 0xFFuy |]

[<Test>]
let ``Binary of uint16 256`` () =
    256us |> Binary.ofUint16 |> should equal [| 0x01uy; 0x00uy |]

[<Test>]
let ``Binary of uint16 999`` () =
    999us |> Binary.ofUint16 |> should equal [| 0x03uy; 0xE7uy |]

//-------------------------------------------------------------------------------------------------

[<Test>]
let ``Binary to uint16 000`` () =
    [| 0x00uy; 0x00uy |] |> Binary.toUint16 |> should equal 000us

[<Test>]
let ``Binary to uint16 001`` () =
    [| 0x00uy; 0x01uy |] |> Binary.toUint16 |> should equal 001us

[<Test>]
let ``Binary to uint16 255`` () =
    [| 0x00uy; 0xFFuy |] |> Binary.toUint16 |> should equal 255us

[<Test>]
let ``Binary to uint16 256`` () =
    [| 0x01uy; 0x00uy |] |> Binary.toUint16 |> should equal 256us

[<Test>]
let ``Binary to uint16 999`` () =
    [| 0x03uy; 0xE7uy |] |> Binary.toUint16 |> should equal 999us

//-------------------------------------------------------------------------------------------------

[<Test>]
let ``Binary of uint32 000`` () =
    000u |> Binary.ofUint32 |> should equal [| 0x00uy; 0x00uy; 0x00uy; 0x00uy |]

[<Test>]
let ``Binary of uint32 001`` () =
    001u |> Binary.ofUint32 |> should equal [| 0x00uy; 0x00uy; 0x00uy; 0x01uy |]

[<Test>]
let ``Binary of uint32 255`` () =
    255u |> Binary.ofUint32 |> should equal [| 0x00uy; 0x00uy; 0x00uy; 0xFFuy |]

[<Test>]
let ``Binary of uint32 256`` () =
    256u |> Binary.ofUint32 |> should equal [| 0x00uy; 0x00uy; 0x01uy; 0x00uy |]

[<Test>]
let ``Binary of uint32 999`` () =
    999u |> Binary.ofUint32 |> should equal [| 0x00uy; 0x00uy; 0x03uy; 0xE7uy |]

//-------------------------------------------------------------------------------------------------

[<Test>]
let ``Binary to uint32 000`` () =
    [| 0x00uy; 0x00uy; 0x00uy; 0x00uy |] |> Binary.toUint32 |> should equal 000u

[<Test>]
let ``Binary to uint32 001`` () =
    [| 0x00uy; 0x00uy; 0x00uy; 0x01uy |] |> Binary.toUint32 |> should equal 001u

[<Test>]
let ``Binary to uint32 255`` () =
    [| 0x00uy; 0x00uy; 0x00uy; 0xFFuy |] |> Binary.toUint32 |> should equal 255u

[<Test>]
let ``Binary to uint32 256`` () =
    [| 0x00uy; 0x00uy; 0x01uy; 0x00uy |] |> Binary.toUint32 |> should equal 256u

[<Test>]
let ``Binary to uint32 999`` () =
    [| 0x00uy; 0x00uy; 0x03uy; 0xE7uy |] |> Binary.toUint32 |> should equal 999u

//-------------------------------------------------------------------------------------------------

[<Test>]
let ``Binary of uint64 000`` () =
    000UL |> Binary.ofUint64 |> should equal [| 0x00uy; 0x00uy; 0x00uy; 0x00uy; 0x00uy; 0x00uy; 0x00uy; 0x00uy |]

[<Test>]
let ``Binary of uint64 001`` () =
    001UL |> Binary.ofUint64 |> should equal [| 0x00uy; 0x00uy; 0x00uy; 0x00uy; 0x00uy; 0x00uy; 0x00uy; 0x01uy |]

[<Test>]
let ``Binary of uint64 255`` () =
    255UL |> Binary.ofUint64 |> should equal [| 0x00uy; 0x00uy; 0x00uy; 0x00uy; 0x00uy; 0x00uy; 0x00uy; 0xFFuy |]

[<Test>]
let ``Binary of uint64 256`` () =
    256UL |> Binary.ofUint64 |> should equal [| 0x00uy; 0x00uy; 0x00uy; 0x00uy; 0x00uy; 0x00uy; 0x01uy; 0x00uy |]

[<Test>]
let ``Binary of uint64 999`` () =
    999UL |> Binary.ofUint64 |> should equal [| 0x00uy; 0x00uy; 0x00uy; 0x00uy; 0x00uy; 0x00uy; 0x03uy; 0xE7uy |]

//-------------------------------------------------------------------------------------------------

[<Test>]
let ``Binary to uint64 000`` () =
    [| 0x00uy; 0x00uy; 0x00uy; 0x00uy; 0x00uy; 0x00uy; 0x00uy; 0x00uy |] |> Binary.toUint64 |> should equal 000UL

[<Test>]
let ``Binary to uint64 001`` () =
    [| 0x00uy; 0x00uy; 0x00uy; 0x00uy; 0x00uy; 0x00uy; 0x00uy; 0x01uy |] |> Binary.toUint64 |> should equal 001UL

[<Test>]
let ``Binary to uint64 255`` () =
    [| 0x00uy; 0x00uy; 0x00uy; 0x00uy; 0x00uy; 0x00uy; 0x00uy; 0xFFuy |] |> Binary.toUint64 |> should equal 255UL

[<Test>]
let ``Binary to uint64 256`` () =
    [| 0x00uy; 0x00uy; 0x00uy; 0x00uy; 0x00uy; 0x00uy; 0x01uy; 0x00uy |] |> Binary.toUint64 |> should equal 256UL

[<Test>]
let ``Binary to uint64 999`` () =
    [| 0x00uy; 0x00uy; 0x00uy; 0x00uy; 0x00uy; 0x00uy; 0x03uy; 0xE7uy |] |> Binary.toUint64 |> should equal 999UL

//-------------------------------------------------------------------------------------------------

[<Test>]
let ``Binary of hex string`` () =

    let input = "466F6F626172"
    let expected = [| 0x46uy; 0x6Fuy; 0x6Fuy; 0x62uy; 0x61uy; 0x72uy |]

    input |> Binary.ofHex |> should equal expected

[<Test>]
let ``Binary to hex string`` () =

    let input = [| 0x46uy; 0x6Fuy; 0x6Fuy; 0x62uy; 0x61uy; 0x72uy |]
    let expected = "466F6F626172"

    input |> Binary.toHex |> should equal expected

//-------------------------------------------------------------------------------------------------

[<Test>]
let ``Base58 of bigint 00`` () =
    00I |> Base58.ofBigint |> should equal "r"

[<Test>]
let ``Base58 of bigint 01`` () =
    01I |> Base58.ofBigint |> should equal "p"

[<Test>]
let ``Base58 of bigint 02`` () =
    02I |> Base58.ofBigint |> should equal "s"

[<Test>]
let ``Base58 of bigint 55`` () =
    55I |> Base58.ofBigint |> should equal "x"

[<Test>]
let ``Base58 of bigint 56`` () =
    56I |> Base58.ofBigint |> should equal "y"

[<Test>]
let ``Base58 of bigint 57`` () =
    57I |> Base58.ofBigint |> should equal "z"

[<Test>]
let ``Base58 of bigint 58`` () =
    58I |> Base58.ofBigint |> should equal "pr"

[<Test>]
let ``Base58 of bigint 59`` () =
    59I |> Base58.ofBigint |> should equal "pp"

[<Test>]
let ``Base58 of bigint 60`` () =
    60I |> Base58.ofBigint |> should equal "ps"

//-------------------------------------------------------------------------------------------------

[<Test>]
let ``Base58 to bigint 00`` () =
    "r" |> Base58.toBigint |> should equal 00I

[<Test>]
let ``Base58 to bigint 01`` () =
    "p" |> Base58.toBigint |> should equal 01I

[<Test>]
let ``Base58 to bigint 02`` () =
    "s" |> Base58.toBigint |> should equal 02I

[<Test>]
let ``Base58 to bigint 55`` () =
    "x" |> Base58.toBigint |> should equal 55I

[<Test>]
let ``Base58 to bigint 56`` () =
    "y" |> Base58.toBigint |> should equal 56I

[<Test>]
let ``Base58 to bigint 57`` () =
    "z" |> Base58.toBigint |> should equal 57I

[<Test>]
let ``Base58 to bigint 58`` () =
    "pr" |> Base58.toBigint |> should equal 58I

[<Test>]
let ``Base58 to bigint 59`` () =
    "pp" |> Base58.toBigint |> should equal 59I

[<Test>]
let ``Base58 to bigint 60`` () =
    "ps" |> Base58.toBigint |> should equal 60I

//-------------------------------------------------------------------------------------------------

[<Test>]
let ``Base58 encode account id rrrrrrrrrrrrrrrrrrrrrhoLvTp`` () =

    let input = Binary.ofHex "0000000000000000000000000000000000000000"
    let expected = "rrrrrrrrrrrrrrrrrrrrrhoLvTp"
    input |> Base58.encodeAccountId |> should equal expected

[<Test>]
let ``Base58 encode account id rrrrrrrrrrrrrrrrrrrrBZbvji`` () =

    let input = Binary.ofHex "0000000000000000000000000000000000000001"
    let expected = "rrrrrrrrrrrrrrrrrrrrBZbvji"
    input |> Base58.encodeAccountId |> should equal expected

[<Test>]
let ``Base58 encode account id rhcfR9Cg98qCxHpCcPBmMonbDBXo84wyTn`` () =

    let input = Binary.ofHex "278C4AC8FEAB993E85BBA8FF8401E7C37E062C56"
    let expected = "rhcfR9Cg98qCxHpCcPBmMonbDBXo84wyTn"
    input |> Base58.encodeAccountId |> should equal expected

[<Test>]
let ``Base58 encode secret key shHM53KPZ87Gwdqarm1bAmPeXg8Tn`` () =

    let input = Binary.ofHex "71ED064155FFADFA38782C5E0158CB26"
    let expected = "shHM53KPZ87Gwdqarm1bAmPeXg8Tn"
    input |> Base58.encodeSecretKey |> should equal expected

//-------------------------------------------------------------------------------------------------

[<Test>]
let ``Base58 decode account id rrrrrrrrrrrrrrrrrrrrrhoLvTp`` () =

    let input = "rrrrrrrrrrrrrrrrrrrrrhoLvTp"
    let expected = Binary.ofHex "0000000000000000000000000000000000000000"
    input |> Base58.decodeAccountId |> should equal expected

[<Test>]
let ``Base58 decode account id rrrrrrrrrrrrrrrrrrrrBZbvji`` () =

    let input = "rrrrrrrrrrrrrrrrrrrrBZbvji"
    let expected = Binary.ofHex "0000000000000000000000000000000000000001"
    input |> Base58.decodeAccountId |> should equal expected

[<Test>]
let ``Base58 decode account id rhcfR9Cg98qCxHpCcPBmMonbDBXo84wyTn`` () =

    let input = "rhcfR9Cg98qCxHpCcPBmMonbDBXo84wyTn"
    let expected = Binary.ofHex "278C4AC8FEAB993E85BBA8FF8401E7C37E062C56"
    input |> Base58.decodeAccountId |> should equal expected

[<Test>]
let ``Base58 decode secret key shHM53KPZ87Gwdqarm1bAmPeXg8Tn`` () =

    let input = "shHM53KPZ87Gwdqarm1bAmPeXg8Tn"
    let expected = Binary.ofHex "71ED064155FFADFA38782C5E0158CB26"
    input |> Base58.decodeSecretKey |> should equal expected
