using System.Diagnostics;
using PrimeFactorsLib;

using static System.Console;

namespace PrimeUI
{
    class Program
    {
        static void Main(string[] args)
        {
            var stopWatch = new Stopwatch();
            int number = 900;
            var calc = new PrimeCalculator();
            stopWatch.Start();
            var resultNumberString = calc.PrimeFactorsString(number);
            stopWatch.Stop();
            WriteLine($"{nameof(calc.PrimeFactorsString)} time stamp is " +
            stopWatch.Elapsed +
            " ms");
            stopWatch.Reset();
            stopWatch.Start();
            var resultNumberSB = calc.PrimeFactors(number);
            stopWatch.Stop();
            WriteLine($"{nameof(calc.PrimeFactors)} time stamp is " +
            stopWatch.Elapsed +
            " ms");
            WriteLine($"Result string is {resultNumberString}");
            WriteLine($"Result string builder is {resultNumberSB}");
        }
    }
}
