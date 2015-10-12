using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringCalculator
{
    [TestFixture]
    [Category("StringCalculator.Nunit")]
    public class StringCalculatorTests
    {
        [TestCase("1,2", Result = 3)]
        public int Add_ShouldReturn_TheSum_OfTwoNumbers(string input)
        {
            StringCalculator stringCalculator = new StringCalculator();
            int result = stringCalculator.Add(input);
            return result;
        }
    }
}
