module Data.Student

open Data.Name
open Data.Year
open Data.House

type Student =
    { name : Name
      year : Year
      house : House }
