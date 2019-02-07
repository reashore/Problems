using System;
using static Common.Utilities;
using static System.Console;

namespace Problem38
{
    // ReSharper disable once ClassNeverInstantiated.Global
    public class Program
    {
        public static void Main()
        {
            WriteLine("Problem 38");

            //Test();

            long answer = Solve();
            WriteLine($"maxConcatenatedProduct = {answer}");        // 932718654

            WriteLine("Done");
            ReadKey();
        }

//        private static void Test()
//        {
//            long number = 9;
//            long digit = 5;
//            long concatenatedProduct = GetConcatenatedProduct(number, digit);
//            bool isPandigital = IsPandigital(concatenatedProduct);
//            Assert(isPandigital);
//
//            number = 192;
//            digit = 3;
//            concatenatedProduct = GetConcatenatedProduct(number, digit);
//            isPandigital = IsPandigital(concatenatedProduct);
//            Assert(isPandigital);
//        }

        public static long Solve()
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

                    bool isPandigital = IsPandigital(concatenatedProduct);

                    // ReSharper disable once InvertIf
                    if (isPandigital)
                    {
                        if (concatenatedProduct > maxConcatenatedProduct)
                        {
                            maxConcatenatedProduct = concatenatedProduct;
                        }

                        WriteLine($"number = {number, 5}, digit = {maxFactor, 5}, concatenatedProduct = {concatenatedProduct, 13}");
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

