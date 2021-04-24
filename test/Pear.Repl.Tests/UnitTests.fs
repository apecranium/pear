module Pear.Repl.Tests

open System.IO
open Xunit
open Pear.Repl

[<Fact>]
let ``doRepl should write input to stream unchanged`` () =
    let outs = new StringWriter()
    let input = "()"
    doRepl outs input
    Assert.Equal(input, outs.ToString().Trim())
