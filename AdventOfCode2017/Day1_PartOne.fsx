// Learn more about F# at http://fsharp.org. See the 'F# Tutorial' project
// for more guidance on F# programming.

#load "Day1.fs"
open Day1

let tokens = input |> List.ofSeq |> List.map(fun x -> System.Int32.Parse(x.ToString()))

let sumPairs tokens =
    let tokens = tokens @ [tokens |> List.head]
    let rec add = function 
        | a::b::c when a=b -> a + add(b::c)
        | _::t -> add(t)
        | _ -> 0
    add tokens

sumPairs tokens

