using Common;

namespace Problem46
{
    public static class Problem46
    {
        public static long Solve()
        {
            const long upperBound = 6000;
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
                if (!Utilities.IsPrime(n))
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
            bool isPrime = Utilities.IsPrime(number);

            return isOdd && !isPrime;
        }
    }
}