using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using static System.Console;

namespace Problem20
{
    // ReSharper disable once ClassNeverInstantiated.Global
    public class Program
    {
        public static void Main()
        {
            WriteLine("Problem 20");

           int answer = Solve();
            WriteLine($"answer = {answer}");

            WriteLine("Done");
            ReadKey();
        }

        public static int Solve()
        {
            const int number = 100;
            BigInteger factorial = Factorial(number);
            int sumOfDigits = SumDigits(factorial);
            WriteLine($"Factorial({number}) = {factorial.ToString()}");
            WriteLine($"SumDigits = {sumOfDigits}");
            return sumOfDigits;
        }

        private static BigInteger Factorial(int n)
        {
            if (n == 0)
            {
                return 1;
            }

            return n * Factorial(n - 1);
        }

        private static int SumDigits(BigInteger value)
        {
            string valueString = value.ToString();
            List<int> digitList = new List<int>();

            foreach (char c in valueString)
            {
                int digit =Convert.ToInt32(c.ToString());
                digitList.Add(digit);
            }

            int sumOfDigits = digitList.Sum(n => n);

            return sumOfDigits;
        }
    }
}
