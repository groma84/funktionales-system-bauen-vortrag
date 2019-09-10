module Demo.Tests.Functions.CoursesTests

open FSharpPlus
open Xunit
open Swensen.Unquote
open Demo.Data
open Demo.Functions

let course () =
    Course.create
    <!> NonEmptyString.create "Defense Against the Dark Arts I"
    <*> NonEmptyString.create "Basic lessons to identify the Dark Arts and how to deal with them"
    <*> Ok SchoolYear.FirstYear
    
let time () =
    Time.create 0 0 0

let name () =
    Name.create
    <!> NonEmptyString.create "Harry"
    <*> NonEmptyString.create "Potter"

let buildAndRun testFn =
    match (course (), time (), name ()) with
    | (Ok course', Ok time', Ok name') -> 
        let (student : Student.Student) = {
            name = name'
            year = SchoolYear.FirstYear
            house = House.Gryffindor
        }
        
        testFn course' time' student

    | _ -> Xunit.Assert.False true


[<Fact>]
let ``An empty ScheduledClass gets its first student``() =
    let testFn course time student =
        let sc : ScheduledClass.ScheduledClass = {
            course = course
            weekday = Weekday.Monday
            startTime = time
            students = []
            teacher = None
        }
        
        test <@ (Courses.enroll student sc).students  = [student] @>
    
    buildAndRun testFn
            
[<Fact>]
let ``A ScheduledClass with a student gets another student`` () =
    let testFn course time student =
        let sc : ScheduledClass.ScheduledClass = {
            course = course
            weekday = Weekday.Monday
            startTime = time
            students = [student]
            teacher = None
        }
        
        test <@ (Courses.enroll student sc).students  = [student; student] @>
    
    buildAndRun testFn
