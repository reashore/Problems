using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;

namespace Problem16
{
    public static class Problem16
    {
        public static int Solve()
        {
            const int exponent = 1000;
            BigInteger product = new BigInteger(1);
            BigInteger two = new BigInteger(2);

            for (int n = 1; n <= exponent; n++)
            {
                product *= two;
            }

            string productString = product.ToString();
            List<int> productList = new List<int>();

            foreach (char c in productString)
            {
                int digit = Convert.ToInt32(c.ToString());
                productList.Add(digit);
            }

            int sumOfDigits = productList.Sum(n => n);

            return sumOfDigits;
        }
    }
}