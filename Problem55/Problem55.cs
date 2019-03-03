using System.Numerics;
using Common;

namespace Problem55
{
    public static class Problem55
    {
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