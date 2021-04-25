namespace EulerFS.Math

module Factorization =

    let naiveImpl (n) =

        seq {
            for i in 1UL..(n |> float |> sqrt |> uint64) do
                if n % i = 0UL then
                    yield i
                    if i <> n / i then yield n / i
        }
