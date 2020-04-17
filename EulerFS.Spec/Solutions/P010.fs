namespace EulerFS

[<Problem(010, Answer = 142913828922UL)>]
module ``Summation of primes`` =

    [<Solver>]
    let impl() =
        2UL + (seq { 3UL .. 2UL .. 2000000UL }
        |> Seq.filter Math.Prime.Tester.naiveImpl
        |> Seq.sum)
