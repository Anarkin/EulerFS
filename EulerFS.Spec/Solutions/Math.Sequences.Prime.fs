namespace EulerFS.Math.Sequences

open System.Collections

module PrimeSequence =

    let sieve (top) = seq {

        let sieve = BitArray(top / 2 + 1, false);

        for i in 1 .. ((top |> float |> sqrt |> int) - 1) / 2 do
            if not sieve.[i] then
                for j in 2*i*(i+1) .. 2*i+1 .. top / 2 do
                    sieve.[j] <- true

        yield 2
        for i in 1 .. (top - 1) / 2 do
            if not sieve.[i] then
                yield 2*i+1

    }
