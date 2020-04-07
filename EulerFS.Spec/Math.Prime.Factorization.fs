namespace EulerFS.Math.Prime

module Factorization =

    let naiveImpl (number) =

        let rec primeFactors (n, div) =
            seq {
                match n with
                | n when n % div = 0UL ->
                    yield div
                    yield! primeFactors ((n / div), div)
                | n when n > div -> yield! primeFactors (n, (div + 1UL))
                | n when n > 1UL -> yield n
                | _ -> ()
            }

        primeFactors (number, 2UL)
