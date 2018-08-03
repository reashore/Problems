using System;

namespace Problem14
{
    // ReSharper disable once ClassNeverInstantiated.Global
    internal class Program
    {
        private static void Main()
        {
            Console.WriteLine("Problem 14");

            Solve();

            Console.WriteLine("Done");
            Console.ReadKey();
        }

        private static void Solve()
        {
            const long upperBound = 1000000;
            (long, long) result = GetLongestCollatzChain(upperBound);
            long start = result.Item1;
            long longestCollatzChain = result.Item2;
            Console.WriteLine($"start = {start}, longestCollatzChain = {longestCollatzChain}");
        }

        private static (long, long) GetLongestCollatzChain(long upperBound)
        {            
            long maxCollatzChainLength = 0;
            long chainStart = 0;

            for (long n = 2; n <= upperBound; n++)
            {
                long collatzChainLength = GetCollatzChainLength(n);

                if (collatzChainLength > maxCollatzChainLength)
                {
                    chainStart = n;
                    maxCollatzChainLength = collatzChainLength;
                }
            }

            return (chainStart, maxCollatzChainLength);
        }

        private static long GetCollatzChainLength(long start)
        {
            long n = start;
            long chainLength = 1;

            while (true)
            {
                long nextCollatzNumber = GetNextCollatzNumber(n);
                chainLength++;

                if (nextCollatzNumber == 1)
                {
                    break;
                }

                n = nextCollatzNumber;
            }

            return chainLength;
        }

        private static long GetNextCollatzNumber(long n)
        {
            if (n % 2 == 0)
            {
                return n / 2;
            }

            return 3 * n + 1;
        }
    }
}
