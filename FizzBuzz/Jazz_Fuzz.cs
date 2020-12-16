using System;
using System.Collections.Generic;
using System.Linq;

namespace FizzBuzz
{
    public class Jazz_Fuzz : IFizzBuzz
    {
        public IDictionary<int, string> regler = new Dictionary<int, string>();
        public static IEnumerable<int> sekvens = Enumerable.Range(1, 100).Reverse();

        public String SekvensMedSpec(int nummer)
        {
            string resultat = "";
            List<string> resultatArray = new List<string>();

            foreach (KeyValuePair<int, string> keyValue in regler)
            {
                if (nummer % keyValue.Key == 0) resultatArray.Add(keyValue.Value);
                else if(!resultatArray.Any()) resultat = nummer.ToString();
            }
            foreach(var verdi in resultatArray) resultat = verdi;
            return resultat;
        }

        public void StartSpill()
        {
            foreach (var tall in sekvens) Console.WriteLine(SekvensMedSpec(tall));
        }
    }
}