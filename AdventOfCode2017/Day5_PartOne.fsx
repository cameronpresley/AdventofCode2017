#load "Day5.fs"
open Day5
open System

let instructions = input.Split([|"\n"|], StringSplitOptions.RemoveEmptyEntries)

let rec processInstruction index length count (instructions:int []) =
    if index >= length then count
    else
        let instruction = instructions.[index]
        Array.set instructions index (instruction+1)
        processInstruction (index+instruction) length (count+1) instructions

instructions |> Array.map Int32.Parse |> processInstruction 0 (instructions |> Array.length) 0

//[0; 3; 0; 1; -3] |> List.toArray |> processInstruction 0 5 //(instructions |> Array.length)


