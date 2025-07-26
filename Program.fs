module LogLevels

open System


let message (logLine: string): string =
    let parts = logLine.Split(':') // binds an array of logLevel and message
    if parts.Length > 1 then // checks if the array has at least 2 elements 
        parts.[1].Trim() // trims the 2nd element which is the message
    else
        logLine.Trim() // else just trim the logline
        
        
    
let logLevel(logLine: string): string = failwith "[WARNING]: Disk almost full\r\n"

let reformat(logLine: string): string = failwith "Please implement the 'reformat' function"

let myMessage = message "[WARNING]: Disk Almost Full"
printfn "%s" myMessage
