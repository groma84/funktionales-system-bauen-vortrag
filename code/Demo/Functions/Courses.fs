module Demo.Functions.Courses

open Demo.Data.ScheduledClass
open Demo.Data.Student

type Enroll = Student -> ScheduledClass -> ScheduledClass

let enroll : Enroll =
    fun student scheduledClass ->
        { scheduledClass with students = student :: scheduledClass.students }
