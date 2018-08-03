using System;
using System.Collections.Generic;

namespace Problem10
{
    // ReSharper disable once ClassNeverInstantiated.Global
    internal class Program
    {
        private static void Main()
        {
            Console.WriteLine("Problem 10");

            //Test();
            Solve();

            Console.WriteLine("Done");
            Console.ReadKey();
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
                Console.WriteLine($"sumAllPrimes = {sumAllPrimes}");
            }
        }

        private static long SumAllPrimes(int upperBound)
        {
            long sum = 0;

            for (int n = 2; n < upperBound; n++)
            {
                if (IsPrime(n))
                {
                    sum += n;
                }
            }

            return sum;
        }

        private static bool IsPrime(int candidate)
        {
            if ((candidate & 1) == 0)
            {
                return candidate == 2;
            }

            for (int i = 3; i * i <= candidate; i += 2)
            {
                if (candidate % i == 0)
                {
                    return false;
                }
            }

            return candidate != 1;
        }
    }
}
