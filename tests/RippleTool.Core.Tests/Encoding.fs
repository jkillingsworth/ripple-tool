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
    000us |> Binary.ofUInt16 |> should equal [| 0x00uy; 0x00uy |]

[<Test>]
let ``Binary of uint16 001`` () =
    001us |> Binary.ofUInt16 |> should equal [| 0x00uy; 0x01uy |]

[<Test>]
let ``Binary of uint16 255`` () =
    255us |> Binary.ofUInt16 |> should equal [| 0x00uy; 0xFFuy |]

[<Test>]
let ``Binary of uint16 256`` () =
    256us |> Binary.ofUInt16 |> should equal [| 0x01uy; 0x00uy |]

[<Test>]
let ``Binary of uint16 999`` () =
    999us |> Binary.ofUInt16 |> should equal [| 0x03uy; 0xE7uy |]

//-------------------------------------------------------------------------------------------------

[<Test>]
let ``Binary to uint16 000`` () =
    [| 0x00uy; 0x00uy |] |> Binary.toUInt16 |> should equal 000us

[<Test>]
let ``Binary to uint16 001`` () =
    [| 0x00uy; 0x01uy |] |> Binary.toUInt16 |> should equal 001us

[<Test>]
let ``Binary to uint16 255`` () =
    [| 0x00uy; 0xFFuy |] |> Binary.toUInt16 |> should equal 255us

[<Test>]
let ``Binary to uint16 256`` () =
    [| 0x01uy; 0x00uy |] |> Binary.toUInt16 |> should equal 256us

[<Test>]
let ``Binary to uint16 999`` () =
    [| 0x03uy; 0xE7uy |] |> Binary.toUInt16 |> should equal 999us

//-------------------------------------------------------------------------------------------------

[<Test>]
let ``Binary of uint32 000`` () =
    000u |> Binary.ofUInt32 |> should equal [| 0x00uy; 0x00uy; 0x00uy; 0x00uy |]

[<Test>]
let ``Binary of uint32 001`` () =
    001u |> Binary.ofUInt32 |> should equal [| 0x00uy; 0x00uy; 0x00uy; 0x01uy |]

[<Test>]
let ``Binary of uint32 255`` () =
    255u |> Binary.ofUInt32 |> should equal [| 0x00uy; 0x00uy; 0x00uy; 0xFFuy |]

[<Test>]
let ``Binary of uint32 256`` () =
    256u |> Binary.ofUInt32 |> should equal [| 0x00uy; 0x00uy; 0x01uy; 0x00uy |]

[<Test>]
let ``Binary of uint32 999`` () =
    999u |> Binary.ofUInt32 |> should equal [| 0x00uy; 0x00uy; 0x03uy; 0xE7uy |]

//-------------------------------------------------------------------------------------------------

[<Test>]
let ``Binary to uint32 000`` () =
    [| 0x00uy; 0x00uy; 0x00uy; 0x00uy |] |> Binary.toUInt32 |> should equal 000u

[<Test>]
let ``Binary to uint32 001`` () =
    [| 0x00uy; 0x00uy; 0x00uy; 0x01uy |] |> Binary.toUInt32 |> should equal 001u

[<Test>]
let ``Binary to uint32 255`` () =
    [| 0x00uy; 0x00uy; 0x00uy; 0xFFuy |] |> Binary.toUInt32 |> should equal 255u

[<Test>]
let ``Binary to uint32 256`` () =
    [| 0x00uy; 0x00uy; 0x01uy; 0x00uy |] |> Binary.toUInt32 |> should equal 256u

[<Test>]
let ``Binary to uint32 999`` () =
    [| 0x00uy; 0x00uy; 0x03uy; 0xE7uy |] |> Binary.toUInt32 |> should equal 999u

//-------------------------------------------------------------------------------------------------

[<Test>]
let ``Binary of uint64 000`` () =
    000UL |> Binary.ofUInt64 |> should equal [| 0x00uy; 0x00uy; 0x00uy; 0x00uy; 0x00uy; 0x00uy; 0x00uy; 0x00uy |]

