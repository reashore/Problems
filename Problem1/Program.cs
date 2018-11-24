﻿using System.Collections.Generic;
using System.Linq;
using static System.Console;

namespace Problem1
{
    // ReSharper disable once ClassNeverInstantiated.Global
    internal class Program
    {
        private static void Main()
        {
            WriteLine("Problem 1");

            const int upperLimit = 1000;
            int result = GetMuliplesOf3And5LessThan(upperLimit);
            WriteLine($"Result = {result}", result);

            WriteLine("Done");
            ReadKey();
        }

        private static int GetMuliplesOf3And5LessThan(int upperLimit)
        {
            List<int> factors = new List<int>();

            for (int n = 3; n < upperLimit; n++)
            {
                if (n % 3 == 0 || n % 5 == 0)
                {
                    factors.Add(n);
                    //Console.WriteLine($"n= {n}");
                }
            }

            int result = factors.Sum();

            return result;
        }
    }
}
