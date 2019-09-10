module Demo.Data.ScheduledClass

open Teacher
open Student
open Course
open Weekday
open Time

type ScheduledClass =
    { course : Course
      weekday : Weekday
      startTime : Time
      students : Student list
      teacher: Teacher option }
