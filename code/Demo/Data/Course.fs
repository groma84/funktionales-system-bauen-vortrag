module Data.Course

open Data.NonEmptyString

type Course =
    { title : NonEmptyString
      description : NonEmptyString }
