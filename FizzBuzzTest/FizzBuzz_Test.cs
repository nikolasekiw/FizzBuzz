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
        public void TestFuzz()
        {
            jf.regler.Add(4, "Fuzz");
            jf.regler.Add(9, "Jazz");
            jf.regler.Add(36, "JazzFuzz");
            Assert.Equal("Fuzz", jf.SekvensMedSpec(4));
        }
        
        [Fact]
        public void TestJazz()
        {
            jf.regler.Add(4, "Fuzz");
            jf.regler.Add(9, "Jazz");
            jf.regler.Add(36, "JazzFuzz");
            Assert.Equal("Jazz", jf.SekvensMedSpec(9));  
        }

        [Fact]
        public void TestJazzFuzz()
        {
            jf.regler.Add(4, "Fuzz");
            jf.regler.Add(9, "Jazz");
            jf.regler.Add(36, "JazzFuzz");
            Assert.Equal("JazzFuzz", jf.SekvensMedSpec(36));
        }
        
        [Fact]
        public void TestTilfeldigTall14()
        {
            jf.regler.Add(4, "Fuzz");
            jf.regler.Add(9, "Jazz");
            jf.regler.Add(36, "JazzFuzz");
            Assert.Equal("11", jf.SekvensMedSpec(11));
        }
    }
}
