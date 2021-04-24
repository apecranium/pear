module Pear.Repl

open System
open Pear

let doRepl outs input =
    read input
    |> eval
    |> print outs

[<EntryPoint>]
let main _ =
    let rec loop () =
        printf "pear> "
        match Console.ReadLine() with
        | input when String.IsNullOrWhiteSpace(input) -> loop ()
        | input ->
            doRepl Console.Out input
            loop ()
    loop ()
    0
