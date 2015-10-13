using System;
using System.Collections.Generic;
using System.Linq;

namespace StringCalculator
{
    public class StringCalculator
    {
        private string delimiter = ",";
        private const string beginDelimiter = "\\";
        public int Add(string rawInput)
        {
            if (string.IsNullOrEmpty(rawInput)) return 0;

            string verifyDelimiter = rawInput.Substring(0, 1);
            if(verifyDelimiter == beginDelimiter)
            {
                delimiter = rawInput[1].ToString();
                rawInput = rawInput.Replace(beginDelimiter, delimiter);
            }
         
            string cleanInput = rawInput.Replace("\n", delimiter);
            string[] items = cleanInput.Split(delimiter.ToCharArray());

            List<int> sum = new List<int>();

            foreach(var value in items)
            {
                int parsedValue = 0;
                int.TryParse(value, out parsedValue);
                if (parsedValue < 0)
                    throw new ArgumentException("Can't handle negative numbers");
                sum.Add(parsedValue);
            }

            return sum.Sum();

        }
    }
}
