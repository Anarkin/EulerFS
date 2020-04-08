namespace EulerFS.Math.Prime

open NUnit.Framework

module FactorizationSpecs =

    [<Test>]
    [<TestCase(2UL, [| 2 |])>]
    [<TestCase(3UL, [| 3 |])>]
    [<TestCase(4UL, [| 2; 2 |])>]
    [<TestCase(5UL, [| 5 |])>]
    [<TestCase(6UL, [| 2; 3 |])>]
    [<TestCase(7UL, [| 7 |])>]
    [<TestCase(8UL, [| 2; 2; 2 |])>]
    [<TestCase(9UL, [| 3; 3 |])>]
    [<TestCase(10UL, [| 2; 5 |])>]
    [<TestCase(360UL, [| 2; 2; 2; 3; 3; 5 |])>]
    [<TestCase(2020UL, [| 2; 2; 5; 101 |])>]
    let ``factorization`` (number, factors) =

        let actualFactors = Factorization.naiveImpl number |> Array.ofSeq

        Assert.AreEqual(factors, actualFactors)
