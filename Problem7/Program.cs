using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using Common;

namespace Problem7
{
    // ReSharper disable once ClassNeverInstantiated.Global
    internal class Program
    {
        private static void Main()
        {
            Console.WriteLine("Problem 7");

            Test();

            Console.WriteLine("Done");
            Console.ReadKey();
        }

        private static void Test()
        {
            List<int> topPrimes = new List<int> { 6, 10001 };

            foreach (int topPrime in topPrimes)
            {
                List<int> primes = Solve(topPrime);
                int value = primes.Last();
                Console.WriteLine($"{value} is the {topPrime}th prime");
            }

            bool isPrime = MathUtilities.IsPrime(104743);
            Debug.Assert(isPrime);
        }

        // ReSharper disable once ReturnTypeCanBeEnumerable.Local
        private static List<int> Solve(int topPrime)
        {
            if (topPrime < 2)
            {
                throw new ArgumentException(nameof(topPrime));
            }

            List<int> primesList = new List<int>();

            for (int n = 2; ; n++)
            {
                bool isPrime = MathUtilities.IsPrime(n);

                if (isPrime)
                {
                    primesList.Add(n);
                }

                //Console.WriteLine($"IsPrime({n}) = {isPrime}");

                if (primesList.Count == topPrime)
                {
                    break;
                }
            }

            return primesList;
        }
    }
}

