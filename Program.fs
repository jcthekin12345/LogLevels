module LogLevels

open System


let message (logLine: string): string =
    match logLine.Split(':') with
    | [| _; message |] -> message.Trim()
    | _ -> logLine.Trim()
        
    
let logLevel(logLine: string): string = failwith "[WARNING]: Disk almost full\r\n"

let reformat(logLine: string): string = failwith "Please implement the 'reformat' function"

let myMessage = message "[WARNING]: Disk Almost Full"
printfn "%s" myMessage
