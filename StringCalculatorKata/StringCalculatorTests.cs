using NUnit.Framework;

namespace StringCalculator
{
    [TestFixture]
    [Category("StringCalculator.Nunit")]
    public class StringCalculatorTests
    {
        [TestCase("", Result = 0)]
        public int Add_ShouldReturn_Zero_WhenStringIsEmpty(string input)
        {
            StringCalculator stringCalculator = new StringCalculator();
            int result = stringCalculator.Add(input);
            return result;
        }

        [TestCase("1,2", Result = 3)]
        public int Add_ShouldReturn_TheSum_OfTwoNumbers(string input)
        {
            StringCalculator stringCalculator = new StringCalculator();
            int result = stringCalculator.Add(input);
            return result;
        }


    }
}
