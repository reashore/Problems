using System;

namespace Problem2
{
    // ReSharper disable once ClassNeverInstantiated.Global
    internal class Program
    {
        private static void Main()
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
