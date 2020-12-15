

using System;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            var fb = new Fizz_Buzz();
            fb.StartSpill();

            Jazz_Fuzz.regler.Add(4, "Jazz");
            Jazz_Fuzz.regler.Add(9, "Fuzz");
            Jazz_Fuzz.regler.Add(36, "JazzFuzz");
            
            var jf = new Jazz_Fuzz();
            jf.StartSpill();
        }
    }
}
