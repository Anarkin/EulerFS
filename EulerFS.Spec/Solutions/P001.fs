namespace EulerFS

[<Problem(001, Answer = 233168)>]
module ``Multiples of 3 and 5`` =

    [<Solver>]
    let impl () =
        seq { 3 .. 999 }
        |> Seq.filter (fun i -> i % 3 = 0 || i % 5 = 0)
        |> Seq.sum

    [<Solver>]
    let impl2 () =
        seq { 3 .. 999 }
        |> Seq.fold (fun acc current ->
            match current with
            | i when i % 3 = 0 || i % 5 = 0 -> acc + i
            | _ -> acc) 0
