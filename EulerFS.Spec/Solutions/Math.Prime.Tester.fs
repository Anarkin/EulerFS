namespace EulerFS.Math.Prime

module Tester =

    let naiveImpl (number) =
        match number with
        | i when i < 2UL -> false
        | i ->
            seq { 2UL .. (i |> float |> sqrt |> uint64) }
            |> Seq.exists (fun candidate -> i % candidate = 0UL) // divisors
            |> not
