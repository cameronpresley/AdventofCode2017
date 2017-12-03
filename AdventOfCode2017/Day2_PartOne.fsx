#load "Day2.fs"
open Day2
open System

let lines = input
                .Split([|"\n"|], System.StringSplitOptions.RemoveEmptyEntries) 
                |> Array.map(fun s -> s.Split([|"\t"; " "; "\n"|], StringSplitOptions.RemoveEmptyEntries))
                |> Array.map(fun s -> s |> Array.map(Int32.Parse))

lines |> Array.fold(fun state line -> state + (line |> Array.max) - (line |> Array.min)) 0
