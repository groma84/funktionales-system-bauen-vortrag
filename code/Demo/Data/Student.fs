module Data.Student

open Data.Name
open Data.SchoolYear
open Data.House

type Student =
    { name : Name
      year : SchoolYear
      house : House }
