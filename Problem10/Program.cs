using Common;
using static System.Console;

namespace Problem10
{
    // ReSharper disable once ClassNeverInstantiated.Global
    public class Program
    {
        public static void Main()
        {
            WriteLine("Problem 10");

            const int number = 2000000;
            long answer = Solve(number);
            WriteLine($"sumAllPrimes = {answer}");

            WriteLine("Done");
            ReadKey();
        }

        public static long Solve(int upperBound)
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
