#load "Day3.fs"
open Day3
open System


let rec calculateDistance start step number =
    if start >= number then step
    else calculateDistance (start+8) (step+1) number

let rec calculateBottomRight start number =
    if start*start < number && (start+2)*(start+2) >= number then start
    else calculateBottomRight (start+2) number


type Direction = Left | Right | Up | Down

let rec stepThrough (x:int) (y:int) currentSpot direction final =
    if final = currentSpot then abs(x) + abs(y)
    else
        match direction with
        | Up ->
            if abs(x) = abs(y) && x > 0 && y > 0 then stepThrough x y (currentSpot+1) Left final
            else stepThrough x (y+1) (currentSpot+1) Up final
        | Right ->
            if abs(x) = abs(y) && x >= 0 && y <= 0 then stepThrough x y currentSpot Up final
            else stepThrough (x+1) y (currentSpot+1) Right final
        | Left ->
            if abs(x) = abs(y) && x < 0 && y > 0 then stepThrough x y currentSpot Down final
            else stepThrough (x-1) y (currentSpot+1) Left final
        | Down ->
            if abs(x) = abs(y) && x < 0 && y < 0 then stepThrough x y currentSpot Right final
            else stepThrough x (y-1) (currentSpot+1) Down final

        