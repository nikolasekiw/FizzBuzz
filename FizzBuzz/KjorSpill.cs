namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            var fb = new Fizz_Buzz();
            fb.StartSpill();

            var jf = new Jazz_Fuzz();
            jf.regler.Add(4, "Fuzz");
            jf.regler.Add(9, "Jazz");
            jf.regler.Add(36, "JazzFuzz");
            
            jf.StartSpill();
        }
    }
}
