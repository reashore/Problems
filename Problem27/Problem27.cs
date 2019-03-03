using Common;

namespace Problem27
{
    public static class Problem27
    {
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

                if (!Utilities.IsPrime(value))
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