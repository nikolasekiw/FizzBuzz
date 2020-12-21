namespace FizzBuzz
{
    public record Regler
    {
        public static (int, string)[] FizzBuzz => new[] { (3, "Fizz"), (5, "Buzz") };
        public static (int, string)[] JazzFuzz => new[] { (9, "Jazz"), (4, "Fuzz") };
    }
}