using System;
using System.Diagnostics;
using Common;

namespace Problem38
{
    // ReSharper disable once ClassNeverInstantiated.Global
    internal class Program
    {
        private static void Main()
        {
            Console.WriteLine("Problem 38");

            Test();

            long maxConcatenatedProduct = Solve();
            Console.WriteLine($"maxConcatenatedProduct = {maxConcatenatedProduct}");

            Console.WriteLine("Done");
            Console.ReadKey();
        }

        private static void Test()
        {
            long number = 9;
            long digit = 5;
            long concatenatedProduct = GetConcatenatedProduct(number, digit);
            bool isPandigital = MathUtilities.IsPandigital(concatenatedProduct);
            Debug.Assert(isPandigital);

            number = 192;
            digit = 3;
            concatenatedProduct = GetConcatenatedProduct(number, digit);
            isPandigital = MathUtilities.IsPandigital(concatenatedProduct);
            Debug.Assert(isPandigital);
        }

        private static long Solve()
        {
            long maxConcatenatedProduct = 0;

            for (long number = 1; number <= 10000000; number++)
            {
                for (long maxFactor = 1; maxFactor <= 20; maxFactor++)
                {
                    long concatenatedProduct = GetConcatenatedProduct(number, maxFactor);

                    if (concatenatedProduct == 0)
                    {
                        break;
                    }

                    bool isPandigital = MathUtilities.IsPandigital(concatenatedProduct);

                    // ReSharper disable once InvertIf
                    if (isPandigital)
                    {
                        if (concatenatedProduct > maxConcatenatedProduct)
                        {
                            maxConcatenatedProduct = concatenatedProduct;
                        }

                        Console.WriteLine($"number = {number, 5}, digit = {maxFactor, 5}, concatenatedProduct = {concatenatedProduct, 13}");
                    }
                }
            }

            return maxConcatenatedProduct;
        }

        private static long GetConcatenatedProduct(long number, long maxFactor)
        {
            string sumString = "";

            for (long factor = 1; factor <= maxFactor; factor++)
            {
                long product = number * factor;
                sumString += product.ToString();
            }

            // If the string is too long to be pandigital, then return 0
            if (sumString.Length > 9)
            {
                return 0;
            }

            long sum = Convert.ToInt64(sumString);

            return sum;
        }
    }
}

