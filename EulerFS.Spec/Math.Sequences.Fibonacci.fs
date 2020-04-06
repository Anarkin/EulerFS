namespace EulerFS.Math.Sequences

module FibonacciSequence =

    let naiveImpl = seq {
        yield! [0UL; 1UL]
        yield! ((0UL, 1UL) |> Seq.unfold (fun (a, b) -> Some (a + b, (b, a + b))))
    }
