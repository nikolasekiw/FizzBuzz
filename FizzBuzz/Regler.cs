namespace FizzBuzz
{
    public record Regler
    {
        public static (int Divident, string Navn)[] FizzBuzz => new[] { (3, "Fizz"), (5, "Buzz") };
        public static (int Divident, string Navn)[] JazzFuzz => new[] { (9, "Jazz"), (4, "Fuzz") };
    }
}