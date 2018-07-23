using System;

namespace Problem2
{
    class Program
    {
        // Sum all even terms of the fibonacci series: 1, 2, 3, 5, 8, 13 ....
        // less than upperLimit
        static void Main()
        {
            Console.WriteLine("Problem 2");
            const int upperLimit = 4000000;

            int result = SumEvenFibonacci(upperLimit);
            Console.WriteLine($"result = { result}");

            Console.ReadKey();
        }

        private static int SumEvenFibonacci(int upperLimit)
        {
            int sum = 0;
            int x1 = 0;
            int x2 = 1;
            bool even = true;

            while (x2 < upperLimit)
            {
                sum = x1 + x2;
                Console.WriteLine($"{x1} + {x2} = {sum}, even = {even}");

                x1 = x2;
                x2 = sum;

                if (even)
                {
                    sum += x1;
                }

                even = !even;
            }

            return sum;
        }
    }
}
