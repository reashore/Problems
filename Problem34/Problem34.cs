using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;

namespace Problem34
{
    public static class Problem34
    {
        public static long Solve()
        {
            const int upperBound = 10000000;
            List<long> digitFactorials = new();

            for (long number = 3; number < upperBound; number++)
            {
                BigInteger digitFactorialSum = SumFactorialsOfDigits(number);

                // ReSharper disable once InvertIf
                if (number == digitFactorialSum)
                {
                    digitFactorials.Add(number);
                    Console.WriteLine($"number = {number}");
                }
            }

            long sum = digitFactorials.Sum(n => n);

            return sum;
        }

        private static BigInteger SumFactorialsOfDigits(long number)
        {
            string numberString = number.ToString();
            BigInteger digitFactorialSum = 0;

            foreach (char c in numberString)
            {
                int digit = Convert.ToInt32(c.ToString());
                digitFactorialSum += Factorial(digit);
            }

            return digitFactorialSum;
        }

        private static BigInteger Factorial(int n)
        {
            if (n == 0)
            {
                return 1;
            }

            return n * Factorial(n - 1);
        }
    }
}