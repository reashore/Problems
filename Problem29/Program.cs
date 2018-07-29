using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;

namespace Problem29
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Problem 29");

            Test();

            Console.WriteLine("Done");
            Console.ReadKey();
        }

        private static void Test()
        {
            int lowerBound = 2;
            int upperBound = 5;

            long distinctPowers = Solve(lowerBound, upperBound);
            Console.WriteLine($"distinctPowers = {distinctPowers}");

            lowerBound = 2;
            upperBound = 100;

            distinctPowers = Solve(lowerBound, upperBound);
            Console.WriteLine($"distinctPowers = {distinctPowers}");
        }

        private static long Solve(int lowerBound, int upperBound)
        {
            List<BigInteger> distinctPowers = new List<BigInteger>();

            for (int n = lowerBound; n <= upperBound; n++)
            {
                for (int m = lowerBound; m <= upperBound; m++)
                {
                    BigInteger value1 = n;
                    BigInteger value2 = m;

                    BigInteger power1 = BigInteger.Pow(value1, m);
                    BigInteger power2 = BigInteger.Pow(value2, n);

                    if (!distinctPowers.Contains(power1))
                    {
                        distinctPowers.Add(power1);
                    }

                    if (!distinctPowers.Contains(power2))
                    {
                        distinctPowers.Add(power2);
                    }
                }
            }

            //PrintDistinctPowers(distinctPowers);

            long count = distinctPowers.Count;

            return count;
        }

        private static void PrintDistinctPowers(List<BigInteger> distinctPowers)
        {
            var sortedDistinctPowers = distinctPowers.OrderBy(n => n);
            string line = "";

            foreach (BigInteger distinctPower in distinctPowers)
            {
                line += $"{distinctPower}, ";
            }

            Console.WriteLine(line);
        }
    }
}
