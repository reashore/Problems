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
            bool isPandigital = IsPandigital(number, 4);
            Debug.Assert(isPandigital);

            number = "87654321";
            isPandigital = IsPandigital(number, 8);
            Debug.Assert(isPandigital);

            number = "987654321";
            isPandigital = IsPandigital(number);
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
                    if (!IsPandigital(number, digit))
                    {
                        continue;
                    }

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

        private static bool IsPandigital(long number, int n = 9)
        {
            // Contains every digit from 1 to digit exactly once
            string numberString = number.ToString();
            return IsPandigital(numberString, n);
        }

        private static bool IsPandigital(string numberString, int n = 9)
        {
            if (numberString.Length != n)
            {
                return false;
            }

            const string allDigits = "123456789";
            string digits = allDigits.Substring(0, n);

            foreach (char digit in digits)
            {
                if (!numberString.Contains(digit))
                {
                    return false;
                }
            }

            return true;
        }

        private static bool IsPrime(long candidate)
        {
            if ((candidate & 1) == 0)
            {
                return candidate == 2;
            }

            for (int i = 3; (i * i) <= candidate; i += 2)
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
