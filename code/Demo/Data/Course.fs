module Demo.Data.Course

open NonEmptyString
open SchoolYear

type Course =
    { title : NonEmptyString
      description : NonEmptyString
      inYear : SchoolYear }
    
let create title description inYear =
    {
        title = title
        description = description
        inYear = inYear
    }
