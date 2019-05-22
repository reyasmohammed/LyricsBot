module LyricsBot.Functions.ProcessGMLink

open Microsoft.Azure.WebJobs
open Microsoft.Extensions.Logging
open LyricsBot
open LyricsBot.Core
open LyricsBot.Bot
open LyricsBot.Model
open LyricsBot.Telegram
open System

[<FunctionName("ProcessGoogleMusicLink")>]
let run 
  ([<QueueTrigger("gm-link-requests")>] searchLyricsReqData: Int64 * Uri, 
   [<Queue("search-lyrics-requests")>] searchLyricsRequests: ICollector<Int64 * string>,
   logger: ILogger, 
   context: ExecutionContext) =

  let (chatId, url) = searchLyricsReqData
  let telegramBotClient = createTelegramBotClient context
  let addSearchRequest query = searchLyricsRequests.Add(chatId, query)
  let sendMessage = Core.printResponse >> splitAndSendMessages telegramBotClient chatId
  let logResult result = 
    let log = printLinkProcessingResultLog result

    match result with
    | Response(LyricsNotFound) -> logger.LogError log
    | _ -> logger.LogInformation log

  sprintf "ProcessGoogleMusicLink started. ChatId: %d; Url: %O." chatId url 
  |> logger.LogInformation

  let processingResult = processGMLink url

  match processingResult with
    | Response(response) -> 
      sendMessage response
    | SearchQuery(query) -> 
      addSearchRequest query

  processingResult |> logResult    

  logger.LogInformation "ProcessGoogleMusicLink completed."