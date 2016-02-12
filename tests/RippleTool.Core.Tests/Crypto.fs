module Crypto

open NUnit.Framework
open FsUnit
open RippleTool.Encoding
open RippleTool.Crypto

//-------------------------------------------------------------------------------------------------

[<Test>]
let ``Compute the hash for 0 as a 1-byte array`` () =

    let input = [| 0x00uy |]
    let expected = Binary.ofHex "B8244D028981D693AF7B456AF8EFA4CAD63D282E19FF14942C246E50D9351D22"
    input |> computeHash |> should equal expected

[<Test>]
let ``Compute the hash for 100000 as a 4-byte array in big endian format`` () =

    let input = [| 0x00uy; 0x01uy; 0x86uy; 0xA0uy |]
    let expected = Binary.ofHex "8EEE2EA9E7F93AB0D9E66EE4CE696D6824922167784EC7F340B3567377B1CE64"
    input |> computeHash |> should equal expected

[<Test>]
let ``Compute root keys`` () =

    let rootKeys = "shHM53KPZ87Gwdqarm1bAmPeXg8Tn" |> Base58.decodeSecretKey |> computeRootKeys

    let rootKeyPrv = rootKeys.Prv |> Binary.toHex
    let rootKeyPub = rootKeys.Pub |> Base58.encodeRootKeyPub

    rootKeyPrv |> should equal "7CFBA64F771E93E817E15039215430B53F7401C34931D111EAB3510B22DBB0D8"
    rootKeyPub |> should equal "fht5yrLWh3P8DrJgQuVNDPQVXGTMyPpgRHFKGQzFQ66o3ssesk3o"

[<Test>]
let ``Compute account keys`` () =

    let rootKeyPrv = Binary.ofHex "7CFBA64F771E93E817E15039215430B53F7401C34931D111EAB3510B22DBB0D8"
    let rootKeyPub = Base58.decodeRootKeyPub "fht5yrLWh3P8DrJgQuVNDPQVXGTMyPpgRHFKGQzFQ66o3ssesk3o"
    let rootKeys = { Prv = rootKeyPrv; Pub = rootKeyPub }

    let accountKeys = rootKeys |> computeAccountKeys 0u

    let accountKeyPrv = accountKeys.Prv |> Base58.encodeAccountKeyPrv
    let accountKeyPub = accountKeys.Pub |> Base58.encodeAccountKeyPub

    accountKeyPrv |> should equal "pwMPbuE25rnajigDPBEh9Pwv8bMV2ebN9gVPTWTh4c3DtB14iGL"
    accountKeyPub |> should equal "aBRoQibi2jpDofohooFuzZi9nEzKw9Zdfc4ExVNmuXHaJpSPh8uJ"
