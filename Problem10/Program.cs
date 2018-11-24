using System.Collections.Generic;
using Common;
using static System.Console;

namespace Problem10
{
    // ReSharper disable once ClassNeverInstantiated.Global
    internal class Program
    {
        private static void Main()
        {
            WriteLine("Problem 10");

            //Test();
            Solve();

            WriteLine("Done");
            ReadKey();
        }

        //private static void Test()
        //{
        //    for (int n = 1; n < 100; n++)
        //    {
        //        bool isPrime = IsPrime(n);

        //        if (isPrime)
        //        {
        //            Console.WriteLine($"IsPrime2({n}) = true");
        //        }
        //    }
        //}

        private static void Solve()
        { 
            List<int> upperBounds = new List<int> { 10, 20, 30, 2000000 };

            foreach(int upperBound in upperBounds)
            {
                long sumAllPrimes = SumAllPrimes(upperBound);
                WriteLine($"sumAllPrimes = {sumAllPrimes}");
            }
        }

        private static long SumAllPrimes(int upperBound)
        {
            long sum = 0;

            for (int n = 2; n < upperBound; n++)
            {
                if (Utilities.IsPrime(n))
                {
                    sum += n;
                }
            }

            return sum;
        }
    }
}
