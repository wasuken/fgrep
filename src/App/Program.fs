// Learn more about F# at http://fsharp.org

open System
open Grep.SimpleGreps

[<EntryPoint>]
let main argv =
  let dirpath = argv.[0]
  let filePattern = argv.[1]
  let contentPattern = argv.[2]
  Console.WriteLine("{0}", (simpleRecurSearch dirpath filePattern contentPattern))
  0 // return an integer exit code
