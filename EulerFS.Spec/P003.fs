namespace EulerFS

[<Problem(003, Answer = 6857)>]
module ``Largest prime factor`` =

    [<Solver>]
    let impl () =
        let input = 600851475143UL;

        seq { 1UL..(input |> float |> sqrt |> uint64) }
        |> Seq.filter (fun i -> input % i = 0UL) // divisors
        |> Seq.filter (Math.Prime.Tester.naiveImpl)
        |> Seq.last
