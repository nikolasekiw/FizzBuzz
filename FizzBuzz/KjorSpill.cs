namespace FizzBuzz
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var fb = new Fizz_Buzz();
            fb.StartSpill();

            var jf = new Jazz_Fuzz();
jf.regler.Add(4, "Fuzz");
jf.regler.Add(9, "Jazz");
jf.regler.Add(36, "JazzFuzz");
            //Denne kombinasjonsregelen vil jeg at du fjerner ved å skrive om koden din
            //De varslede fremtidige endringene kan f.eks være utvidelse av spillet med to nye regler slik:
            //2-Foo, 4-Fuzz, 9-Jazz, 11-Bar
            //I det eksemplet blir det en veldig manuell og kjedelig jobb for et menneske å
            //lage alle de 14 nye kombinasjonsreglene. Et slikt sceanrio er også skjørt og utsatt for menneskelig feil.
            //Man kan også argumentere for at kombimasjoneregler er DRY/WET violation fordi du repeterer noe du allerede har gjort før.
            //Dersom verdien for Fuzz skal endres til f.eks 5, av en annen utvikler enn deg, er det en mulighet 36-FizzBuzz feilaktig forblir stående urørt.


            jf.StartSpill();
        }
    }
}