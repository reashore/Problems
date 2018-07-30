using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace Problem32
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Problem 32");

            long productSum = Solve();
            Console.WriteLine($"productSum = {productSum}");    // 45228

            Console.WriteLine("Done");
            Console.ReadKey();
        }

        private static long Solve()
        {
            long upperBound = 987654321;
            double upperBoundDouble = Convert.ToDouble(upperBound);
            double squareRootDouble = Math.Sqrt(upperBoundDouble);
            double squareRootFloor = Math.Floor(squareRootDouble);
            long squareRootBound = Convert.ToInt64(squareRootFloor);

            Debug.Assert(squareRootBound * squareRootBound <= upperBound);
            Debug.Assert((squareRootBound + 1) * (squareRootBound + 1) >= upperBound);

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

                    if (IsPandigital(compositeString))
                    {
                        Console.WriteLine($"{n} x {m} = {product}");
                        pandigitalProductsList.Add(product);
                    }
                }
            }

            long productSum = pandigitalProductsList.Distinct().Sum(n => n);

            return productSum;
        }

        private static bool IsPandigital(int number)
        {
            // Contains every digit from 1 to 9 exactly once
            string numberString = number.ToString();
            return IsPandigital(numberString);
        }

        private static bool IsPandigital(string numberString)
        {
            if (numberString.Length != 9)
            {
                return false;
            }

            const string digits = "123456789";

            foreach (char digit in digits)
            {
                if (!numberString.Contains(digit))
                {
                    return false;
                }
            }

            return true;
        }
    }
}
