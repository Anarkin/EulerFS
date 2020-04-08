namespace EulerFS

open System

[<AttributeUsage(AttributeTargets.Class)>]
type ProblemAttribute(number) =
    inherit Attribute()

    member this.Number: int = number
    member val Answer: obj = null with get, set

[<AttributeUsage(AttributeTargets.Method)>]
type SolverAttribute() =
    inherit Attribute()
