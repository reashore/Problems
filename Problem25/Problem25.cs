using System;
using System.Collections.Generic;
using System.Numerics;

namespace Problem25
{
    public static class Problem25
    {
        public static int Solve()
        {
            const int numberDigits = 1000;
            int n = 3;
            int index;
            BigInteger termMinus1 = new(1);
            BigInteger termMinus2 = new(1);

            while (true)
            {
                BigInteger fibonacci = termMinus1 + termMinus2;
                int numberFibonacciDigits = CountDigits(fibonacci);

                //WriteLine($"numberFibonacciDigits = {numberFibonacciDigits, 7}, Fibonacci({n, 7}) = {fibonacci}");

                // <= is required to ensure loop breaks
                if (numberDigits <= numberFibonacciDigits)
                {
                    index = n;
                    break;
                }

                termMinus2 = termMinus1;
                termMinus1 = fibonacci;
                n++;
            }

            return index;
        }

        private static int CountDigits(BigInteger value)
        {
            string valueString = value.ToString();
            List<int> digitList = new();

            foreach (char c in valueString)
            {
                int digit = Convert.ToInt32(c.ToString());
                digitList.Add(digit);
            }

            int numberDigits = digitList.Count;

            return numberDigits;
        }
    }
}