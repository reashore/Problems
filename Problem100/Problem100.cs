
using System;

namespace Problem100
{
    public class Problem100
    {
        public static long Solve(int row, int col)
        {
            checked
            {
                bool firstRowPair = row % 2 == 1;
                int rowPair = row / 2 + (firstRowPair ? 1 : 0);
                long temp = rowPair - 1;
                long baseNumber = 10 * temp;
                int baseColValue = 2 * (col - 1) + (firstRowPair ? 0 : 1);
                long value = baseNumber + baseColValue;
                return value;
            }
        }

        public static void Test()
        {
            for (int row = 1; row <= 5; row++)
            {
                for (int col = 1; col <= 5; col++)
                {
                    long value = Solve(row, col);
                    Console.WriteLine($"value = {value}");
                }
            }
        }
    }
}
