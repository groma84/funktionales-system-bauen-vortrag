module Demo.Data.Time

open FSharpPlus

type Hour = int

type Minute = int

type Second = int

type Time = private Time of Hour * Minute * Second

let (|Time|) = function
    | (Time(h, m, s)) -> (Time(h, m, s))

let create (hour : int) (minute : int) (second : int) : Result<Time, string> =
    let validateValueWithinRange v min max =
        if (v < min) then
            sprintf "Value %i must be above %i" v min
            |> Error
        else
            if (v > max) then
               sprintf "Value %i must be below %i" v max
               |> Error
            else
               Ok v
                
    monad {
        let! h = validateValueWithinRange hour 0 23
        let! m = validateValueWithinRange minute 0 59
        let! s = validateValueWithinRange second 0 59
        
        return (Time (h, m, s))
    }
    
