namespace EulerFS

[<Problem(007, Answer = 104743)>]
module ``10001st prime`` =

    [<Solver>]
    let impl () =
        seq { 1UL .. System.UInt64.MaxValue }
        |> Seq.filter (Math.Prime.Tester.naiveImpl)
        |> Seq.take 10001
        |> Seq.last
