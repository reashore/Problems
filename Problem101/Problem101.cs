using System;

namespace Problem101
{
    public class Problem101
    {
        public static long Solve(int n)
        {
            return (long) n * n * n;
        }

        //public static int Solve(int n)
        //{
        //    int groupFirstIndex = n * (n - 1) + 1;
        //    int sum = groupFirstIndex * n + n * (n - 1);

        //    return sum;
        //}

        public static void Test()
        {
            for (int n = 1; n <= 6; n++)
            {
                int groupFirstIndex = n * (n - 1) + 1;
                int sum = groupFirstIndex * n + n * (n - 1);
                int sum2 = n * n * n;

                string message = $"groupFirstIndex = {groupFirstIndex}, sum = {sum}, sum2 = {sum2}";
                Console.WriteLine(message);
            }
        }
    }
}
