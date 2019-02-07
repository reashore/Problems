using System;
using System.Collections.Generic;
using static Common.Utilities;
using static System.Console;

namespace Problem37
{
    // ReSharper disable once ClassNeverInstantiated.Global
    public class Program
    {
        public static void Main()
        {
            WriteLine("Problem 37");

            Test();

            const long upperBound = 1000000;
            (long, long) result = Solve(upperBound);
            long count = result.Item1;
            long sum = result.Item2;
            WriteLine($"count = {count}, sum = {sum}");

            WriteLine("Done");
            ReadKey();
        }

        private static void Test()
        {
            const long number = 3797;
            List<long> truncations = GetTruncations(number);
            Assert(truncations.Count == 7);
        }

        private static (long, long) Solve(long upperBound)
        {
            long sum = 0;
            long count = 0;

            for (long number = 8; number < upperBound; number++)
            {
                List<long> truncations = GetTruncations(number);

                bool allTruncationsArePrime = truncations.TrueForAll(IsPrime);

                // ReSharper disable once InvertIf
                if (allTruncationsArePrime)
                {
                    sum += number;
                    count++;
                    WriteLine($"number = {number}");
                }
            }

            return (count, sum);
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
