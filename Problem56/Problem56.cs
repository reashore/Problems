using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using Common;

namespace Problem56
{
    public static class Problem56
    {
        public static long Solve()
        {
            const int upperBound = 100;
            long maxDigitSum = 0;

            for (int a = 1; a < upperBound; a++)
            {
                for (int b = 1; b < upperBound; b++)
                {
                    BigInteger power = BigInteger.Pow(a, b);
                    string powerString = power.ToString();
                    List<int> powerList = Utilities.ConvertNumericStringToList(powerString);
                    long digitSum = powerList.Sum(n => n);

                    if (digitSum > maxDigitSum)
                    {
                        maxDigitSum = digitSum;
                    }
                }
            }

            return maxDigitSum;
        }
    }
}