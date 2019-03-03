using System;
using Common;

namespace Problem36
{
    public static class Problem36
    {
        public static long Solve()
        {
            const int upperLimit = 1000000;
            long sum = 0;

            for (int number = 0; number < upperLimit; number++)
            {
                string numberBase10 = number.ToString();
                string numberBase2 = Convert.ToString(number, 2);

                //WriteLine($"number = {number}, numberBase10 = {numberBase10}, numberBase2 = {numberBase2}");

                if (Utilities.IsPalindrome(numberBase10) && Utilities.IsPalindrome(numberBase2))
                {
                    sum += number;
                    //WriteLine($"number = {number}");
                }
            }

            return sum;
        }
    }
}