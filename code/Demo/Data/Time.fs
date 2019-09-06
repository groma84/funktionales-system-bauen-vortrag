module Data.Time

// TODO
type Hour = int

type Minute = int

type Second = int

type Time = private Time of Hour * Minute * Second

let (|Time|) = function
    | (Time(h, m, s)) -> (Time(h, m, s))
// TODO
