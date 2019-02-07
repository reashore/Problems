using System.Collections.Generic;
using System.Numerics;
using static System.Console;

namespace Problem29
{
    // ReSharper disable once ClassNeverInstantiated.Global
    public class Program
    {
        public static void Main()
        {
            WriteLine("Problem 29");

            long distinctPowers = Solve();
            WriteLine($"distinctPowers = {distinctPowers}");

            WriteLine("Done");
            ReadKey();
        }

        public static long Solve()
        {
            const int lowerBound = 2;
            const int upperBound = 100;
            List<BigInteger> distinctPowers = new List<BigInteger>();

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
