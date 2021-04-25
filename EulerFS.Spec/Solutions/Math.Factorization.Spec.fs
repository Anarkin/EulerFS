namespace EulerFS.Math

open NUnit.Framework

module FactorizationSpecs =

    [<Test>]
    [<Timeout(500)>]
    [<TestCase(1UL, [| 1 |])>]

    [<TestCase(2UL, [| 1; 2 |])>]
    [<TestCase(3UL, [| 1; 3 |])>]
    [<TestCase(5UL, [| 1; 5 |])>]
    [<TestCase(7UL, [| 1; 7 |])>]
    [<TestCase(1033UL, [| 1; 1033 |])>]

    [<TestCase(4UL, [| 1; 2; 4 |])>]
    [<TestCase(6UL, [| 1; 2; 3; 6 |])>]
    [<TestCase(8UL, [| 1; 2; 4; 8 |])>]
    [<TestCase(24UL, [|1; 2; 3; 4; 6; 8; 12; 24|])>]
    let ``factorization`` (number, factors) =

        let actualFactors = Factorization.naiveImpl number |> Array.ofSeq |> Array.sort

        Assert.AreEqual(factors, actualFactors)
