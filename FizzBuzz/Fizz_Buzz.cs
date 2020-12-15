using System;
using System.Collections.Generic;
using System.Linq;

namespace FizzBuzz
{
    public class Fizz_Buzz : IFizzBuzz
    {
        public static IEnumerable<int> sekvens = Enumerable.Range(1, 100);

        public void StartSpill()
        {
            foreach (var tall in sekvens)
            {
                if (tall % 15 == 0) Console.WriteLine("FizzBuzz");
                else if (tall % 5 == 0) Console.WriteLine("Buzz");
                else if(tall % 3 == 0) Console.WriteLine("Fizz");
                else Console.WriteLine(tall);
            }
        }

        public static string Resultat(int nummer) {  
            string resultat = "";
            for (int i = 1; i < nummer+1; i++) {
                if (i % 3 == 0 && i % 5 ==0) {
                    resultat += "FizzBuzz ";
                } else if (i % 5 ==0 ) {
                    resultat += "Buzz ";
                } else if (i % 3 ==0 ) {
                    resultat += "Fizz ";                  
                }
                else
                    resultat += i+ " ";
            }
            return resultat;
        }
    }
}