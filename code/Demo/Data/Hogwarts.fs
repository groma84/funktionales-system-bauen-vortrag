module Demo.Data.Hogwarts

open System.Collections.Generic

open Demo.Data.ScheduledClass
open Demo.Data.Teacher
open Demo.Data.Year
open Demo.Data.Student
open Demo.Data.Course

type ScheduledClasses = Dictionary<ScheduledClass, Teacher>

type Hogwarts =
    {
        currentYear: Year
        students: Student list
        courses: Course list
        teachers: Teacher list
        scheduledClasses: ScheduledClasses
    }
