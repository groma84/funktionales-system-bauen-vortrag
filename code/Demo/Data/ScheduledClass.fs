module Data.ScheduledClass

open Data.Teacher
open Data.Student
open Data.Course
open Data.Weekday
open Data.Time

type ScheduledClass =
    { teacher : Teacher
      enrolledStudents : Student list
      course : Course
      weekday : Weekday
      startTime : Time }
