using FizzBuzz;
using Xunit;

namespace FizzBuzzTest
{
    public class FizzBuzz_Test
    {
        Jazz_Fuzz jf = new Jazz_Fuzz();

        [Fact]
        public void TestFizz()
        {
            var forventetResultat = "1 2 Fizz ";
            string resultat = Fizz_Buzz.Resultat(3);
            Assert.Equal(forventetResultat, resultat);
        }

        [Fact]
        public void TestBuzz()
        {
            var forventetResultat = "1 2 Fizz 4 Buzz ";
            string resultat = Fizz_Buzz.Resultat(5);
            Assert.Equal(forventetResultat, resultat);
        }
        
        [Fact]
        public void TestFizzBuzz()
        {
            var forventetResultat = "1 2 Fizz 4 Buzz Fizz 7 8 Fizz Buzz 11 Fizz 13 14 FizzBuzz ";
            string resultat = Fizz_Buzz.Resultat(15);
            Assert.Equal(forventetResultat, resultat);
        }
        
        [Fact]
        public void TestJazz()
        {
            Assert.Equal("Jazz", jf.SekvensMedSpec(4));
            Assert.Equal("Jazz", jf.SekvensMedSpec(8));
        }
        
        [Fact]
        public void TestFuzz()
        {
            Assert.Equal("Fuzz", jf.SekvensMedSpec(9));  
            Assert.Equal("Fuzz", jf.SekvensMedSpec(18));
        }

        [Fact]
        public void TestJazzFuzz()
        {
            Assert.Equal("JazzFuzz", jf.SekvensMedSpec(36));
            Assert.Equal("JazzFuzz", jf.SekvensMedSpec(72));
        }
        
        [Fact]
        public void TestTilfeldigTall14()
        {
            Assert.Equal("11", jf.SekvensMedSpec(11));
            Assert.Equal("98", jf.SekvensMedSpec(98));
        }
    }
}
