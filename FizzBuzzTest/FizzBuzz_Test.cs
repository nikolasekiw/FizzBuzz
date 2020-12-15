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
            bool resultat = jf.SekvensMedSpec(4).Equals("Jazz");
            Assert.True(resultat);
        }
        
        [Fact]
        public void TestFuzz()
        {
            string resultat = jf.SekvensMedSpec(9);
            Assert.Equal("Fuzz", resultat);  
        }

        [Fact]
        public void TestJazzFuzz()
        {
            string resultat = jf.SekvensMedSpec(36);
            Assert.Equal("JazzFuzz", resultat);
        }
        
        [Fact]
        public void TestTilfeldigTall14()
        {
            string resultat = jf.SekvensMedSpec(11);
            Assert.Equal("11", resultat);
        }
    }
}
