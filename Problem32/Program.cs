using System;
using System.Collections.Generic;
using System.Linq;
using static Common.Utilities;
using static System.Console;

namespace Problem32
{
    // ReSharper disable once ClassNeverInstantiated.Global
    public class Program
    {
        public static void Main()
        {
            WriteLine("Problem 32");

            long productSum = Solve();
            WriteLine($"productSum = {productSum}");    // 45228

            WriteLine("Done");
            ReadKey();
        }

        private static long Solve()
        {
            const long upperBound = 987654321;
            double upperBoundDouble = Convert.ToDouble(upperBound);
            double squareRootDouble = Math.Sqrt(upperBoundDouble);
            double squareRootFloor = Math.Floor(squareRootDouble);
            long squareRootBound = Convert.ToInt64(squareRootFloor);

            Assert(squareRootBound * squareRootBound <= upperBound);
            Assert((squareRootBound + 1) * (squareRootBound + 1) >= upperBound);

            List<long> pandigitalProductsList = new List<long>();

            for (int n = 1; n <= squareRootBound; n++)
            {
                for (int m = 1; m <= squareRootBound; m++)
                {
                    if (m > n)
                    {
                        continue;
                    }

                    int product = n * m;
                    string nString = n.ToString();
                    string mString = m.ToString();
                    string productString = product.ToString();
                    string compositeString = productString + nString + mString;

                    // ReSharper disable once InvertIf
                    if (IsPandigital(compositeString))
                    {
                        WriteLine($"{n} x {m} = {product}");
                        pandigitalProductsList.Add(product);
                    }
                }
            }

            long productSum = pandigitalProductsList.Distinct().Sum(n => n);

            return productSum;
        }
    }
}