[<Test>]
let ``Binary of uint64 001`` () =
    001UL |> Binary.ofUInt64 |> should equal [| 0x00uy; 0x00uy; 0x00uy; 0x00uy; 0x00uy; 0x00uy; 0x00uy; 0x01uy |]

[<Test>]
let ``Binary of uint64 255`` () =
    255UL |> Binary.ofUInt64 |> should equal [| 0x00uy; 0x00uy; 0x00uy; 0x00uy; 0x00uy; 0x00uy; 0x00uy; 0xFFuy |]

[<Test>]
let ``Binary of uint64 256`` () =
    256UL |> Binary.ofUInt64 |> should equal [| 0x00uy; 0x00uy; 0x00uy; 0x00uy; 0x00uy; 0x00uy; 0x01uy; 0x00uy |]

[<Test>]
let ``Binary of uint64 999`` () =
    999UL |> Binary.ofUInt64 |> should equal [| 0x00uy; 0x00uy; 0x00uy; 0x00uy; 0x00uy; 0x00uy; 0x03uy; 0xE7uy |]

//-------------------------------------------------------------------------------------------------

[<Test>]
let ``Binary to uint64 000`` () =
    [| 0x00uy; 0x00uy; 0x00uy; 0x00uy; 0x00uy; 0x00uy; 0x00uy; 0x00uy |] |> Binary.toUInt64 |> should equal 000UL

[<Test>]
let ``Binary to uint64 001`` () =
    [| 0x00uy; 0x00uy; 0x00uy; 0x00uy; 0x00uy; 0x00uy; 0x00uy; 0x01uy |] |> Binary.toUInt64 |> should equal 001UL

[<Test>]
let ``Binary to uint64 255`` () =
    [| 0x00uy; 0x00uy; 0x00uy; 0x00uy; 0x00uy; 0x00uy; 0x00uy; 0xFFuy |] |> Binary.toUInt64 |> should equal 255UL

[<Test>]
let ``Binary to uint64 256`` () =
    [| 0x00uy; 0x00uy; 0x00uy; 0x00uy; 0x00uy; 0x00uy; 0x01uy; 0x00uy |] |> Binary.toUInt64 |> should equal 256UL

[<Test>]
let ``Binary to uint64 999`` () =
    [| 0x00uy; 0x00uy; 0x00uy; 0x00uy; 0x00uy; 0x00uy; 0x03uy; 0xE7uy |] |> Binary.toUInt64 |> should equal 999UL

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
let ``Base58 using account 0, encode account id`` () =

    let input = Binary.ofHex "0000000000000000000000000000000000000000"
    let expected = "rrrrrrrrrrrrrrrrrrrrrhoLvTp"
    input |> Base58.encodeAccountId |> should equal expected

[<Test>]
let ``Base58 using account 0, decode account id`` () =

    let input = "rrrrrrrrrrrrrrrrrrrrrhoLvTp"
    let expected = Binary.ofHex "0000000000000000000000000000000000000000"
    input |> Base58.decodeAccountId |> should equal expected

[<Test>]
let ``Base58 using account 1, encode account id`` () =

    let input = Binary.ofHex "0000000000000000000000000000000000000001"
    let expected = "rrrrrrrrrrrrrrrrrrrrBZbvji"
    input |> Base58.encodeAccountId |> should equal expected

[<Test>]
let ``Base58 using account 1, decode account id`` () =

    let input = "rrrrrrrrrrrrrrrrrrrrBZbvji"
    let expected = Binary.ofHex "0000000000000000000000000000000000000001"
    input |> Base58.decodeAccountId |> should equal expected

//-------------------------------------------------------------------------------------------------

[<Test>]
let ``Base58 using test keys 1, encode account id`` () =

    let input = Binary.ofHex "B5F762798A53D543A014CAF8B297CFF8F2F937E8"
    let expected = "rHb9CJAWyB4rj91VRWn96DkukG4bwdtyTh"
    input |> Base58.encodeAccountId |> should equal expected

