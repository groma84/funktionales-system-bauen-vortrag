module Data.Year

type Year = private Year of int

let (|Year|) = function
    Year i -> Year i
    
let create (year: int) =
    if year < 1980 or year > 2100 then
        Error "invalid year - not between 1980 and 2100"
    else
        Ok (Year year)