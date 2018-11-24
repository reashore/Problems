using System;
using static Common.Utilities;
using static System.Console;

namespace Problem44
{
    // ReSharper disable once ClassNeverInstantiated.Global
    internal class Program
    {
        private static void Main()
        {
            WriteLine("Problem 44");

            const long upperBound = 10000;
            Test(upperBound);
            WriteLine("Tests Done");

            long minimalDifference = Solve(upperBound);
            WriteLine($"minimalDifference = {minimalDifference}");      // 5482660

            WriteLine("Done");
            ReadKey();
        }

        private static void Test(long upperBound)
        {
            bool isPentagonalNumberCheck = IsPentagonalNumber(1);
            Assert(isPentagonalNumberCheck);

            for (int number = 1; number < upperBound; number++)
            {
                long pentagonalNumber = GetPentagonalNumber(number);
                //Console.WriteLine($"pentagonalNumber = {pentagonalNumber}");

                bool isPentagonalNumber = IsPentagonalNumber(pentagonalNumber);

                if (!isPentagonalNumber)
                {
                    WriteLine($"Failed for number = {number}, pentagonalNumber = {pentagonalNumber}");
                }
            }
        }

        private static long Solve(long upperBound)
        {
            long minimalDifference = long.MaxValue;
            WriteLine($"long max = {long.MaxValue}");

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
                        WriteLine($"minimalDifference = {minimalDifference}");
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
