namespace EulerFS.Math.Sequences

open NUnit.Framework

module FibonacciSequenceSpecs =

    [<Test>]
    [<TestCase([| 0; 1; 1; 2; 3; 5; 8; 13; 21 |])>]
    let ``fibonacci sequence`` (expected: int []) =
        let actual =
            FibonacciSequence.naiveImpl
            |> Seq.take expected.Length
            |> Seq.toArray
        Assert.AreEqual(expected, actual)

    [<Test>]
    [<TestCase(6, 8)>]
    [<TestCase(42, 267914296)>]
    [<TestCase(69, 117669030460994L)>]
    let ``fibonacci sequence random access`` (index, expected) =
        let actual =
            FibonacciSequence.naiveImpl
            |> Seq.skip index
            |> Seq.head
        Assert.AreEqual(expected, actual)
