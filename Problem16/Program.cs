using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;

namespace Problem16
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Problem 12");

            int exponent = 15;
            int result = Solve(exponent);
            Console.WriteLine($"result = {result}");

            exponent = 1000;
            result = Solve(exponent);
            Console.WriteLine($"result = {result}");

            Console.WriteLine("Done");
            Console.ReadKey();
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

            int SumOfDigits = productList.Sum(n => n);

            return SumOfDigits;
        }
    }
}
