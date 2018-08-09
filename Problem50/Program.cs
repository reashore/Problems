using System;
using System.Collections.Generic;
using System.Linq;
using Common;

namespace Problem50
{
    // ReSharper disable once ClassNeverInstantiated.Global
    internal class Program
    {
        private static void Main()
        {
            Console.WriteLine("Problem 50");

            const long upperBound = 100;
            (long, long) prime = Solve(upperBound);
            Console.WriteLine($"prime = {prime}");

            Console.WriteLine("Done");
            Console.ReadKey();
        }

        private static (long, long) Solve(long upperBound)
        {
            long maxNumberConsecutivePrimes = 0;
            long maxPrime = 0;
            List<long> primes = new List<long> {2};

            for (long number = 3; number < upperBound; number += 2)
            {
                if (!MathUtilities.IsPrime(number))
                {
                    continue;
                }

                primes.Add(number);

                long numberConsecutivePrimes = GetMaxSumOfConsecutivePrimes(number, primes);

                if (numberConsecutivePrimes > maxNumberConsecutivePrimes)
                {
                    maxNumberConsecutivePrimes = numberConsecutivePrimes;
                    maxPrime = number;
                }
            }

            return (maxPrime, maxNumberConsecutivePrimes);
        }

        private static long GetMaxSumOfConsecutivePrimes(long number, List<long> primes)
        {
            List<long> primesLessThanNumber = primes.Where(n => n < number).ToList();

            int numberPrimesLessThanNumber = primesLessThanNumber.Count;
            int maxConsecutivePrimes = 0;

            // skip + take = numberPrimesLessThanNumber

            for (int skip = 0; skip <= numberPrimesLessThanNumber - 1; skip++)
            {
                int take = numberPrimesLessThanNumber - skip;
                IEnumerable<long> candidateList = primes.Skip(skip).Take(take);

                if (candidateList.Sum(n => n) == number)
                {
                    maxConsecutivePrimes = take;
                }
            }

            return maxConsecutivePrimes;
        }
    }
}
