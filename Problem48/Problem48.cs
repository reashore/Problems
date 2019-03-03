using System.Numerics;

namespace Problem48
{
    public static class Problem48
    {
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