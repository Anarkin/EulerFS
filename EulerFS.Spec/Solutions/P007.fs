namespace EulerFS
open System

[<Problem(007, Answer = 104743)>]
module ``10001st prime`` =

  //[<Solver>]
    let impl () =
        seq { 1UL .. UInt64.MaxValue }
        |> Seq.filter (Math.Prime.Tester.naiveImpl)
        |> Seq.take 10001
        |> Seq.last

    [<Solver>]
    let impl2 () =
        Math.Sequences.PrimeSequence.sieve 250000
        |> Seq.take 10001
        |> Seq.last
