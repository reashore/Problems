using System;

namespace Problem44
{
    public static class Problem44
    {
        public static long Solve()
        {
            const long upperBound = 10000;
            long minimalDifference = long.MaxValue;
            Console.WriteLine($"long max = {long.MaxValue}");

            for (int n = 1; n < upperBound; n++)
            {
                for (int m = 1; m < upperBound; m++)
                {
                    if (m < n)
                    {
                        continue;
                    }

                    long pentagonalNumber1 = GetPentagonalNumber(n);
                    long pentagonalNumber2 = GetPentagonalNumber(m);

                    // Test difference first since it is a smaller number
                    long difference = Math.Abs(pentagonalNumber1 - pentagonalNumber2);
                    bool isDifferencePentagonal = IsPentagonalNumber(difference);
                    if (!isDifferencePentagonal)
                    {
                        continue;
                    }

                    long sum = pentagonalNumber1 + pentagonalNumber2;
                    bool isSumPentagonal = IsPentagonalNumber(sum);
                    if (!isSumPentagonal)
                    {
                        continue;
                    }

                    // ReSharper disable once InvertIf
                    if (difference < minimalDifference)
                    {
                        minimalDifference = difference;
                        Console.WriteLine($"minimalDifference = {minimalDifference}");
                    }
                }
            }

            return minimalDifference;
        }

        private static long GetPentagonalNumber(long number)
        {
            long pentagonalNumber = number * (3 * number - 1) / 2;

            return pentagonalNumber;
        }

        private static bool IsPentagonalNumber(long pentagonalNumber)
        {
            if (pentagonalNumber == 1)
            {
                return true;
            }

            // Rough upper bound
            long upperBound = Convert.ToInt64(Math.Ceiling(Math.Sqrt(pentagonalNumber * 2.0 / 3)));

            for (int number = 2; number <= upperBound; number++)
            {
                if (GetPentagonalNumber(number) == pentagonalNumber)
                {
                    return true;
                }
            }

            return false;
        }
    }
}