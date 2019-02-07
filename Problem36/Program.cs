using System;
using static Common.Utilities;
using static System.Console;

namespace Problem36
{
    // ReSharper disable once ClassNeverInstantiated.Global
    public class Program
    {
        public static void Main()
        {
            WriteLine("Problem 36");

            long sum = Solve();
            WriteLine($"sum = {sum}");      // 872187

            WriteLine("Done");
            ReadKey();
        }

        public static long Solve()
        {
            const int upperLimit = 1000000;
            long sum = 0;

            for (int number = 0; number < upperLimit; number++)
            {
                string numberBase10 = number.ToString();
                string numberBase2 = Convert.ToString(number, 2);

                //WriteLine($"number = {number}, numberBase10 = {numberBase10}, numberBase2 = {numberBase2}");

                if (IsPalindrome(numberBase10) && IsPalindrome(numberBase2))
                {
                    sum += number;
                    //WriteLine($"number = {number}");
                }
            }

            return sum;
        }
    }
}
