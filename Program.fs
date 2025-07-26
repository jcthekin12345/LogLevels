module LogLevels

open System


let message (logLine: string): string =
    
        
    
let logLevel(logLine: string): string = failwith "[WARNING]: Disk almost full\r\n"

let reformat(logLine: string): string = failwith "Please implement the 'reformat' function"

let myMessage = message "[WARNING]: Disk Almost Full"
printfn "%s" myMessage
