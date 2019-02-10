using System.Collections.Generic;
using System.Linq;
using static Common.Utilities;
using static System.Console;

namespace Problem47
{
    // ReSharper disable once ClassNeverInstantiated.Global
    public class Program
    {
        public static void Main()
        {
            WriteLine("Problem 47");

            long answer = Solve();
            WriteLine($"answer = {answer}");

            WriteLine("Done");
            ReadKey();
        }

        public static long Solve()
        {
            const int upperBound = 1000000;
            long number1 = 0;

            for (long n = 1; n < upperBound; n++)
            {
                number1 = n;
                long number2 = n + 1;
                long number3 = n + 2;
                long number4 = n + 3;

                IEnumerable<long> primeFactors1 = GetPrimeFactors(number1);
                IEnumerable<long> primeFactors2 = GetPrimeFactors(number2);
                IEnumerable<long> primeFactors3 = GetPrimeFactors(number3);
                IEnumerable<long> primeFactors4 = GetPrimeFactors(number4);

                bool allHaveDistinctPrimeFactors =
                    primeFactors1.Distinct().Count() == 4 &&
                    primeFactors2.Distinct().Count() == 4 &&
                    primeFactors3.Distinct().Count() == 4 &&
                    primeFactors4.Distinct().Count() == 4;

                // ReSharper disable once InvertIf
                if (allHaveDistinctPrimeFactors)
                {
                    WriteLine($"number1 = {number1} = {ToString(primeFactors1)}");
                    WriteLine($"number2 = {number2} = {ToString(primeFactors2)}");
                    WriteLine($"number3 = {number3} = {ToString(primeFactors3)}");
                    WriteLine($"number4 = {number4} = {ToString(primeFactors4)}");

                    break;
                }
            }

            return number1;
        }

        private static string ToString(IEnumerable<long> primeFactors)
        {
            string primeFactorsString = "";

            // ReSharper disable once LoopCanBeConvertedToQuery
            foreach (long primeFactor in primeFactors)
            {
                primeFactorsString += $"{primeFactor}x";
            }

            // remove trailing x
            int length = primeFactorsString.Length;
            primeFactorsString = primeFactorsString.Substring(0, length - 1);

            return primeFactorsString;
        }
    }
}
