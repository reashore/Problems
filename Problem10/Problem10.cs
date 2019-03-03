using Common;

namespace Problem10
{
    public static class Problem10
    {
        public static long Solve()
        {
            const int upperBound = 2000000;
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