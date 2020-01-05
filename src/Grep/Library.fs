namespace Grep

open System.IO
open System.Text.RegularExpressions
open System.Linq

module SimpleGreps =
  let inline fileContentMatch (filepath: string) (pattern: string): string =
    let lines = File.ReadLines(filepath)
    let filteredLines = lines.Where(fun (x: string) -> Regex.Match(x, pattern).Success)
    filepath + "\n" + System.String.Join("\n", filteredLines)

  let inline simpleRecurSearch (path: string) (filePattern: string) (linePattern: string):string =
    let files = Directory.EnumerateFiles(path, filePattern, SearchOption.AllDirectories)
    let filesAllLines = files.Select(fun x -> (fileContentMatch x linePattern))
    filesAllLines.Aggregate("", (fun sum x -> sum + x + "\n"))
