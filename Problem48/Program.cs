using System;
using System.Diagnostics;
using System.Numerics;

namespace Problem48
{
    // ReSharper disable once ClassNeverInstantiated.Global
    internal class Program
    {
        private static void Main()
        {
            Console.WriteLine("Problem 48");
            Test();

            const int upperBound = 1000;
            string lastTenDigits = Solve(upperBound);
            Console.WriteLine($"lastTenDigits = {lastTenDigits}");
            Debug.Assert(lastTenDigits == "9110846700");

            Console.WriteLine("Done");
            Console.ReadKey();
        }

        private static void Test()
        {
            const int upperBound = 10;
            BigInteger sum = 0;

            for (int n = 1; n <= upperBound; n++)
            {
                sum += BigInteger.Pow(n, n);
            }

            Debug.Assert(sum.ToString() == "10405071317");
        }

        private static string Solve(int upperBound)
        {
            BigInteger sum = 0;

            for (int n = 1; n <= upperBound; n++)
            {
                sum += BigInteger.Pow(n, n);
            }

            string sumString = sum.ToString();
            int length = sumString.Length;
            string lastTenDigits = sumString.Substring(length - 10);

            return lastTenDigits;
        }
    }
}
