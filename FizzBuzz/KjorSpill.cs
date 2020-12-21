using System;
using System.Linq;
using System.Runtime.CompilerServices;
using FizzBuzz;
[assembly: InternalsVisibleTo("FizzBuzzTest")]

Enumerable.Range(1, 100).StartSpill(FizzBuzz.Regler.FizzBuzz).Concat(
Enumerable.Range(1, 100).StartSpill(FizzBuzz.Regler.JazzFuzz).Reverse())
.ToList().ForEach(Console.WriteLine);