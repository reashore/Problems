using System;
using System.Collections.Generic;
using Common;

namespace Problem37
{
    public static class Problem37
    {
        public static long Solve()
        {
            const long upperBound = 1000000;
            long sum = 0;

            for (long number = 8; number < upperBound; number++)
            {
                List<long> truncations = GetTruncations(number);

                bool allTruncationsArePrime = truncations.TrueForAll(Utilities.IsPrime);

                // ReSharper disable once InvertIf
                if (allTruncationsArePrime)
                {
                    sum += number;
                    //WriteLine($"number = {number}");
                }
            }

            return sum;
        }

        private static List<long> GetTruncations(long number)
        {
            string numberString = number.ToString();
            int length = numberString.Length;
            List<long> truncations = new List<long>{ number };

            if (length == 1)
            {
                return truncations;
            }

            // Left to right
            // 3797, 797, 97, 7
            for (int n = 1; n < length; n++)
            {
                string substring = numberString.Substring(n);
                int value = Convert.ToInt32(substring);

                if (!truncations.Contains(value))
                {
                    truncations.Add(value);
                }
            }

            // Right to left
            // 3797, 379, 37, 3
            for (int n = length - 1; 0 < n; n--)
            {
                string substring = numberString.Substring(0, n);
                int value = Convert.ToInt32(substring);

                if (!truncations.Contains(value))
                {
                    truncations.Add(value);
                }
            }

            return truncations;
        }
    }
}