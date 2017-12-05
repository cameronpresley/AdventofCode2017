#load "Day4.fs"
open Day4

input.Split([|"\n"|], System.StringSplitOptions.RemoveEmptyEntries)
                |> Array.map(fun line -> line.Split([|" "|], System.StringSplitOptions.RemoveEmptyEntries))
                |> Array.filter(fun words -> (words |> Array.distinct |> Array.length) = (words |> Array.length))
                |> Array.length 
                |> printfn "%A"


