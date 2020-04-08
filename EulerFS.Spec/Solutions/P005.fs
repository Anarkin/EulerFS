namespace EulerFS

[<Problem(005, Answer = 232792560)>]
module ``Smallest multiple`` =

  //[<Solver>]
    let impl () =
        seq { 2520 .. 20 .. System.Int32.MaxValue }
        |> Seq.filter (fun i -> not ([| 11 .. 20 |] |> Array.exists (fun i' -> i % i' <> 0)))
        |> Seq.head

    [<Solver>]
    let impl2 () =
        Math.Lcm.naiveImpl [|1UL..20UL|]