[<Test>]
let ``Base58 using test keys 1, encode secret key`` () =

    let input = Binary.ofHex "DEDCE9CE67B451D852FD4E846FCDE31C"
    let expected = "snoPBrXtMeMyMHUVTgbuqAfg1SUTb"
    input |> Base58.encodeSecretKey |> should equal expected

[<Test>]
let ``Base58 using test keys 1, encode account key prv`` () =

    let input = Binary.ofHex "1ACAAEDECE405B2A958212629E16F2EB46B153EEE94CDD350FDEFF52795525B7"
    let expected = "p9JfM6HHi64m6mvB6v5k7G2b1cXzGmYiCNJf6GHPKvFTWdeRVjh"
    input |> Base58.encodeAccountKeyPrv |> should equal expected

[<Test>]
let ``Base58 using test keys 1, encode account key pub`` () =

    let input = Binary.ofHex "0330E7FC9D56BB25D6893BA3F317AE5BCF33B3291BD63DB32654A313222F7FD020"
    let expected = "aBQG8RQAzjs1eTKFEAQXr2gS4utcDiEC9wmi7pfUPTi27VCahwgw"
    input |> Base58.encodeAccountKeyPub |> should equal expected

[<Test>]
let ``Base58 using test keys 1, encode root key pub`` () =

    let input = Binary.ofHex "03D49C56E1B185F1BE899AE66A02EFC17F78EA6FC53AF85E0FE54C6E8B7F8C71A8"
    let expected = "fhuJKrhSDzV2SkjLn9qbwm5AaRmrxDPfFsHDCP6yfDZWcxDFz4mt"
    input |> Base58.encodeRootKeyPub |> should equal expected

//-------------------------------------------------------------------------------------------------

[<Test>]
let ``Base58 using test keys 1, decode account id`` () =

    let input = "rHb9CJAWyB4rj91VRWn96DkukG4bwdtyTh"
    let expected = Binary.ofHex "B5F762798A53D543A014CAF8B297CFF8F2F937E8"
    input |> Base58.decodeAccountId |> should equal expected

[<Test>]
let ``Base58 using test keys 1, decode secret key`` () =

    let input = "snoPBrXtMeMyMHUVTgbuqAfg1SUTb"
    let expected = Binary.ofHex "DEDCE9CE67B451D852FD4E846FCDE31C"
    input |> Base58.decodeSecretKey |> should equal expected

[<Test>]
let ``Base58 using test keys 1, decode account key prv`` () =

    let input = "p9JfM6HHi64m6mvB6v5k7G2b1cXzGmYiCNJf6GHPKvFTWdeRVjh"
    let expected = Binary.ofHex "1ACAAEDECE405B2A958212629E16F2EB46B153EEE94CDD350FDEFF52795525B7"
    input |> Base58.decodeAccountKeyPrv |> should equal expected

[<Test>]
let ``Base58 using test keys 1, decode account key pub`` () =

    let input = "aBQG8RQAzjs1eTKFEAQXr2gS4utcDiEC9wmi7pfUPTi27VCahwgw"
    let expected = Binary.ofHex "0330E7FC9D56BB25D6893BA3F317AE5BCF33B3291BD63DB32654A313222F7FD020"
    input |> Base58.decodeAccountKeyPub |> should equal expected

[<Test>]
let ``Base58 using test keys 1, decode root key pub`` () =

    let input = "fhuJKrhSDzV2SkjLn9qbwm5AaRmrxDPfFsHDCP6yfDZWcxDFz4mt"
    let expected = Binary.ofHex "03D49C56E1B185F1BE899AE66A02EFC17F78EA6FC53AF85E0FE54C6E8B7F8C71A8"
    input |> Base58.decodeRootKeyPub |> should equal expected

//-------------------------------------------------------------------------------------------------

