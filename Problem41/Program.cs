using Common;
using System;
using System.Diagnostics;

namespace Problem41
{
    // ReSharper disable once ClassNeverInstantiated.Global
    internal class Program
    {
        private static void Main()
        {
            Console.WriteLine("Problem 41");

            Test();
            long maxPandigitalPrime = Solve();
            Console.WriteLine($"maxPandigitalPrime = {maxPandigitalPrime}");    // 7652413

            Console.WriteLine("Done");
            Console.ReadKey();
        }

        private static void Test()
        {
            string number = "2143";
            bool isPandigital = MathUtilities.IsPandigital(number, 4);
            Debug.Assert(isPandigital);

            number = "87654321";
            isPandigital = MathUtilities.IsPandigital(number, 8);
            Debug.Assert(isPandigital);

            number = "987654321";
            isPandigital = MathUtilities.IsPandigital(number);
            Debug.Assert(isPandigital);

            long upperBound = GetUpperBound(5);
            Debug.Assert(upperBound == 54321);
            upperBound = GetUpperBound(9);
            Debug.Assert(upperBound == 987654321);
        }

        private static long Solve()
        {
            long maxPandigitalPrime = 0;

            for (int digit = 9; 1 < digit; digit--)
            {
                long upperBound = GetUpperBound(digit);
                //Console.WriteLine($"upperBound = {upperBound}");

                for (long number = upperBound; 2 < number; number--)
                {
                    if (!MathUtilities.IsPandigital(number, digit))
                    {
                        continue;
                    }

                    // ReSharper disable once InvertIf
                    if (MathUtilities.IsPrime(number))
                    {
                        if (number > maxPandigitalPrime)
                        {
                            maxPandigitalPrime = number;
                        }

                        //Console.WriteLine($"{number} is prime");
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
