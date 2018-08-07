﻿using System;
using System.Collections.Generic;

namespace Problem40
{
    // ReSharper disable once ClassNeverInstantiated.Global
    internal class Program
    {
        private static void Main()
        {
            Console.WriteLine("Problem 40");

            const long upperBound = 1000000;
            long product = Solve(upperBound);
            Console.WriteLine($"product = {product}");      // 210

            Console.WriteLine("Done");
            Console.ReadKey();
        }

        private static long Solve(long upperBound)
        {
            long product = 1;

            for (int n = 1; n <= upperBound; n *= 10)
            {
                product *= GetDigitAtIndex(n);
                Console.WriteLine($"GetDigitAtIndex({n}) = {GetDigitAtIndex(n)}");
            }

            return product;
        }

        private static int GetDigitAtIndex(long index)
        {
            // In the problem statement, index is 1-based
            long number = 1;
            long currentIndex = 0;

            while (true)
            {
                long lastIndex = currentIndex;
                currentIndex += number.ToString().Length;

                if (currentIndex >= index)
                {
                    List<int> numberDigits = ConvertNumberToList(number);

                    for (int n = 1; n <= numberDigits.Count; n++)
                    {
                        if (lastIndex + n == index)
                        {
                            return numberDigits[n - 1];
                        }
                    }

                    break;
                }

                number++;
            }

            return 0;
        }

        private static List<int> ConvertNumberToList(long number)
        {
            List<int> digitList = new List<int>();

            string numberString = number.ToString();

            foreach (char c in numberString)
            {
                int digit = Convert.ToInt32(c.ToString());
                digitList.Add(digit);
            }

            return digitList;
        }
    }
}