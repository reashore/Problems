using System;
using System.Collections.Generic;
using System.Linq;
using Common;

namespace Problem47
{
    // ReSharper disable once ClassNeverInstantiated.Global
    internal class Program
    {
        private static void Main()
        {
            Console.WriteLine("Problem 47");

            Solve();

            Console.WriteLine("Done");
            Console.ReadKey();
        }

        private static void Solve()
        {
            const int upperBound = 1000000;

            for (long n = 1; n < upperBound; n++)
            {
                long number1 = n;
                long number2 = n + 1;
                long number3 = n + 2;
                long number4 = n + 3;

                List<long> primeFactors1 = Utilities.GetPrimeFactors(number1);
                List<long> primeFactors2 = Utilities.GetPrimeFactors(number2);
                List<long> primeFactors3 = Utilities.GetPrimeFactors(number3);
                List<long> primeFactors4 = Utilities.GetPrimeFactors(number4);

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
