using System;
using System.Collections.Generic;

namespace FizzBuzz
{
    public class SpillLogikk
    {
        public IDictionary<int, string> regler = new Dictionary<int, string>();
        
        public String SekvensMedRegler(int nummer)
        {
            string resultat = null;

            foreach (KeyValuePair<int, string> kv in regler)
            {
                if (nummer % kv.Key == 0) resultat += kv.Value;
            }
            return resultat ?? nummer.ToString();
        }

        public void StartSpill(IEnumerable<int> liste)
        {
            foreach (var tall in liste) Console.WriteLine(SekvensMedRegler(tall));
        }
    }
}