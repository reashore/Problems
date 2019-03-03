using System;
using System.Collections.Generic;
using System.Linq;
using Common;

namespace Problem47
{
    public static class Problem47
    {
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

                IEnumerable<long> primeFactors1 = Utilities.GetPrimeFactors(number1);
                IEnumerable<long> primeFactors2 = Utilities.GetPrimeFactors(number2);
                IEnumerable<long> primeFactors3 = Utilities.GetPrimeFactors(number3);
                IEnumerable<long> primeFactors4 = Utilities.GetPrimeFactors(number4);

                bool allHaveDistinctPrimeFactors =
                    primeFactors1.Distinct().Count() == 4 &&
                    primeFactors2.Distinct().Count() == 4 &&
                    primeFactors3.Distinct().Count() == 4 &&
                    primeFactors4.Distinct().Count() == 4;

                // ReSharper disable once InvertIf
                if (allHaveDistinctPrimeFactors)
                {
                    Console.WriteLine($"number1 = {number1} = {ToString(primeFactors1)}");
                    Console.WriteLine($"number2 = {number2} = {ToString(primeFactors2)}");
                    Console.WriteLine($"number3 = {number3} = {ToString(primeFactors3)}");
                    Console.WriteLine($"number4 = {number4} = {ToString(primeFactors4)}");

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