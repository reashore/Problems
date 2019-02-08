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

            int result = Solve();
            WriteLine($"result = {result}");        // 249

            WriteLine("Done");
            ReadKey();
        }

        public static int Solve()
        {
            const int upperBound = 10000;
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
