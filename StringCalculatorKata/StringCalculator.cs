using System.Collections.Generic;
using System.Linq;

namespace StringCalculator
{
    public class StringCalculator
    {
        private const string delimiter = ",";
        public int Add(string rawInput)
        {
            string cleanInput = rawInput.Replace("\n", delimiter);
            string[] items = cleanInput.Split(',');

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
