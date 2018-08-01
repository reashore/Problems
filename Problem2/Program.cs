using System;

namespace Problem2
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Problem 2");
            const int upperLimit = 4000000;

            int sumOfEvenTerms = SumEvenFibonacci(upperLimit);
            Console.WriteLine($"sumOfEvenTerms = { sumOfEvenTerms}");

            Console.WriteLine("Done");
            Console.ReadKey();
        }

        private static int SumEvenFibonacci(int upperLimit)
        {
            int fibonacci = 0;
            int x1 = 0;
            int x2 = 1;
            bool isEven;
            int sum = 0;

            while (x2 < upperLimit)
            {
                fibonacci = x1 + x2;
                isEven = fibonacci % 2 == 0;

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
