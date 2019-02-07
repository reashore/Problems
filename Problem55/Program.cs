using System.Numerics;
using static Common.Utilities;
using static System.Console;

namespace Problem55
{
    // ReSharper disable once ClassNeverInstantiated.Global
    public class Program
    {
        public static void Main()
        {
            WriteLine("Problem 55");

            Test();

            const int upperBound = 10000;
            int result = Solve(upperBound);
            WriteLine($"result = {result}");        // 249

            WriteLine("Done");
            ReadKey();
        }

        private static void Test()
        {
            const string numberString = "0123456789";
            string reverseNumberString = Reverse(numberString);
            Assert(reverseNumberString == "9876543210");

            bool result = IsLychrelNumber(47);
            Assert(!result);

            result = IsLychrelNumber(349);
            Assert(!result);

            result = IsLychrelNumber(196);
            Assert(result);
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

        // ReSharper disable once IdentifierTypo
        private static bool IsLychrelNumber(int number)
        {
            string numberString = number.ToString();
            const int iterationMax = 50;

            for(int n = 1; n < iterationMax; n++)
            {
                string reversedNumberString = Reverse(numberString);
                BigInteger addend1 = BigInteger.Parse(numberString);
                BigInteger addend2 = BigInteger.Parse(reversedNumberString);
                BigInteger sum = addend1 + addend2;
                string sumString = sum.ToString();

                if (IsPalindrome(sumString))
                {
                    return false;
                }

                numberString = sumString;
            }

            return true;
        }
    }
}
