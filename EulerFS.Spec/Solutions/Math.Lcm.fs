namespace EulerFS.Math

module Lcm =

    let naiveImpl (numbers) =
        numbers

        // get factors
        |> Seq.map (fun n ->
            Prime.Factorization.naiveImpl n
            |> Seq.groupBy id
            |> Seq.map (fun (factor, factors) -> (factor, factors |> Seq.length)))

        // keep factors with largest exponent only
        |> Seq.fold (fun (map: Map<uint64, int>) factorsWithExponents ->
            let mutable dict = map

            for (factor, exp) in factorsWithExponents do
                dict <-
                    match dict.TryGetValue factor with
                    | true, e when e < exp -> dict.Add(factor, exp)
                    | false, _ -> dict.Add(factor, exp)
                    | _ -> dict

            dict) Map.empty<uint64, int>

        // multiply it all together
        |> Map.fold (fun acc factor exponent -> acc * (pown factor exponent)) 1UL
