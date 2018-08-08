using System;
using Common;

namespace Problem50
{
    // ReSharper disable once ClassNeverInstantiated.Global
    internal class Program
    {
        private static void Main()
        {
            Console.WriteLine("Problem 50");

            const int upperBound = 1000;
            (int, int) prime = Solve(upperBound);
            Console.WriteLine($"prime = {prime}");

            Console.WriteLine("Done");
            Console.ReadKey();
        }

        private static (int, int) Solve(int upperBound)
        {
            int maxSumOfConsecutivePrimes = 0;
            int maxPrime = 0;

            for (int number = 1; number < upperBound; number += 2)
            {
                if (!MathUtilities.IsPrime(number))
                {
                    continue;
                }

                int numberConsecutivePrimes = IsSumOfConsecutivePrimes(number);

                if (numberConsecutivePrimes > maxSumOfConsecutivePrimes)
                {
                    maxSumOfConsecutivePrimes = numberConsecutivePrimes;
                    maxPrime = number;
                }
            }

            return (maxPrime, maxSumOfConsecutivePrimes);
        }

        private static int IsSumOfConsecutivePrimes(int number)
        {
            // Sum primes from start prime until sum > number, return number consecutive primes

            return 0;
        }
    }
}
