module Pear.Tests

open System.IO
open Xunit
open Pear

[<Fact>]
let ``read should return input unchanged`` () =
    let input = 5
    let result = read input
    Assert.Equal(input, result)

[<Fact>]
let ``eval should return ast unchanged`` () =
    let ast = 5
    let result = eval ast
    Assert.Equal(ast, result)

[<Fact>]
let ``print should write value to stream unchanged`` () =
    use outs = new StringWriter()
    let value = "test"
    print outs value
    Assert.Equal(value, outs.ToString().Trim())
