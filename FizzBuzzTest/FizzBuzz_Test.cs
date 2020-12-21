using FizzBuzz;
using Xunit;

namespace FizzBuzzTest
{
    public class FizzBuzz_Test
    {
        [Fact]
        public void TestFizz()
        {
            var result = SpillLogikk.SekvensMedRegler(3, Regler.FizzBuzz);

            Assert.Equal("Fizz", result);
        }

        [Fact]
        public void TestBuzz()
        {
            var result = SpillLogikk.SekvensMedRegler(5, Regler.FizzBuzz);

            Assert.Equal("Buzz", result);
        }

        [Fact]
        public void TestFizzBuzz()
        {
            var result = SpillLogikk.SekvensMedRegler(15, Regler.FizzBuzz);

            Assert.Equal("FizzBuzz", result);
        }

        [Fact]
        public void TestFuzz()
        {
            var result = SpillLogikk.SekvensMedRegler(4, Regler.JazzFuzz);

            Assert.Equal("Fuzz", result);
        }

        [Fact]
        public void TestJazz()
        {
            var result = SpillLogikk.SekvensMedRegler(9, Regler.JazzFuzz);

            Assert.Equal("Jazz", result);
        }

        [Fact]
        public void TestJazzFuzz()
        {
            var result = SpillLogikk.SekvensMedRegler(36, Regler.JazzFuzz);

            Assert.Equal("JazzFuzz", result);
        }

        [Fact]
        public void TestTilfeldigTall11()
        {
            var result = SpillLogikk.SekvensMedRegler(11, Regler.JazzFuzz);

            Assert.Equal("11", result);
        }
    }
}