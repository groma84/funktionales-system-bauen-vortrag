module Data.Hogwarts

open System.Collections.Generic

open Data.Student
open Data.ScheduledClass
open Data.Course
open Data.Teacher
open Data.Year

type ScheduledClasses = Dictionary<ScheduledClass, Teacher>

type Hogwarts =
    {
        currentYear: Year
        students: Student list
        courses: Course list
        teachers: Teacher list
        scheduledClasses: ScheduledClasses
    }
