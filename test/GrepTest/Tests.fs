module Tests

open System
open Xunit
open Grep.SimpleGreps
open System.Linq

[<Fact>]
let ``grep test``() =
  let actual =
    fileContentMatch "/Users/takedamasaru/develop/fsharp/fgrep/src/App/Program.fs" "let"
  let expected =
    [ "/Users/takedamasaru/develop/fsharp/fgrep/src/App/Program.fs"
      "let main argv ="
      "  let dirpath = argv.[0]"
      "  let filePattern = argv.[1]"
      "  let contentPattern = argv.[2]" ]
  Assert.Equal(System.String.Join("\n", expected), actual)
