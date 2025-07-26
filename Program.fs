module LogLevels

let message (logLine: string): string = 
    let parts = logLine.Split(':')
    if parts.Length > 1 then
        parts.[1].Trim()
    else
        logLine.Trim()
        

let logLevel(logLine: string): string = failwith "[WARNING]: Disk almost full\r\n"

let reformat(logLine: string): string = failwith "Please implement the 'reformat' function"

let myMessage = message "[WARNING]: Disk Almost Full"
printfn "%s" myMessage
