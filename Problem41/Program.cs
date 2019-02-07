using System;
using static Common.Utilities;
using static System.Console;

namespace Problem41
{
    // ReSharper disable once ClassNeverInstantiated.Global
    public class Program
    {
        private static void Main()
        {
            WriteLine("Problem 41");

            Test();
            long maxPandigitalPrime = Solve();
            WriteLine($"maxPandigitalPrime = {maxPandigitalPrime}");    // 7652413

            WriteLine("Done");
            ReadKey();
        }

        private static void Test()
        {
            string number = "2143";
            bool isPandigital = IsPandigital(number, 4);
            Assert(isPandigital);

            number = "87654321";
            isPandigital = IsPandigital(number, 8);
            Assert(isPandigital);

            number = "987654321";
            isPandigital = IsPandigital(number);
            Assert(isPandigital);

            long upperBound = GetUpperBound(5);
            Assert(upperBound == 54321);
            upperBound = GetUpperBound(9);
            Assert(upperBound == 987654321);
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
                    if (!IsPandigital(number, digit))
                    {
                        continue;
                    }

                    // ReSharper disable once InvertIf
                    if (IsPrime(number))
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
