module Data.NonEmptyString

open System

type NonEmptyString = private NonEmptyString of string

let (|NonEmptyString|) = function
    | NonEmptyString s -> NonEmptyString s

let create s =
    if String.IsNullOrWhiteSpace s then Error "String must not be empty"
    else Ok(NonEmptyString s)

let get (NonEmptyString nes) = nes
