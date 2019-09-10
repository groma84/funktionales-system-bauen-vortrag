module Demo.Data.Student

open Name
open SchoolYear
open House

type Student =
    { name : Name
      year : SchoolYear
      house : House }
