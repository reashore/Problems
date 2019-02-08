using System.Collections.Generic;
using System.Linq;
using static Common.Utilities;
using static System.Console;

namespace Problem50
{
    // ReSharper disable once ClassNeverInstantiated.Global
    public class Program
    {
        public static void Main()
        {
            WriteLine("Problem 50");

            long answer = Solve();
            WriteLine($"prime = {answer}");        // 997651

            WriteLine("Done");
            ReadKey();
        }

        public static long Solve()
        {
            const long upperBound = 1000000;
            long maxNumberConsecutivePrimes = 0;
            long maxPrime = 0;
            List<long> primes = new List<long> {2};

            for (long number = 3; number < upperBound; number += 2)
            {
                if (!IsPrime(number))
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

            return maxPrime;
        }

        private static long GetMaxSumOfConsecutivePrimes(long number, IReadOnlyCollection<long> primes)
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
