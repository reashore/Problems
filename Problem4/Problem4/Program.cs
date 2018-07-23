using System;

namespace Problem4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Problem 4");
            const int number = 1000 * 1000;

            //bool isPalindromicNumber = IsPalindromicNumber(10001);

            int result = GetLargestPalindromicNumber(number);
            Console.WriteLine($"{result} x {result} = {result * result}");

            Console.ReadKey();
        }

        private static int GetLargestPalindromicNumber(int number)
        {
            //int eg1 = Convert.ToInt32(Math.Floor(123.75));        // 123 (and not 124)
            int start = Convert.ToInt32(Math.Floor(Math.Sqrt(number)));

            for (int n = start - 1; 1 <= n; n--)
            {
                int product = n * n;

                //Console.WriteLine($"{n} x {n} = {n * n}, {IsPalindromicNumber(product)}");

                if (IsPalindromicNumber(product))
                {
                    return n;
                }
            }

            return 0;
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
