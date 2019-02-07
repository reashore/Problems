using System;
using static Common.Utilities;
using static System.Console;

namespace Problem41
{
    // ReSharper disable once ClassNeverInstantiated.Global
    public class Program
    {
        public static void Main()
        {
            WriteLine("Problem 41");

            long answer = Solve();
            WriteLine($"maxPandigitalPrime = {answer}");    // 7652413

            WriteLine("Done");
            ReadKey();
        }

        public static long Solve()
        {
            long maxPandigitalPrime = 0;

            for (int digit = 9; 1 < digit; digit--)
            {
                long upperBound = GetUpperBound(digit);
                //WriteLine($"upperBound = {upperBound}");

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
