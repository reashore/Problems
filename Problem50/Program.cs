using System;

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
                if (!IsPrime(number))
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

        private static bool IsPrime(long number)
        {
            // Algorithm fails if number < 0, so take absolute value
            number = Math.Abs(number);

            if ((number & 1) == 0)
            {
                return number == 2;
            }

            for (long i = 3; i * i <= number; i += 2)
            {
                if (number % i == 0)
                {
                    return false;
                }
            }

            return number != 1;
        }
    }
}
