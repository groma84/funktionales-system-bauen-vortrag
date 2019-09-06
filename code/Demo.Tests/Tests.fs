module Tests

open System
open Xunit
open Swensen.Unquote
open Demo

[<Fact>]
let ``My test``() = test <@ Say.add 3 4 = 7 @>
