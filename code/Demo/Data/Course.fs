module Data.Course

open Data.NonEmptyString
open Data.SchoolYear

type Course =
    { title : NonEmptyString
      description : NonEmptyString
      inYear : SchoolYear }
