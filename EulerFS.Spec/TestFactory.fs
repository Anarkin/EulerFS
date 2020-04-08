namespace EulerFS

open System
open NUnit.Framework

type TestFactory() =

    static member Get =
        AppDomain.CurrentDomain.GetAssemblies()
        |> Seq.collect (fun assembly -> assembly.GetTypes())
        |> Seq.filter (fun t -> t.GetCustomAttributes(typedefof<ProblemAttribute>, false).Length > 0)
        |> Seq.collect (fun t ->
            let meta = t.GetCustomAttributes(typedefof<ProblemAttribute>, false).[0] :?> ProblemAttribute

            t.GetMethods()
            |> Seq.filter
                (fun methodInfo -> methodInfo.GetCustomAttributes(typedefof<SolverAttribute>, false).Length > 0)
            |> Seq.map (fun methodInfo ->
                let expected =
                    match meta.Answer with
                    | null -> None
                    | v -> Some(v)

                let testCaseName =
                    match expected with
                    | None -> sprintf "%03d - '%s' [%s()]" meta.Number t.Name methodInfo.Name
                    | Some actual -> sprintf "%03d - '%s' → Answer: %O [%s()]" meta.Number t.Name actual methodInfo.Name

                let solver = fun () -> t.GetMethod(methodInfo.Name).Invoke(null, null)

                TestCaseData(expected, solver).SetName(testCaseName)))
