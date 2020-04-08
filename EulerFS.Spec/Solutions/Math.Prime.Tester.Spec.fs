namespace EulerFS.Math.Prime

open NUnit.Framework

module TesterSpec =

    [<Test>]
    [<TestCase(0UL, false)>]
    [<TestCase(1UL, false)>]
    [<TestCase(2UL, true)>]
    [<TestCase(4UL, false)>]
    [<TestCase(997UL, true)>]
    let ``prime test`` (number, isPrime) =
        Assert.AreEqual(isPrime, Tester.naiveImpl number)

    [<Test>]
    [<Timeout(500)>]
    [<TestCase(77777677777UL, true)>]
    [<TestCase(77777677778UL, false)>]
    let ``prime test within time`` (number, isPrime) =
        Assert.AreEqual(isPrime, Tester.naiveImpl number)
