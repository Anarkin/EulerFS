namespace EulerFS.Math.Sequences

open System.Collections

module PrimeSequence =

    let sieve (top) = seq {

     // let sieve = [| for _ in 0 .. top -> false |]
        let sieve = BitArray(top + 1, false);

        let evenNumbers = [|4 .. 2 .. top|]
        for i in evenNumbers do
            sieve.[i] <- true

        yield 2
        let mutable largest = 2

        for i in 3 .. 2 .. top |> float |> sqrt |> int do
            if not sieve.[i] then
                yield i
                largest <- i

                for j in i * i .. i * 2 .. top do
                    sieve.[j] <- true

        for i in largest+1 .. top do
            if not sieve.[i] then
                yield i

    }
