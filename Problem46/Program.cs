using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace Problem46
{
    // ReSharper disable once ClassNeverInstantiated.Global
    internal class Program
    {
        private static void Main()
        {
            Console.WriteLine("problem 46");

            Test();

            long lowerBound = 999999;
            long upperBound = 10000000;
            long result = Solve(lowerBound, upperBound);
            if (result > 0)
            {
                Console.WriteLine($"Goldbach's conjecture failed for {result}");
            }

            Console.WriteLine("Done");
            Console.Beep();
            Console.ReadKey();
        }

        private static void Test()
        {
            for (long n = 1; n < 34; n++)
            {
                if (IsOddComposite(n))
                {
                    Console.WriteLine($"{n} is an odd composite");
                }
            }

            List<long> satisfiesGoldbackConjectureList = new List<long> { 9, 15, 21, 25, 27, 33 };
            bool allSatisfyGoldbackConjecture = satisfiesGoldbackConjectureList.TrueForAll(SatisfiesGoldbachConjecture);
            Debug.Assert(allSatisfyGoldbackConjecture);
        }

        private static long Solve(long lowerBound, long upperBound)
        {
            for (long number = lowerBound; number < upperBound; number += 2)
            {
                // ReSharper disable once InvertIf
                if (IsOddComposite(number))
                {
                    if (!SatisfiesGoldbachConjecture(number))
                    {
                        return number;
                    }
                }
            }

            return 0;
        }

        private static bool SatisfiesGoldbachConjecture(long number)
        {
            for (long n = 1; n < number; n++)
            {
                if (!IsPrime(n))
                {
                    continue;
                }

                long prime = n;

                for (long m = 1; number < prime + 2 * m * m; m++)
                {
                    bool satisfiesGoldbackConjecture = number == prime + 2 * m * m;

                    if (!satisfiesGoldbackConjecture)
                    {
                        return false;
                    }
                }
            }

            return true;
        }

        private static bool IsOddComposite(long number)
        {
            bool isOdd = number % 2 != 0;
            bool isPrime = IsPrime(number);

            return isOdd && !isPrime;
        }

        private static bool IsPrime(long candidate)
        {
            if ((candidate & 1) == 0)
            {
                return candidate == 2;
            }

            for (int i = 3; i * i <= candidate; i += 2)
            {
                if (candidate % i == 0)
                {
                    return false;
                }
            }

            return candidate != 1;
        }
    }
}
