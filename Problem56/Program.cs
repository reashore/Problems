using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using static Common.Utilities;
using static System.Console;

namespace Problem56
{
    // ReSharper disable once ClassNeverInstantiated.Global
    public class Program
    {
        public static void Main()
        {
            WriteLine("Problem 56");

            long answer = Solve();
            WriteLine($"answer = {answer}");        // 972

            WriteLine("Done");
            ReadKey();
        }

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
                    List<int> powerList = ConvertNumericStringToList(powerString);
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
