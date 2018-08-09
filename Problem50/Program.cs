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

            const long upperBound = 1000000;
            (long, long) result = Solve(upperBound);
            long prime = result.Item1;
            long numberConsecutivePrimes = result.Item2;
            Console.WriteLine($"prime = {prime}, numberConsecutivePrimes = {numberConsecutivePrimes}");     //

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

                long numberConsecutivePrimes = GetMaxSumOfConsecutivePrimes(number, primes);

                if (numberConsecutivePrimes > maxNumberConsecutivePrimes)
                {
                    maxNumberConsecutivePrimes = numberConsecutivePrimes;
                    maxPrime = number;
                }

                primes.Add(number);
            }

            return (maxPrime, maxNumberConsecutivePrimes);
        }

        private static long GetMaxSumOfConsecutivePrimes(long number, List<long> primes)
        {
            int numberPrimesLessThanNumber = primes.Count;

            for (int skip = 0; skip + 2 <= numberPrimesLessThanNumber; skip++)
            {
                for (int take = 2; skip + take <= numberPrimesLessThanNumber; take++)
                {
                    long sum = primes.Skip(skip).Take(take).Sum(n => n);

                    if (sum == number)
                    {
                        return take;
                    }

                    if (sum > number)
                    {
                        break;
                    }
                }
            }

            return 0;
        }
    }
}
