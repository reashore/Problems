using System;
using Common;

namespace Problem27
{
    // ReSharper disable once ClassNeverInstantiated.Global
    internal class Program
    {
        private static void Main()
        {
            Console.WriteLine("Problem 27");

            Test();

            const long upperLimit = 1000;
            (long, long, long) result = Solve(upperLimit);
            long a = result.Item1;
            long b = result.Item2;
            long maxPrimes = result.Item3;
            long product = a * b;

            Console.WriteLine($"a = {a}, b ={b}, maxPrimes = {maxPrimes}, a * b = {product}");

            Console.WriteLine("Done");
            Console.ReadKey();
        }

        private static void Test()
        {
            for (int n = 1; n < 100; n++)
            {
                bool success = MathUtilities.IsPrime(n) == MathUtilities.IsPrime(-n);

                if (!success)
                {
                    Console.WriteLine($"IsPrime({n}) = {MathUtilities.IsPrime(n)}, IsPrime({-n}) = {MathUtilities.IsPrime(-n)}");
                }
            }

            if (FindNumberConsecutivePrimesForQuadratic(1, 41) != 40)
            {
                Console.WriteLine("FindNumberConsecutivePrimesForQuadratic(1, 41) failed");
            }

            if (FindNumberConsecutivePrimesForQuadratic(-61, 971) != 71)
            {
                Console.WriteLine("FindNumberConsecutivePrimesForQuadratic(-61, 971) failed");
            }

            if (FindNumberConsecutivePrimesForQuadratic(-79, 1601) != 80)
            {
                Console.WriteLine("FindNumberConsecutivePrimesForQuadratic(-79, 1601) failed");
            }
        }

        private static (long, long, long) Solve(long upperLimit)
        {
            long maxNumberConsecutivePrimes = 0;
            long aMax = 0;
            long bMax = 0;

            for (long a = -upperLimit + 1; a < upperLimit; a++)
            {
                for (long b = -upperLimit; b <= upperLimit; b++)
                {
                    long numberConsecutivePrimes = FindNumberConsecutivePrimesForQuadratic(a, b);

                    // ReSharper disable once InvertIf
                    if (numberConsecutivePrimes > maxNumberConsecutivePrimes)
                    {
                        maxNumberConsecutivePrimes = numberConsecutivePrimes;
                        aMax = a;
                        bMax = b;

                        Console.WriteLine($"a = {aMax, 6}, b = {bMax, 6}, maxPrimes = {maxNumberConsecutivePrimes, 10}");
                    }
                }
            }

            return (aMax, bMax, maxNumberConsecutivePrimes);
        }

        private static long FindNumberConsecutivePrimesForQuadratic(long a, long b)
        {
            long number = 0;

            while (true)
            {
                long value = Quadratic(number, a, b);

                if (!MathUtilities.IsPrime(value))
                {
                    break;    
                }

                number++;
            }

            return number;
        }

        private static long Quadratic(long n, long a, long b) => n * n + a * n + b;
    }
}
