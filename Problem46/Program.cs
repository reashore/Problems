using System;
using System.Collections.Generic;

namespace Problem46
{
    // ReSharper disable once ClassNeverInstantiated.Global
    internal class Program
    {
        private static void Main()
        {
            Console.WriteLine("problem 46");

            Test();

            const long upperBound = 6000;
            long result = Solve(upperBound);

            if (result > 0)
            {
                Console.WriteLine($"Goldbach's conjecture failed for {result}");
            }

            Console.WriteLine("Done");
            Console.ReadKey();
        }

        private static void Test()
        {
            List<long> satisfiesGoldbackConjectureList = new List<long> { 9, 15, 21, 25, 27, 33 };
            bool allSatisfyGoldbackConjecture = satisfiesGoldbackConjectureList.TrueForAll(SatisfiesGoldbachConjecture);

            if (!allSatisfyGoldbackConjecture)
            {
                Console.WriteLine("Goldbach conjecture failed for List");
            }
        }

        private static long Solve(long upperBound)
        {
            const int smallestGoldbachNumber = 9;

            for (long number = smallestGoldbachNumber; number < upperBound; number += 2)
            {
                if (!IsOddComposite(number))
                {
                    continue;
                }

                if (!SatisfiesGoldbachConjecture(number))
                {
                    return number;
                }
            }

            return 0;
        }

        private static bool SatisfiesGoldbachConjecture(long number)
        {
            for (long n = 3; n < number; n++)
            {
                if (!IsPrime(n))
                {
                    continue;
                }

                long prime = n;

                for (long m = 1; prime + 2 * m * m <= number; m++)
                {
                    bool satisfiesGoldbackConjecture = number == prime + 2 * m * m;

                    if (satisfiesGoldbackConjecture)
                    {
                        return true;
                    }
                }
            }

            return false;
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
