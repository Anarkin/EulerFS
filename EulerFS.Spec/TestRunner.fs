namespace EulerFS

open NUnit.Framework

module TestRunner =

    [<Test>]
    [<TestCaseSource(typedefof<TestFactory>, "Get")>]
    let executeSolvers (expected: obj option, solver: unit -> obj) =
        match expected with
        | None -> Assert.Fail(sprintf "suspected answer is %s" (solver().ToString()))
        | Some expected -> Assert.AreEqual(expected, solver())
