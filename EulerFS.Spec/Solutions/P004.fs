namespace EulerFS

[<Problem(004, Answer = 906609)>]
module ``Largest palindrome product`` =

    // abccba = 100000a + 10000b + 1000c + 100c + 10b + a = 100001a + 10010b + 1100c = 11(9091a + 910b + 100c)

    [<Solver>]
    let impl () =
        seq { 100 .. 999 }
        |> Seq.collect (fun i -> seq { 99 .. 11 .. 999 } |> Seq.map (fun i' -> i * i'))
        |> Seq.filter (fun i -> i.ToString() = System.String(i.ToString().ToCharArray() |> Array.rev))
        |> Seq.max
