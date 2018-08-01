using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem1
{
    class Program
    {
        // Find the sum of all number less than upperLimit that are divisible by 3 or 5.
        // For an upperLimit = 10, the candidates are 3, 5, 6, 9. Their sum is 23.
        // Result =  233168.
        static void Main()
        {
            Console.WriteLine("Problem1");
            const int upperLimit = 1000;
            int result = GetMuliplesOf3And5LessThan(upperLimit);
            Console.WriteLine($"Result = {result}", result);
            Console.ReadKey();
        }

        static int GetMuliplesOf3And5LessThan(int upperLimit)
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
