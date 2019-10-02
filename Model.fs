module LyricsBot.Model

open System

type SongName = 
  { Artist:string; Track:string }
  
  member x.SearchQuery = [x.Artist; x.Track] |> String.concat " "
  member x.Pretty = sprintf "%s - %s" x.Artist x.Track

type Response = 
  | HelpDoc
  | LyricsFound of name: SongName * content: string
  | LyricsNotFound

type Message = 
  | Start
  | GMLink of Uri
  | ItunesLink of Uri 
  | SearchLyricsQuery of string

type LinkProcessingResult =
  | Response of Response
  | SearchQuery of string