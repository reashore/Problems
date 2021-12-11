using System.Collections.Generic;
using System.Numerics;

namespace Problem29
{
    public static class Problem29
    {
        public static long Solve()
        {
            const int lowerBound = 2;
            const int upperBound = 100;
            List<BigInteger> distinctPowers = new();

            for (int n = lowerBound; n <= upperBound; n++)
            {
                for (int m = lowerBound; m <= upperBound; m++)
                {
                    BigInteger value1 = n;
                    BigInteger value2 = m;

                    BigInteger power1 = BigInteger.Pow(value1, m);
                    BigInteger power2 = BigInteger.Pow(value2, n);

                    if (!distinctPowers.Contains(power1))
                    {
                        distinctPowers.Add(power1);
                    }

                    if (!distinctPowers.Contains(power2))
                    {
                        distinctPowers.Add(power2);
                    }
                }
            }

            //Utilities.PrintList(distinctPowers);

            long count = distinctPowers.Count;

            return count;
        }
    }
}