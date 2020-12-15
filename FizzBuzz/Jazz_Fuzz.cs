using System;
using System.Collections.Generic;
using System.Linq;

namespace FizzBuzz
{
    public class Jazz_Fuzz : IFizzBuzz
    {
        public static IDictionary<int, string> regler = new Dictionary<int, string>();
        public static IEnumerable<int> sekvens = Enumerable.Range(1, 100).Reverse();

        public String SekvensMedSpec(int nummer)
        {
            string verdi = "";
            List<string> resultatArray = new List<string>();

            foreach (KeyValuePair<int, string> keyValue in regler)
            {
                if (nummer % keyValue.Key == 0) resultatArray.Add(keyValue.Value);
                else if(!resultatArray.Any()) verdi = nummer.ToString();
            }
            foreach(var resultat in resultatArray) verdi = resultat;
            return verdi;
        }

        public void StartSpill()
        {
            foreach (var tall in sekvens) Console.WriteLine(SekvensMedSpec(tall));
        }
    }
}