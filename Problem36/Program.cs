using System;
using Common;

namespace Problem36
{
    // ReSharper disable once ClassNeverInstantiated.Global
    internal class Program
    {
        private static void Main()
        {
            Console.WriteLine("Problem 36");

            const int upperLimit = 1000000;
            long sum = Solve(upperLimit);
            Console.WriteLine($"sum = {sum}");      // 872187

            Console.WriteLine("Done");
            Console.ReadKey();
        }

        private static long Solve(int upperLimit)
        {
            long sum = 0;

            for (int number = 0; number < upperLimit; number++)
            {
                string numberBase10 = number.ToString();
                string numberBase2 = Convert.ToString(number, 2);

                //Console.WriteLine($"number = {number}, numberBase10 = {numberBase10}, numberBase2 = {numberBase2}");

                if (Utilities.IsPalindrome(numberBase10) && Utilities.IsPalindrome(numberBase2))
                {
                    sum += number;
                    //Console.WriteLine($"number = {number}");
                }
            }

            return sum;
        }
    }
}
