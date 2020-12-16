using System;
using System.Collections.Generic;
using System.Linq;

namespace FizzBuzz
{
    public class Jazz_Fuzz : IFizzBuzz
    {
        public IDictionary<int, string> regler = new Dictionary<int, string>();
        public static IEnumerable<int> sekvens = Enumerable.Range(1, 100).Reverse();

        //N� har du l�st de 2 spillene som har veldig lik funksjonalitet med 2 forskjellige metoder.
        //Klarer du � konsollidere slik at samme spillmotor kan benyttes for begge spill?
        public String SekvensMedRegler(int nummer)
        {
            string resultat = "";
            List<string> resultatArray = new List<string>();

            foreach (KeyValuePair<int, string> keyValue in regler)
            {
                if (nummer % keyValue.Key == 0) resultatArray.Add(keyValue.Value);
                else if(!resultatArray.Any()) resultat = nummer.ToString();
            }

            //Slik som du har l�st oppgaven med kombinasjonerglen 36, "JazzFuzz" fremst�r denne l�kken noe merkelig.
            //N�r nummer er 36 vil arrayet inneholde: Fizz, Buzz og JazzFuzz
            //N�r nummer er 4 vil arrayet inneholde: Fizz
            //N�r nummer er 9 vil arrayet inneholde: Buzz
            //Jeg ser derfor ikke behov for � iterere over alle verdiene n�r du bare er interessert den siste.
            //Den kunne man ha l�st med resultatArray.LastOrDefault()
            //Hovedpoenget er at det er litt uryddig � fylle opp et array med verdier du ikke benytter.
            //Trolig blir dette annerledes dersom du klarer � kode deg vekk fra bruk av kombinasjonsregler.
            foreach (var verdi in resultatArray) resultat = verdi;
            return resultat;
        }

        //Hva mener du om at metoden returnerer et resultatsett og overlater presentasjon(Console.WriteLine) til kallende kode?
        public void StartSpill()
        {
            foreach (var tall in sekvens) Console.WriteLine(SekvensMedRegler(tall));
        }
    }
}