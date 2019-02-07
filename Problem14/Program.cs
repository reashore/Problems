using static System.Console;

namespace Problem14
{
    // ReSharper disable once ClassNeverInstantiated.Global
    public class Program
    {
        public static void Main()
        {
            WriteLine("Problem 14");

            long answer = Solve();
            WriteLine($"answer = {answer}");

            WriteLine("Done");
            ReadKey();
        }

        public static long Solve()
        {
            const long upperBound = 1000000;
            var start = GetLongestCollatzChain(upperBound);
            return start;
        }

        private static long GetLongestCollatzChain(long upperBound)
        {            
            long maxCollatzChainLength = 0;
            long chainStart = 0;

            for (long n = 2; n <= upperBound; n++)
            {
                long collatzChainLength = GetStartingNumberWithCollatzChainLength(n);

                // ReSharper disable once InvertIf
                if (collatzChainLength > maxCollatzChainLength)
                {
                    chainStart = n;
                    maxCollatzChainLength = collatzChainLength;
                }
            }

            return chainStart;
        }

        private static long GetStartingNumberWithCollatzChainLength(long start)
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
