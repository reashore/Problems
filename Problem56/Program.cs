using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using Common;

namespace Problem56
{
    // ReSharper disable once ClassNeverInstantiated.Global
    internal class Program
    {
        private static void Main()
        {
            Console.WriteLine("Problem 56");

            const int upperBound = 100;
            long result = Solve(upperBound);
            Console.WriteLine($"result = {result}");        // 972

            Console.WriteLine("Done");
            Console.ReadKey();
        }

        private static long Solve(int upperBound)
        {
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
