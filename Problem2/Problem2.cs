using System;

namespace Problem2
{
    public static class Problem2
    {
        public static int Solve()
        {
            const int upperLimit = 4000000;
            int x1 = 0;
            int x2 = 1;
            int sum = 0;

            while (x2 < upperLimit)
            {
                var fibonacci = x1 + x2;
                var isEven = fibonacci % 2 == 0;

                if (fibonacci % 2 == 0)
                {
                    sum += fibonacci;
                }

                Console.WriteLine($"{x1} + {x2} = {fibonacci}, isEven = {isEven}");

                x1 = x2;
                x2 = fibonacci;
            }

            return sum;
        }
    }
}