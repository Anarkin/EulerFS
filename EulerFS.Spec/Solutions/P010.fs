namespace EulerFS

[<Problem(010, Answer = 142913828922UL)>]
module ``Summation of primes`` =

  //[<Solver>]
    let impl () =
        2UL + (seq { 3UL .. 2UL .. 2000000UL }
                |> Seq.filter Math.Prime.Tester.naiveImpl
                |> Seq.sum)

    [<Solver>]
    let impl2 () =
        let largestNumber = 2000000
        let sieve = [| for _ in 0 .. largestNumber -> false |]

        let evenNumbers = [|4 .. 2 .. largestNumber|]
        for i in evenNumbers do
            sieve.[i] <- true

        for i in 3 .. 2 .. largestNumber |> float |> sqrt |> int do
            if not sieve.[i] then
                for j in i * i .. i * 2 .. largestNumber do
                    sieve.[j] <- true

        sieve
            |> Array.mapi (fun index b -> (index |> uint64, b))
            |> Array.skip 2
            |> Array.filter (fun (_, b) -> not b)
            |> Array.map (fun (i, _) -> i)
            |> Array.fold (+) 0UL
