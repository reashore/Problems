using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem7
{
    class Program
    {
        static void Main()
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

            bool isPrime = IsPrime(104743);
        }

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

        private static bool IsPrime(int number)
        {
            for (int n = 2; n < number; n++)
            {
                if (number % n == 0)
                {
                    return false;
                }
            }

            return true;
        }
    }
}

