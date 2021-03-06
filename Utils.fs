namespace LyricsBot

module Utils = 
  open System
  
  let rec firstSome fs = 
    match fs with
    | x::xs -> Option.orElseWith (fun _ -> firstSome xs) (x())
    | [] -> None

  let tryToOption = function 
    | (true, uri) -> Some uri
    | (false, _) -> None

  let createUri str = 
    Uri.TryCreate(str, UriKind.Absolute) 
    |> tryToOption

  let extractQueryValueFromUri key (uri : Uri) = 
    uri.Query.TrimStart('?').Split [|'&'; '='|] |>
    Array.chunkBySize 2 |>
    Array.tryFind (fun pair -> pair.[0] = key) |>
    Option.bind (fun pair -> Some pair.[1])