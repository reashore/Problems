using System;
using System.Collections.Generic;
using System.Linq;
using static Common.Utilities;
using static System.Console;

namespace Problem7
{
    // ReSharper disable once ClassNeverInstantiated.Global
    internal class Program
    {
        private static void Main()
        {
            WriteLine("Problem 7");

            Test();

            WriteLine("Done");
            ReadKey();
        }

        private static void Test()
        {
            List<int> topPrimes = new List<int> { 6, 10001 };

            foreach (int topPrime in topPrimes)
            {
                List<int> primes = Solve(topPrime);
                int value = primes.Last();
                WriteLine($"{value} is the {topPrime}th prime");
            }

            bool isPrime = IsPrime(104743);
            Assert(isPrime);
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
                bool isPrime = IsPrime(n);

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

