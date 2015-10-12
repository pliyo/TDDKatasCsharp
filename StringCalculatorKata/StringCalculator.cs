using System.Collections.Generic;
using System.Linq;

namespace StringCalculator
{
    public class StringCalculator
    {
        public int Add(string input)
        {
            string[] items = input.Split(',');
            List<int> sum = new List<int>();

            foreach(var value in items)
            {
                int parsedValue = 0;
                int.TryParse(value, out parsedValue);
                sum.Add(parsedValue);
            }

            return sum.Sum();
        }
    }
}
