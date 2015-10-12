using NUnit.Framework;
using System.Linq;

namespace FizzBuzzKata.NUnit
{
    [TestFixture]
    [Category("FizzBazz.Nunit")]
    public class FizzBuzzTests
    {
        [Test]
        public void GetFizz_Return_Fizz_SplittedByCommas()
        {
            FizzBuzz fizzBuzz = new FizzBuzz();
            string[] test = fizzBuzz.GetFizz();
            string fizzString = fizzBuzz.Fizz();
            string[] expectedResult = fizzString.Split(',');
            bool isEqual = Enumerable.SequenceEqual(test, expectedResult);
            Assert.AreEqual(true, isEqual);
        }

        [TestCase(0, Result = "1")] 
        [TestCase(1, Result = "2")]
        public string Fizz_Return_A_String_OfIntegers(int position)
        {
            FizzBuzz fizzBuzz = new FizzBuzz();
            string[] fullString = fizzBuzz.GetFizz();
            string result = fullString[position].ToString();
            return result;
        }

        [TestCase(2, Result ="Fizz")]
        public string Fizz_Return_Fizz_When_AnyInteger_Is_Divisible_ByThreee(int position)
        {
            FizzBuzz fizzBuzz = new FizzBuzz();
            string[] fullString = fizzBuzz.GetFizz();
            string result = fullString[position].ToString();
            return result;
        }

        [TestCase(4, Result = "Buzz")]
        [TestCase(19, Result ="Buzz")]
        public string Fizz_Return_FizzBuzz_When_AnyInteger_Is_Divisible_Five(int position)
        {
            FizzBuzz fizzBuzz = new FizzBuzz();
            string[] fullString = fizzBuzz.GetFizz();
            string result = fullString[position].ToString();
            return result;
        }
    }
}
