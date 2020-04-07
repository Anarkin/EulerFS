namespace EulerFS.Math

module Lcm = // lowest common multiple

    let naiveImpl (numbers) =
        numbers

        // get factors
        |> Seq.map (fun i -> Prime.Factorization.naiveImpl i |> Seq.groupBy (fun prime -> prime))

        // merge: keep factors with largest exponent only
        |> Seq.fold (fun (acc: Map<uint64, int>) factorsWithExponents ->
            let mutable result = acc
            for (factor, exps) in factorsWithExponents do
                let exp = exps |> Seq.length
                if result.ContainsKey(factor) then
                    if result.[factor] < exp then
                        result <- result.Add(factor, exp)
                else
                    result <- result.Add(factor, exp)
            result) Map.empty<uint64, int>

        // multiply it all together
        |> Map.fold (fun acc factor exponent ->
            let exp = int32 exponent
            acc * (pown factor exp)
        ) 1UL
