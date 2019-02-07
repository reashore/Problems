using System.Numerics;
using static Common.Utilities;
using static System.Console;

namespace Problem48
{
    // ReSharper disable once ClassNeverInstantiated.Global
    public class Program
    {
        public static void Main()
        {
            WriteLine("Problem 48");
            Test();

            const int upperBound = 1000;
            string lastTenDigits = Solve(upperBound);
            WriteLine($"lastTenDigits = {lastTenDigits}");
            Assert(lastTenDigits == "9110846700");

            WriteLine("Done");
            ReadKey();
        }

        private static void Test()
        {
            const int upperBound = 10;
            BigInteger sum = 0;

            for (int n = 1; n <= upperBound; n++)
            {
                sum += BigInteger.Pow(n, n);
            }

            Assert(sum.ToString() == "10405071317");
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
