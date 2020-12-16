using System.Collections.Generic;
using System.Linq;

namespace FizzBuzz
{
    class Program
    {
        public static IEnumerable<int> sekvens = Enumerable.Range(1, 100);
        public static IEnumerable<int> sekvensBaklengs = Enumerable.Range(1, 100).Reverse();

        static void Main(string[] args)
        {
            var fizz_buzz = new SpillLogikk();
            fizz_buzz.regler.Add(3, "Fizz");
            fizz_buzz.regler.Add(5, "Buzz");
            fizz_buzz.StartSpill(sekvens);
            
            var jazz_fuzz = new SpillLogikk();
            jazz_fuzz.regler.Add(4, "Fuzz");
            jazz_fuzz.regler.Add(9, "Jazz");
            jazz_fuzz.StartSpill(sekvensBaklengs);
        }
    }
}
