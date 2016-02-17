module RippleTool.Tests.Crypto

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

//-------------------------------------------------------------------------------------------------

[<Test>]
let ``Using test keys 1, compute root keys`` () =

    let secretKey = Base58.decodeSecretKey "snoPBrXtMeMyMHUVTgbuqAfg1SUTb"

    let rootKeys = secretKey |> computeRootKeys
    let rootKeyPrv = rootKeys.Prv |> Binary.toHex
    let rootKeyPub = rootKeys.Pub |> Base58.encodeRootKeyPub

    rootKeyPrv |> should equal "395898665728F57DE5D90F1DE102278A967D6941A45A6C9A98CB123394489E55"
    rootKeyPub |> should equal "fhuJKrhSDzV2SkjLn9qbwm5AaRmrxDPfFsHDCP6yfDZWcxDFz4mt"

[<Test>]
let ``Using test keys 1, compute account keys (n = 0)`` () =

    let rootKeyPrv = Binary.ofHex "395898665728F57DE5D90F1DE102278A967D6941A45A6C9A98CB123394489E55"
    let rootKeyPub = Base58.decodeRootKeyPub "fhuJKrhSDzV2SkjLn9qbwm5AaRmrxDPfFsHDCP6yfDZWcxDFz4mt"
    let rootKeys = { Prv = rootKeyPrv; Pub = rootKeyPub }

    let accountKeys = rootKeys |> computeAccountKeys 0u
    let accountKeyPrv = accountKeys.Prv |> Base58.encodeAccountKeyPrv
    let accountKeyPub = accountKeys.Pub |> Base58.encodeAccountKeyPub

    accountKeyPrv |> should equal "p9JfM6HHi64m6mvB6v5k7G2b1cXzGmYiCNJf6GHPKvFTWdeRVjh"
    accountKeyPub |> should equal "aBQG8RQAzjs1eTKFEAQXr2gS4utcDiEC9wmi7pfUPTi27VCahwgw"

[<Test>]
let ``Using test keys 1, compute account id (n = 0)`` () =

    let accountKeyPrv = Base58.decodeAccountKeyPrv "p9JfM6HHi64m6mvB6v5k7G2b1cXzGmYiCNJf6GHPKvFTWdeRVjh"
    let accountKeyPub = Base58.decodeAccountKeyPub "aBQG8RQAzjs1eTKFEAQXr2gS4utcDiEC9wmi7pfUPTi27VCahwgw"
    let accountKeys = { Prv = accountKeyPrv; Pub = accountKeyPub }

    let accountId = accountKeys |> computeAccountId |> Base58.encodeAccountId

    accountId |> should equal "rHb9CJAWyB4rj91VRWn96DkukG4bwdtyTh"

[<Test>]
let ``Using test keys 1, compute account keys (n = 1)`` () =

    let rootKeyPrv = Binary.ofHex "395898665728F57DE5D90F1DE102278A967D6941A45A6C9A98CB123394489E55"
    let rootKeyPub = Base58.decodeRootKeyPub "fhuJKrhSDzV2SkjLn9qbwm5AaRmrxDPfFsHDCP6yfDZWcxDFz4mt"
    let rootKeys = { Prv = rootKeyPrv; Pub = rootKeyPub }

    let accountKeys = rootKeys |> computeAccountKeys 1u
    let accountKeyPrv = accountKeys.Prv |> Base58.encodeAccountKeyPrv
    let accountKeyPub = accountKeys.Pub |> Base58.encodeAccountKeyPub

    accountKeyPrv |> should equal "p9JEm822LMrzJii1k7TvdphfENTp6G5jr253Xa5rkzUWVr8ogQt"
    accountKeyPub |> should equal "aBPXpTfuLy1Bhk3HnGTTAqnovpKWQ23NpFMNkAF6F1Atg5vDyPrw"

[<Test>]
let ``Using test keys 1, compute account id (n = 1)`` () =

    let accountKeyPrv = Base58.decodeAccountKeyPrv "p9JEm822LMrzJii1k7TvdphfENTp6G5jr253Xa5rkzUWVr8ogQt"
    let accountKeyPub = Base58.decodeAccountKeyPub "aBPXpTfuLy1Bhk3HnGTTAqnovpKWQ23NpFMNkAF6F1Atg5vDyPrw"
    let accountKeys = { Prv = accountKeyPrv; Pub = accountKeyPub }

    let accountId = accountKeys |> computeAccountId |> Base58.encodeAccountId

    accountId |> should equal "r4bYF7SLUMD7QgSLLpgJx38WJSY12ViRjP"

//-------------------------------------------------------------------------------------------------

[<Test>]
let ``Using test keys 2, compute root keys`` () =

    let secretKey = Base58.decodeSecretKey "shHM53KPZ87Gwdqarm1bAmPeXg8Tn"

    let rootKeys = secretKey |> computeRootKeys
    let rootKeyPrv = rootKeys.Prv |> Binary.toHex
    let rootKeyPub = rootKeys.Pub |> Base58.encodeRootKeyPub

    rootKeyPrv |> should equal "7CFBA64F771E93E817E15039215430B53F7401C34931D111EAB3510B22DBB0D8"
    rootKeyPub |> should equal "fht5yrLWh3P8DrJgQuVNDPQVXGTMyPpgRHFKGQzFQ66o3ssesk3o"

[<Test>]
let ``Using test keys 2, compute account keys (n = 0)`` () =

    let rootKeyPrv = Binary.ofHex "7CFBA64F771E93E817E15039215430B53F7401C34931D111EAB3510B22DBB0D8"
    let rootKeyPub = Base58.decodeRootKeyPub "fht5yrLWh3P8DrJgQuVNDPQVXGTMyPpgRHFKGQzFQ66o3ssesk3o"
    let rootKeys = { Prv = rootKeyPrv; Pub = rootKeyPub }

    let accountKeys = rootKeys |> computeAccountKeys 0u
    let accountKeyPrv = accountKeys.Prv |> Base58.encodeAccountKeyPrv
    let accountKeyPub = accountKeys.Pub |> Base58.encodeAccountKeyPub

    accountKeyPrv |> should equal "pwMPbuE25rnajigDPBEh9Pwv8bMV2ebN9gVPTWTh4c3DtB14iGL"
    accountKeyPub |> should equal "aBRoQibi2jpDofohooFuzZi9nEzKw9Zdfc4ExVNmuXHaJpSPh8uJ"

[<Test>]
let ``Using test keys 2, compute account id (n = 0)`` () =

    let accountKeyPrv = Base58.decodeAccountKeyPrv "pwMPbuE25rnajigDPBEh9Pwv8bMV2ebN9gVPTWTh4c3DtB14iGL"
    let accountKeyPub = Base58.decodeAccountKeyPub "aBRoQibi2jpDofohooFuzZi9nEzKw9Zdfc4ExVNmuXHaJpSPh8uJ"
    let accountKeys = { Prv = accountKeyPrv; Pub = accountKeyPub }

    let accountId = accountKeys |> computeAccountId |> Base58.encodeAccountId

    accountId |> should equal "rhcfR9Cg98qCxHpCcPBmMonbDBXo84wyTn"
