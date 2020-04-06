namespace EulerFS

[<Problem(009, Answer = 31875000)>]
module ``Special Pythagorean triplet`` =

    [<Solver>]
    let impl () =
        let sumOfSides = 1000

        seq {
            for a in seq { 1 .. sumOfSides / 3 } do // one of the sides must be <= sum/3
                for b in seq { a .. sumOfSides / 2 } do // the other side must be <= sum/2
                    let c = sumOfSides - (a + b)

                    if a * a + b * b = c * c then yield a * b * c
        }
        |> Seq.head
