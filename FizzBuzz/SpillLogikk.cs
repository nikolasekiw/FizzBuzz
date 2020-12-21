using System.Collections.Generic;
using System.Linq;

namespace FizzBuzz
{
    public static class SpillLogikk
    {
        internal static string SekvensMedRegler(int nummer, (int Divident, string Navn)[] regler)
            => string.Join("", regler.Where(regel => nummer % regel.Divident == 0)
                        .Select(regel => regel.Navn)
                        .DefaultIfEmpty(nummer.ToString()));

        public static IEnumerable<string> StartSpill(this IEnumerable<int> liste, (int, string)[] regler)
            => liste.Select(tall => SekvensMedRegler(tall, regler));
    }
}