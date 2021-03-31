using System;
using System.Diagnostics;
using System.Text;

namespace PrimeFactorsLib
{
    public class PrimeCalculator
    {
        public string PrimeFactors(int number)
        {
            if (number > 1000)
            {
                throw new ArgumentException("Bigger of largest number");
            }
            var result = new StringBuilder();
            int division = 2;
            while (number % division != 0)
            {
                ++division;
            }
            if (number == division)
            {
                return division.ToString();
            }
            number /= division;
            result.Append (division);
            return result.Append("*").Append(PrimeFactors(number)).ToString();
        }

        public string PrimeFactorsString(int number)
        {
            if (number > 1000)
            {
                throw new ArgumentException("String exeption");
            }
            int division = 2;
            while (number % division != 0)
            {
                ++division;
            }
            if (number == division)
            {
                return number.ToString();
            }
            number /= division;
            return $"{division}*{PrimeFactorsString(number)}";
        }
    }
}
