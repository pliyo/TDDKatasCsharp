namespace FizzBuzzKata.NUnit
{
    public class FizzBuzz
    {
        private const int LENGTH = 100;

        public string Fizz()
        {
            string fizzBuzz = string.Empty;
            for (int i = 1; i <= LENGTH; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    fizzBuzz += "FizzBuzz";
                }
                else if (i % 3 == 0)
                {
                    fizzBuzz += "Fizz";
                }
                else if (i % 5 == 0)
                {
                    fizzBuzz += "Buzz";
                }
                else
                {
                    fizzBuzz += i.ToString();
                }

                fizzBuzz += ",";
            }

            return fizzBuzz;
        }

        public string[] GetFizz()
        {
            return Fizz().Split(',');
        }
    }
}
