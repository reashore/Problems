using Common;
using System;
using System.Numerics;

namespace Problem55
{
    // ReSharper disable once ClassNeverInstantiated.Global
    internal class Program
    {
        private static void Main()
        {
            Console.WriteLine("Problem 55");

            Test();

            const int upperBound = 10000;
            int result = Solve(upperBound);
            Console.WriteLine($"result = {result}");        // 249

            Console.WriteLine("Done");
            Console.ReadKey();
        }

        private static void Test()
        {
            const string numberString = "0123456789";
            string reverseNumberString = Utilities.Reverse(numberString);
            Utilities.Assert(reverseNumberString == "9876543210");

            bool result = IsLychrelNumber(47);
            Utilities.Assert(!result);

            result = IsLychrelNumber(349);
            Utilities.Assert(!result);

            result = IsLychrelNumber(196);
            Utilities.Assert(result);
        }

        private static int Solve(int upperBound)
        {
            // ReSharper disable once IdentifierTypo
            int lychrelNumberCount = 0;

            for (int number = 10; number < upperBound; number++)
            {
                if (IsLychrelNumber(number))
                {
                    lychrelNumberCount++;
                }
            }

            return lychrelNumberCount;
        }

        private static bool IsLychrelNumber(int number)
        {
            string numberString = number.ToString();
            const int iterationMax = 50;

            for(int n = 1; n < iterationMax; n++)
            {
                string reversedNumberString = Utilities.Reverse(numberString);
                BigInteger addend1 = BigInteger.Parse(numberString);
                BigInteger addend2 = BigInteger.Parse(reversedNumberString);
                BigInteger sum = addend1 + addend2;
                string sumString = sum.ToString();

                if (Utilities.IsPalindrome(sumString))
                {
                    return false;
                }

                numberString = sumString;
            }

            return true;
        }
    }
}
