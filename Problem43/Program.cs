using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace Problem43
{
    // ReSharper disable once ClassNeverInstantiated.Global
    internal class Program
    {
        private static void Main()
        {
            Console.WriteLine("Problem 43");

            Test();

            long sum = Solve();
            Console.WriteLine($" sum = {sum}");     // 16695334890

            Console.WriteLine("Done");
            Console.ReadKey();
        }

        private static void Test()
        {
            long number = 9876543210;
            bool is0To9Pandigital = Is0To9Pandigital(number);
            Debug.Assert(is0To9Pandigital);

            number = 1234567890;
            is0To9Pandigital = Is0To9Pandigital(number);
            Debug.Assert(is0To9Pandigital);

            number = 9876543211;
            is0To9Pandigital = Is0To9Pandigital(number);
            Debug.Assert(!is0To9Pandigital);

            number = 1406357289;
            bool isSubstringDivisible = IsSubstringDivisible(number);
            Debug.Assert(isSubstringDivisible);
        }

        private static long Solve()
        {
            long sum = 0;

            for (long number = 1234567890; number <= 9876543210; number++)
            {
                // ReSharper disable once InvertIf
                if (Is0To9Pandigital(number))
                {
                    // ReSharper disable once InvertIf
                    if (IsSubstringDivisible(number))
                    {
                        sum += number;

                        Console.WriteLine($"{number} is 0 to 9 pandigital and substring divisible");
                    }
                }
            }

            return sum;
        }

        private static bool IsSubstringDivisible(long number)
        {
            string numberString = number.ToString();
            Debug.Assert(numberString.Length == 10);
            List<string> digitList = new List<string>();

            foreach (char c in numberString)
            {
                digitList.Add(c.ToString());
            }

            long d123 = Convert.ToInt64(digitList[1] + digitList[2] + digitList[3]);
            long d234 = Convert.ToInt64(digitList[2] + digitList[3] + digitList[4]);
            long d345 = Convert.ToInt64(digitList[3] + digitList[4] + digitList[5]);
            long d456 = Convert.ToInt64(digitList[4] + digitList[5] + digitList[6]);
            long d567 = Convert.ToInt64(digitList[5] + digitList[6] + digitList[7]);
            long d678 = Convert.ToInt64(digitList[6] + digitList[7] + digitList[8]);
            long d789 = Convert.ToInt64(digitList[7] + digitList[8] + digitList[9]);

            bool isSubstringDivisible =
                d123 % 2 == 0 &&
                d234 % 3 == 0 &&
                d345 % 5 == 0 &&
                d456 % 7 == 0 &&
                d567 % 11 == 0 &&
                d678 % 13 == 0 &&
                d789 % 17 == 0;

            return isSubstringDivisible;
        }

        private static bool Is0To9Pandigital(long number)
        {
            // Contains every digit from 0 to 9 exactly once
            string numberString = number.ToString();
            return Is0To9Pandigital(numberString);
        }

        private static bool Is0To9Pandigital(string numberString)
        {
            if (numberString.Length != 10)
            {
                return false;
            }

            const string digits = "0123456789";

            foreach (char digit in digits)
            {
                if (!numberString.Contains(digit))
                {
                    return false;
                }
            }

            return true;
        }
    }
}
