using FizzBuzz;
using Xunit;

namespace FizzBuzzTest
{
    public class FizzBuzz_Test
    {
        SpillLogikk spill = new SpillLogikk();

        [Fact]
        public void TestFizz()
        {
            spill.regler.Add(3, "Fizz");
            spill.regler.Add(5, "Buzz");
            Assert.Equal("Fizz", spill.SekvensMedRegler(3));
        }

        [Fact]
        public void TestBuzz()
        {
            spill.regler.Add(3, "Fizz");
            spill.regler.Add(5, "Buzz");
            Assert.Equal("Buzz", spill.SekvensMedRegler(5));
        }
        
        [Fact]
        public void TestFizzBuzz()
        {
            spill.regler.Add(3, "Fizz");
            spill.regler.Add(5, "Buzz");
            Assert.Equal("FizzBuzz", spill.SekvensMedRegler(15));
        }

        [Fact]
        public void TestFuzz()
        {
            spill.regler.Add(4, "Fuzz");
            spill.regler.Add(9, "Jazz");
            Assert.Equal("Fuzz", spill.SekvensMedRegler(4));
        }
        
        [Fact]
        public void TestJazz()
        {
            spill.regler.Add(4, "Fuzz");
            spill.regler.Add(9, "Jazz");
            Assert.Equal("Jazz", spill.SekvensMedRegler(9));  
        }

        [Fact]
        public void TestJazzFuzz()
        {
            spill.regler.Add(9, "Jazz");
            spill.regler.Add(4, "Fuzz");
            Assert.Equal("JazzFuzz", spill.SekvensMedRegler(36));
        }
        
        [Fact]
        public void TestTilfeldigTall14()
        {
            spill.regler.Add(4, "Fuzz");
            spill.regler.Add(9, "Jazz");
            Assert.Equal("11", spill.SekvensMedRegler(11));
        }
    }
}