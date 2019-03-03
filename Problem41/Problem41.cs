using System;
using Common;

namespace Problem41
{
    public static class Problem41
    {
        public static long Solve()
        {
            long maxPandigitalPrime = 0;

            for (int digit = 9; 1 < digit; digit--)
            {
                long upperBound = GetUpperBound(digit);
                //WriteLine($"upperBound = {upperBound}");

                for (long number = upperBound; 2 < number; number--)
                {
                    if (!Utilities.IsPandigital(number, digit))
                    {
                        continue;
                    }

                    // ReSharper disable once InvertIf
                    if (Utilities.IsPrime(number))
                    {
                        if (number > maxPandigitalPrime)
                        {
                            maxPandigitalPrime = number;
                        }

                        //WriteLine($"{number} is prime");
                    }
                }
            }

            return maxPandigitalPrime;
        }

        private static long GetUpperBound(int digit)
        {
            string upperBoundString = "";

            for (int n = digit; 0 < n; n--)
            {
                upperBoundString += n.ToString();
            }

            long upperBound = Convert.ToInt64(upperBoundString);

            return upperBound;
        }
    }
}