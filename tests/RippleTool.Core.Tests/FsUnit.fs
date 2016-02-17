module RippleTool.Tests.FsUnit

open NUnit.Framework.Constraints
open RippleTool.Encoding

//-------------------------------------------------------------------------------------------------

type EqualBinaryConstraint(expected) = inherit Constraint() with

    let display binary =
        let max = 100
        if (binary |> Array.length > max) then
            binary |> Array.take max |> Binary.toHex |> fun x -> x + "..."
        else
            binary |> Binary.toHex

    override this.WriteDescriptionTo(writer : MessageWriter) : unit =
        let output = display (expected)
        writer.Write(output)

    override this.WriteActualValueTo(writer : MessageWriter) : unit =
        let output = display (this.actual :?> byte[])
        writer.Write(output)

    override this.Matches(actual : obj) =
        let actual = actual :?> byte[]
        this.actual <- actual
        actual = expected

[<AutoOpen>]
module TopLevelOperators =

    let equal : (obj -> Constraint) = function
        | :? (byte[]) as x
            -> EqualBinaryConstraint(x) :> Constraint
        | x -> EqualConstraint(x) :> Constraint
