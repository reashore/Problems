using System;
using Common;

namespace Problem5
{
    // ReSharper disable once ClassNeverInstantiated.Global
    internal class Program
    {
        private static void Main()
        {
            Console.WriteLine("Problem 5");

            Test();

            int smallestNumber = Solve();
            Console.WriteLine($"smallestNumber = {smallestNumber}");

            Console.WriteLine("Done");
            Console.ReadKey();
        }

        private static int Solve()
        {
            const int upperBound = 20;
            int number = 1;

            while (true)
            {
                if (IsNumberEvenlyDivisible(number, upperBound))
                {
                    return number;
                }

                number++;
            }
        }

        private static void Test()
        {
            int number = 2520;
            int upperBound = 10;
            bool result = IsNumberEvenlyDivisible(number, upperBound);
            Utilities.Assert(result);

            number = 232792560;
            upperBound = 20;
            result = IsNumberEvenlyDivisible(number, upperBound);
            Utilities.Assert(result);
        }

        private static bool IsNumberEvenlyDivisible(int number, int upperBound)
        {
            for (int n = 1; n <= upperBound; n++)
            {
                if (number % n != 0)
                {
                    return false;
                }
            }

            return true;
        }
    }
}
