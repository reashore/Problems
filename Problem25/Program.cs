using System;
using System.Collections.Generic;
using System.Numerics;
using Common;

namespace Problem25
{
    // ReSharper disable once ClassNeverInstantiated.Global
    public class Program
    {
        private static void Main()
        {
            Console.WriteLine("Problem 25");

            Test();

            List<int> numberDigitsList = new List<int>
            {
                2,
                3,
                1000,
                4000
            };

            foreach (int numberDigits in numberDigitsList)
            {
                int fibonacciIndex = Solve(numberDigits);
                Console.WriteLine($"numberDigits = {numberDigits, 7}, FibonacciIndex = {fibonacciIndex, 7}");
            }

            Console.WriteLine("Done");
            Console.ReadKey();
        }

        private static void Test()
        {
            BigInteger result = Fibonacci(12);
            Utilities.Assert(result == 12);

            int numberDigits = CountDigits(new BigInteger(12345));
            Utilities.Assert(numberDigits == 5);
        }

        private static int Solve(int numberDigits)
        {
            int n = 3;
            int index;
            BigInteger termMinus1 = new BigInteger(1);
            BigInteger termMinus2 = new BigInteger(1);

            while (true)
            {
                BigInteger fibonacci = termMinus1 + termMinus2;
                int numberFibonacciDigits = CountDigits(fibonacci);

                //Console.WriteLine($"numberFibonacciDigits = {numberFibonacciDigits, 7}, Fibonacci({n, 7}) = {fibonacci}");

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

        private static BigInteger Fibonacci(int n)
        {
            if (n < 1)
            {
                throw new ArgumentException(nameof(n));
            }

            if (n == 1 || n == 2)
            {
                return new BigInteger(1);
            }

            return Fibonacci(n - 1) + Fibonacci(n - 2);
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
