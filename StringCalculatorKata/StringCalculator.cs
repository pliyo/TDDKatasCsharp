using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringCalculator
{
    public class StringCalculator
    {
        public int Add(string input)
        {
            string[] result = input.Split(',');
            List<int> sum = new List<int>();
            foreach(var value in result)
            {
                sum.Add(int.Parse(value));
            }
            return sum.Sum();
        }
    }
}
