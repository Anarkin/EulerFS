namespace EulerFS

[<Problem(012, Answer=76576500)>]
module ``Highly divisible triangular number`` =

    [<Solver>]
    let impl () =

        let triangleNumbers =
            Seq.unfold
                (fun (prev, n) -> Some(prev, (prev+n, n+1UL))) // tn = tn-1 + n
                (0UL, 1UL)
            |> Seq.skip 1

        triangleNumbers
            |> Seq.find (fun n -> Seq.length(Math.Factorization.naiveImpl n) > 500)