[<Test>]
let ``Base58 using test keys 2, encode account id`` () =

    let input = Binary.ofHex "278C4AC8FEAB993E85BBA8FF8401E7C37E062C56"
    let expected = "rhcfR9Cg98qCxHpCcPBmMonbDBXo84wyTn"
    input |> Base58.encodeAccountId |> should equal expected

[<Test>]
let ``Base58 using test keys 2, encode secret key`` () =

    let input = Binary.ofHex "71ED064155FFADFA38782C5E0158CB26"
    let expected = "shHM53KPZ87Gwdqarm1bAmPeXg8Tn"
    input |> Base58.encodeSecretKey |> should equal expected

[<Test>]
let ``Base58 using test keys 2, encode account key prv`` () =

    let input = Binary.ofHex "A5EF877564D096EA445E72FDA77C77BB45002261087C69D57CEA56B008102D52"
    let expected = "pwMPbuE25rnajigDPBEh9Pwv8bMV2ebN9gVPTWTh4c3DtB14iGL"
    input |> Base58.encodeAccountKeyPrv |> should equal expected

[<Test>]
let ``Base58 using test keys 2, encode account key pub`` () =

    let input = Binary.ofHex "03FA25B68DA6FF6832E4462FDFB9A2AAA58888C0ED17285FFE92E4465E0C6E782A"
    let expected = "aBRoQibi2jpDofohooFuzZi9nEzKw9Zdfc4ExVNmuXHaJpSPh8uJ"
    input |> Base58.encodeAccountKeyPub |> should equal expected

[<Test>]
let ``Base58 using test keys 2, encode root key pub`` () =

    let input = Binary.ofHex "0388E5BA87A000CB807240DF8C848EB0B5FFA5C8E5A521BC8E105C0F0A44217828"
    let expected = "fht5yrLWh3P8DrJgQuVNDPQVXGTMyPpgRHFKGQzFQ66o3ssesk3o"
    input |> Base58.encodeRootKeyPub |> should equal expected

//-------------------------------------------------------------------------------------------------

[<Test>]
let ``Base58 using test keys 2, decode account id`` () =

    let input = "rhcfR9Cg98qCxHpCcPBmMonbDBXo84wyTn"
    let expected = Binary.ofHex "278C4AC8FEAB993E85BBA8FF8401E7C37E062C56"
    input |> Base58.decodeAccountId |> should equal expected

[<Test>]
let ``Base58 using test keys 2, decode secret key`` () =

    let input = "shHM53KPZ87Gwdqarm1bAmPeXg8Tn"
    let expected = Binary.ofHex "71ED064155FFADFA38782C5E0158CB26"
    input |> Base58.decodeSecretKey |> should equal expected

[<Test>]
let ``Base58 using test keys 2, decode account key prv`` () =

    let input = "pwMPbuE25rnajigDPBEh9Pwv8bMV2ebN9gVPTWTh4c3DtB14iGL"
    let expected = Binary.ofHex "A5EF877564D096EA445E72FDA77C77BB45002261087C69D57CEA56B008102D52"
    input |> Base58.decodeAccountKeyPrv |> should equal expected

[<Test>]
let ``Base58 using test keys 2, decode account key pub`` () =

    let input = "aBRoQibi2jpDofohooFuzZi9nEzKw9Zdfc4ExVNmuXHaJpSPh8uJ"
    let expected = Binary.ofHex "03FA25B68DA6FF6832E4462FDFB9A2AAA58888C0ED17285FFE92E4465E0C6E782A"
    input |> Base58.decodeAccountKeyPub |> should equal expected

[<Test>]
let ``Base58 using test keys 2, decode root key pub`` () =

    let input = "fht5yrLWh3P8DrJgQuVNDPQVXGTMyPpgRHFKGQzFQ66o3ssesk3o"
    let expected = Binary.ofHex "0388E5BA87A000CB807240DF8C848EB0B5FFA5C8E5A521BC8E105C0F0A44217828"
    input |> Base58.decodeRootKeyPub |> should equal expected
