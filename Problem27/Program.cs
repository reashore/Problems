using static Common.Utilities;
using static System.Console;

namespace Problem27
{
    // ReSharper disable once ClassNeverInstantiated.Global
    public class Program
    {
        public static void Main()
        {
            WriteLine("Problem 27");

            long answer = Solve();
            WriteLine($"answer = {answer}");

            WriteLine("Done");
            ReadKey();
        }

        public static long Solve()
        {
            const long upperLimit = 1000;
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

                        //WriteLine($"a = {aMax, 6}, b = {bMax, 6}, maxPrimes = {maxNumberConsecutivePrimes, 10}");
                    }
                }
            }

            long answer = aMax * bMax;

            return answer;
        }

        private static long FindNumberConsecutivePrimesForQuadratic(long a, long b)
        {
            long number = 0;

            while (true)
            {
                long value = Quadratic(number, a, b);

                if (!IsPrime(value))
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
