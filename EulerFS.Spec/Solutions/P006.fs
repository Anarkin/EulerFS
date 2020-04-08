namespace EulerFS

[<Problem(006, Answer = 25164150)>]
module ``Sum square difference`` =

    [<Solver>]
    let impl () =
        let (sumOfSquares, sum) =
            seq { 1 .. 100 }
            |> Seq.fold (fun (sumOfSquares, sum) current -> (sumOfSquares + current * current, sum + current)) (0, 0)

        sum * sum - sumOfSquares
