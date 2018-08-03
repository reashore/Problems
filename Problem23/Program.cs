using System;
using System.Collections.Generic;

namespace Problem23
{
    // ReSharper disable once ClassNeverInstantiated.Global
    internal class Program
    {
        private enum PerfectType
        {
            Deficient,
            Perfect,
            Abundant
        }

        private static void Main()
        {
            Console.WriteLine("Problem 23");

            Test();
            long result = Solve();
            Console.WriteLine($"result = {result}");    

            Console.WriteLine("Done");
            Console.ReadKey();
        }

        private static void Test()
        {
            const long num = 28;
            long sumOfProperDivisors = SumOfProperDivisors(num);
            Console.WriteLine($"SumOfProperDivisors({num}) = {sumOfProperDivisors}");

            List<long> numbers = new List<long>
            {
                12,
                18,
                20,
                24,
                28,
                30,
                36
            };

            foreach (long number in numbers)
            {
                PerfectType perfectType = GetPerfectType(number);
                Console.WriteLine($"number = {number}, perfectType = {perfectType.ToString()}");
            }
        }

        private static long Solve()
        {
            long sum = 0;

            for (long n = 1; n <= 28123; n++)
            {
                bool hasAbundantAddends;

                checked
                {
                    hasAbundantAddends = HasAbundantAddends(n);
                }

                //Console.WriteLine($"{n}, {hasAbundantAddends}, {addend1} + {addend2} = {n}");

                if (n % 1000 == 0)
                {
                    Console.WriteLine($"{n}");
                }

                if (!hasAbundantAddends)
                {
                    sum += n;
                }
            }

            return sum;
        }

        private static bool HasAbundantAddends(long number)
        {
            for (long n = 12; n <= number - 12; n++)
            {
                long addend1 = n;
                long addend2 = number - n;

                if (IsAbundantNumber(addend1) && IsAbundantNumber(addend2))
                {
                    return true;
                }
            }

            return false;
        }

        private static bool IsAbundantNumber(long number)
        {
            return GetPerfectType(number) == PerfectType.Abundant;
        }

        private static PerfectType GetPerfectType(long number)
        {
            long sumOfDivisors = SumOfProperDivisors(number);

            if (number == sumOfDivisors)
            {
                return PerfectType.Perfect;
            }

            if (number > sumOfDivisors)
            {
                return PerfectType.Deficient;
            }

            return PerfectType.Abundant;
        }

        private static long SumOfProperDivisors(long number)
        {
            long sum = 0;

            for (long n = 1; n < number; n++)
            {
                if (number % n == 0)
                {
                    sum += n;
                }
            }

            return sum;
        }
    }
}
