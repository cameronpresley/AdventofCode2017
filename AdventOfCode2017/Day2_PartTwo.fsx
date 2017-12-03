
#load "Day2.fs"
open Day2
open System

let lines = input
                .Split([|"\n"|], System.StringSplitOptions.RemoveEmptyEntries) 
                |> Array.map(fun s -> s.Split([|"\t"; " "; "\n"|], StringSplitOptions.RemoveEmptyEntries))
                |> Array.map(fun s -> s |> Array.map(Int32.Parse))

let rec findDivisors nums =
    match nums with
    | [] -> 0
    | h::t ->
        match t |> List.tryFindBack(fun x -> x % h = 0) with
        | Some x -> (x/h)
        | None -> findDivisors t
    
lines |> Array.fold(fun state line -> state + (findDivisors(line|>Array.sort|>Array.toList))) 0