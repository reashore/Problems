using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using static System.Console;

namespace Problem16
{
    // ReSharper disable once ClassNeverInstantiated.Global
    public class Program
    {
        public static void Main()
        {
            WriteLine("Problem 12");

            Test();

            WriteLine("Done");
            ReadKey();
        }

        private static void Test()
        {
            List<int> exponents = new List<int> { 15, 1000 };

            foreach(int exponent in exponents)
            {
                int result = Solve(exponent);
                WriteLine($"result = {result}");
            }
        }

        private static int Solve(int exponent)
        {
            BigInteger product = new BigInteger(1);
            BigInteger two = new BigInteger(2);

            for (int n = 1; n <= exponent; n++)
            {
                product *= two;
            }

            string productString = product.ToString();
            List<int> productList = new List<int>();

            foreach (char c in productString)
            {
                int digit = Convert.ToInt32(c.ToString());
                productList.Add(digit);
            }

            int sumOfDigits = productList.Sum(n => n);

            return sumOfDigits;
        }
    }
}
