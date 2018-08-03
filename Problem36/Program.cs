using System;

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

                if (IsPalindrome(numberBase10) && IsPalindrome(numberBase2))
                {
                    sum += number;
                    //Console.WriteLine($"number = {number}");
                }
            }

            return sum;
        }

        private static bool IsPalindrome(string numberString)
        {
            for (int left = 0, right = numberString.Length - 1; left <= right; left++, right--)
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
