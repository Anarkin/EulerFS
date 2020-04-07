# EulerFS

[PE](https://projecteuler.net) in F# — a sandbox for learning Computer Science, Mathematics, and F#. Originally implemented in 2015, refreshed for 2020.

[![Build status](https://ci.appveyor.com/api/projects/status/ebw354095sckl362?svg=true)](https://ci.appveyor.com/project/Anarkin/eulerfs)

## How to work on a problem

- Sketch a problem statement along with a solver:

```f#
[<Problem(9)>]
module ``Special Pythagorean triplet`` =

    [<Solver>]
    let myFirstNaiveImpl () =
        42
```

- The environment will assist you:

```powershell
> dotnet test -v=normal
```

```
  ❌ 009 - 'Special Pythagorean triplet' [impl()] [<1ms]
  ----> NUnit.Framework.InconclusiveException : suspected answer is 42

  ✅ 008 - 'Largest product in a series' → Answer: 23514624000 [impl()] [12ms]
  ✅ 007 - '10001st prime' → Answer: 104743 [impl()] [69ms]
  ✅ 006 - 'Sum square difference' → Answer: 25164150 [impl()] [1ms]
  ✅ 004 - 'Largest palindrome product' → Answer: 906609 [impl()] [20ms]
  ✅ 003 - 'Largest prime factor' → Answer: 6857 [impl()] [13ms]
  ✅ 002 - 'Even Fibonacci numbers' → Answer: 4613732 [impl()] [4ms]
  ✅ 001 - 'Multiples of 3 and 5' → Answer: 233168 [impl()] [< 1ms]
  ✅ 001 - 'Multiples of 3 and 5' → Answer: 233168 [impl2()] [< 1ms]
  ✅ (...)
```

- Once you have an officially accepted solution (by the website), record it,

```f#
[<Problem(9, Answer = 31875000)>]
           ^^^^^^^^^^^^^^^^^^^

module (...)
```

- and you are safe to spend your night refactoring or trying to find a more mathematical solution:

```
  ✅ 009 - 'Special Pythagorean triplet' → Answer: 31875000 [impl()] [28ms]
```

## The challenges

- Can be found [here](https://projecteuler.net/archives) after logging in

## Next steps

1. [F# for fun and profit](https://fsharpforfunandprofit.com) ;)
2. Note that PE's problems are about more than "leetcoding" your way forward: you can find mathematical answers as well for most—if not all—solutions, often in O(1) time
