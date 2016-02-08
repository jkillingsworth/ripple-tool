module RippleTool.Encoding

open System

//-------------------------------------------------------------------------------------------------

module Hex =

    let stringToBinary (input : string) =
        input
        |> Array.ofSeq
        |> Array.chunkBySize 2
        |> Array.map String
        |> Array.map (fun x -> Byte.Parse(x, Globalization.NumberStyles.AllowHexSpecifier))

    let binaryToString (input : byte[]) =
        input
        |> Array.map (sprintf "%02X")
        |> String.Concat
