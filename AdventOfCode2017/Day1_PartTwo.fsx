#load "Day1.fs"
open Day1

let tokens = input |> List.ofSeq |> List.map(fun x -> System.Int32.Parse(x.ToString()))

let sumHalf tokens =
    let midPoint = (tokens |> List.length) / 2
    let firstHalf = tokens |> List.take midPoint
    let secondHalf = tokens |> List.skip midPoint
    
    let getPair (a, b) = if a = b then a*2 else 0
    let pairs = List.zip firstHalf secondHalf
    pairs |> List.fold(fun total pair -> total+getPair(pair)) 0

sumHalf tokens
