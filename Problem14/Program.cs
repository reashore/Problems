using static System.Console;

namespace Problem14
{
    // ReSharper disable once ClassNeverInstantiated.Global
    public class Program
    {
        public static void Main()
        {
            WriteLine("Problem 14");

            Solve();

            WriteLine("Done");
            ReadKey();
        }

        private static void Solve()
        {
            const long upperBound = 1000000;
            (long, long) result = GetLongestCollatzChain(upperBound);
            long start = result.Item1;
            long longestCollatzChain = result.Item2;
            WriteLine($"start = {start}, longestCollatzChain = {longestCollatzChain}");
        }

        private static (long, long) GetLongestCollatzChain(long upperBound)
        {            
            long maxCollatzChainLength = 0;
            long chainStart = 0;

            for (long n = 2; n <= upperBound; n++)
            {
                long collatzChainLength = GetCollatzChainLength(n);

                // ReSharper disable once InvertIf
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
