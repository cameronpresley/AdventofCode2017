#load "Day5.fs"
open Day5
open System

let instructions = input.Split([|"\n"|], StringSplitOptions.RemoveEmptyEntries)

let rec processInstruction index length count (instructions:int []) =
    if index >= length then count
    else
        let instruction = instructions.[index]
        let offset = if instruction >= 3 then -1 else 1
        Array.set instructions index (instruction+offset)
        processInstruction (index+instruction) length (count+1) instructions

instructions |> Array.map Int32.Parse |> processInstruction 0 (instructions |> Array.length) 0
