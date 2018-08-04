using System;
using System.Collections.Generic;
using System.Linq;

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

            for (int n = 1; n < upperBound; n++)
            {
                int number1 = n;
                int number2 = n + 1;
                int number3 = n + 2;
                int number4 = n + 3;

                List<int> primeFactors1 = GetPrimeFactors(number1);
                List<int> primeFactors2 = GetPrimeFactors(number2);
                List<int> primeFactors3 = GetPrimeFactors(number3);
                List<int> primeFactors4 = GetPrimeFactors(number4);

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

        private static List<int> GetPrimeFactors(int number)
        {
            List<int> primes = new List<int>();

            for (int divisor = 2; divisor <= number; divisor++)
            {
                while (number % divisor == 0)
                {
                    primes.Add(divisor);
                    number = number / divisor;
                }
            }

            return primes;
        }

        private static string ToString(IEnumerable<int> primeFactors)
        {
            string primeFactorsString = "";

            // ReSharper disable once LoopCanBeConvertedToQuery
            foreach (int primeFactor in primeFactors)
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
