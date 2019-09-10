module Demo.Data.Name

open NonEmptyString

type Name =
    { firstName : NonEmptyString
      lastName : NonEmptyString }

let create firstName lastName =
    {
     firstName = firstName
     lastName = lastName
     }