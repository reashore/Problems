using System.Numerics;
using static System.Console;

namespace Problem48
{
    // ReSharper disable once ClassNeverInstantiated.Global
    public class Program
    {
        public static void Main()
        {
            WriteLine("Problem 48");

            string answer = Solve();
            WriteLine($"lastTenDigits = {answer}");        // 9110846700

            WriteLine("Done");
            ReadKey();
        }

        public static string Solve()
        {
            const int upperBound = 1000;
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
