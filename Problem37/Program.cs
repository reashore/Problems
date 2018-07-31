using System;
using System.Collections.Generic;

namespace Problem37
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Problem 37");

            //Test();

            const long upperBound = 1000000;
            (long, long) result = Solve(upperBound);
            long count = result.Item1;
            long sum = result.Item2;
            Console.WriteLine($"count = {count}, sum = {sum}");

            Console.WriteLine("Done");
            Console.ReadKey();
        }

        private static void Test()
        {
            long number = 3797;
            List<long> truncations = GetTruncations(number);
        }

        private static (long, long) Solve(long upperBound)
        {
            long sum = 0;
            long count = 0;

            for (long number = 8; number < upperBound; number++)
            {
                List<long> truncations = GetTruncations(number);

                bool allTruncationsArePrime = truncations.TrueForAll(IsPrime);

                if (allTruncationsArePrime)
                {
                    sum += number;
                    count++;
                    Console.WriteLine($"number = {number}");
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

        public static bool IsPrime(long candidate)
        {
            if ((candidate & 1) == 0)
            {
                if (candidate == 2)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }

            for (int i = 3; (i * i) <= candidate; i += 2)
            {
                if (candidate % i == 0)
                {
                    return false;
                }
            }

            return candidate != 1;
        }
    }
}
