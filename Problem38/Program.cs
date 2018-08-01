using System;

namespace Problem38
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Problem 38");

            Test();

            long upperBound = 1000;
            long maxConcatenatedProduct = Solve(upperBound);
            Console.WriteLine($"maxConcatenatedProduct = {maxConcatenatedProduct}");

            Console.WriteLine("Done");
            Console.ReadKey();
        }

        private static void Test()
        {
            long number = 9;
            long digit = 5;
            long concatenatedProduct = GetConcatenatedProduct(number, digit);
            bool isPandigital = IsPandigital(concatenatedProduct);

            number = 192;
            digit = 3;
            concatenatedProduct = GetConcatenatedProduct(number, digit);
            isPandigital = IsPandigital(concatenatedProduct);
        }

        private static long Solve(long upperBound)
        {
            long maxConcatenatedProduct = 0;

            for (long number = 1; number <= upperBound; number++)
            {
                for (long digit = 1; digit <= 9; digit++)
                {
                    long concatenatedProduct = GetConcatenatedProduct(number, digit);
                    bool isPandigital = IsPandigital(concatenatedProduct);

                    if (isPandigital)
                    {
                        Console.WriteLine($"number = {number, 5}, digit = {digit, 5}, concatenatedProduct = {concatenatedProduct, 13}");
                    }

                    if (concatenatedProduct > maxConcatenatedProduct)
                    {
                        maxConcatenatedProduct = concatenatedProduct;
                    }
                }
            }

            return maxConcatenatedProduct;
        }

        private static long GetConcatenatedProduct(long number, long digit)
        {
            string sumString = "";

            for (long n = 1; n <= digit; n++)
            {
                long product = number * n;
                sumString += product.ToString();
            }

            if (sumString.Length > 9)
            {
                return 0;
            }

            long sum = Convert.ToInt64(sumString);

            return sum;
        }

        private static bool IsPandigital(long number)
        {
            // Contains every digit from 1 to 9 exactly once
            string numberString = number.ToString();
            return IsPandigital(numberString);
        }

        private static bool IsPandigital(string numberString)
        {
            if (numberString.Length != 9)
            {
                return false;
            }

            const string digits = "123456789";

            foreach (char digit in digits)
            {
                if (!numberString.Contains(digit))
                {
                    return false;
                }
            }

            return true;
        }
    }
}

