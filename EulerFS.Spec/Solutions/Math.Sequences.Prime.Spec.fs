namespace EulerFS.Math.Sequences

open NUnit.Framework
open System

module PrimeSequenceSpecs =

    [<Test>]
    [<TestCase([| 2 |], 2)>]
    [<TestCase([| 2; 3 |], 3)>]
    [<TestCase([| 2; 3; 5; 7; 11 |], 11)>]
    [<TestCase([| 2; 3; 5; 7; 11; 13; 17; 19; 23; 29 |], 29)>]
    [<TestCase([| 2; 3; 5; 7; 11; 13; 17; 19; 23; 29 |], 30)>]
    [<TestCase([| 2; 3; 5; 7; 11; 13; 17; 19; 23 |], 28)>]
    let ``prime sequence`` (expected: int [], top: int) =
        let actual = PrimeSequence.sieve (top) |> Seq.toArray

        Assert.AreEqual(expected, actual)

    [<Test>]
    [<TestCase([| 2; 3; 5; 7; 11; 13; 17; 19; 23; 29 |], 500000)>]
    let ``prime sequence finishes`` (expected: int [], top: int) =
        let actual =
            PrimeSequence.sieve (top)
            |> Seq.take expected.Length
            |> Seq.toArray

        Assert.AreEqual(expected, actual)
