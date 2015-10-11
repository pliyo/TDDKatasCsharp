using NUnit.Framework;
using System.Linq;


/// <summary>
/// To visualize NUnit tests in Test Explorer you'll need NUnit Adapter
/// install-package nunittestadapter
/// 
/// Write some code that will generate a string of integers, starting at 1 and going up to 100,
/// all separated by commas.
/// Substitute any integer which is divisible by 3 with “Fizz”,
/// and any integer which is divisible by 5 with “Buzz”,
/// and any integer divisible by 3 and 5 with “FizzBuzz
/// 
/// EX:
/// 1,2,Fizz,4,Buzz,Fizz,7,8,Fizz,Buzz,11,Fizz,13,14,FizzBuzz
/// 
/// </summary>
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
        public string Fizz_Return_FizzBuzz_When_AnyInteger_Is_Divisible_Five(int position)
        {
            FizzBuzz fizzBuzz = new FizzBuzz();
            string[] fullString = fizzBuzz.GetFizz();
            string result = fullString[position].ToString();
            return result;
        }

        [TestCase(14, Result = "FizzBuzz")]
        public string Fizz_Return_FizzBuzz_When_AnyInteger_Is_Divisible_ByThreee_And_Five(int position)
        {
            FizzBuzz fizzBuzz = new FizzBuzz();
            string[] fullString = fizzBuzz.GetFizz();
            string result = fullString[position].ToString();
            return result;
        }
    }
}
