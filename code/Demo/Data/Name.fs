module Data.Name

open Data.NonEmptyString

type Name =
    { firstName : NonEmptyString
      lastName : NonEmptyString }
