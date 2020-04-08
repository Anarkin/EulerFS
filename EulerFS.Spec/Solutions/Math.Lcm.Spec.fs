namespace EulerFS.Math

open NUnit.Framework

module LcmSpec =

    [<Test>]
    [<TestCase([|3;6|], 6UL)>]
    [<TestCase([|3;7|], 21UL)>]
    [<TestCase([|10;12;15;75|], 300UL)>]
    [<TestCase([|10;12;15;75;99|], 9900UL)>]
    let ``lowest common multiple`` (numbers, lcm) =
        Assert.AreEqual(lcm, Lcm.naiveImpl (numbers |> Array.map uint64 ))
