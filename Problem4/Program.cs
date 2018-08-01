﻿using System;

namespace Problem4
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Problem 4");

            int maxPalindrome = Solve();
            Console.WriteLine($"maxPalindrome = {maxPalindrome}");

            Console.WriteLine("Done");
            Console.ReadKey();
        }

        private static int Solve()
        {
            int maxProduct = 0;

            for(int n = 1; n < 1000; n++)
            {
                for(int m = n + 1; m < 1000; m++)
                {
                    int product = n * m;
                    bool isPalindromicNumber = IsPalindromicNumber(product);
                    if (isPalindromicNumber)
                    {
                        //Console.WriteLine($"{n} x {m} = {product}");

                        if (product > maxProduct)
                        {
                            maxProduct = product;
                        }

                    }
                }
            }

            return maxProduct;
        }

        private static bool IsPalindromicNumber(int number)
        {
            string numberString = number.ToString();

            for (int left = 0, right = numberString.Length - 1 ; left <= right; left++, right--)
            {
                int leftChar = numberString[left];
                int rightChar = numberString[right];

                if (leftChar != rightChar)
                {
                    return false;
                }
            }

            return true;
        }
    }
}