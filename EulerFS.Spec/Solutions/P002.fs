namespace EulerFS

[<Problem(002, Answer = 4613732)>]
module ``Even Fibonacci numbers`` =

    [<Solver>]
    let impl () =
        Math.Sequences.FibonacciSequence.naiveImpl
        |> Seq.takeWhile (fun i -> i < 4000000UL)
        |> Seq.filter (fun i -> i % 2UL = 0UL)
        |> Seq.sum
