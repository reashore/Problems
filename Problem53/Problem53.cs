using System;
using System.Numerics;

namespace Problem53
{
    public static class Problem53
    {
        public static int Solve()
        {
            const int upperBound = 100;
            const int limit = 1_000_000;
            
            int count = 0;
            
            for (int n = 1; n <= upperBound; n++)
            {
                Console.WriteLine($"n = {n}");
                
                for (int r = 1; r <= n; r++)
                {
                    BigInteger combinatoric = GetCombinatoric(n, r);

                    if (combinatoric > limit)
                    {
                        count++;
                    }
                }
            }

            return count;
        }

        private static BigInteger GetCombinatoric(int n, int r)
        {
            BigInteger numerator = Factorial(n);
            BigInteger denominator = Factorial(r) * Factorial(n - r);
            BigInteger quotient = BigInteger.Divide(numerator, denominator);
            
            return quotient;
        }
        
        private static BigInteger Factorial(int n)
        {
            BigInteger factorial = 1;

            if (n == 0 || n == 1)
            {
                return factorial;
            }

            for (int i = 2; i <= n; i++)
            {
                BigInteger factor = new BigInteger(i);
                factorial *= factor;
            }

            return factorial;
        }
    }
}