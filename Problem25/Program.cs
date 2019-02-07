using System;
using System.Collections.Generic;
using System.Numerics;
using static System.Console;

namespace Problem25
{
    // ReSharper disable once ClassNeverInstantiated.Global
    public class Program
    {
        public static void Main()
        {
            WriteLine("Problem 25");

            int answer = Solve();
            WriteLine($"FibonacciIndex = {answer, 7}");

            WriteLine("Done");
            ReadKey();
        }

        public static int Solve()
        {
            const int numberDigits = 1000;
            int n = 3;
            int index;
            BigInteger termMinus1 = new BigInteger(1);
            BigInteger termMinus2 = new BigInteger(1);

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
            List<int> digitList = new List<int>();

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
