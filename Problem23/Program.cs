using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem23
{
    class Program
    {
        enum PerfectType
        {
            Deficient,
            Perfect,
            Abundant
        }

        static void Main()
        {
            Console.WriteLine("Problem 23");

            //Test();
            long result = Solve();
            Console.WriteLine($"result = {result}");    // 4179595

            Console.WriteLine("Done");
            Console.ReadKey();
        }

        private static long Solve()
        {
            List<long> numbersWithoutAbundantAddends = new List<long>();

            for (long n = 24; n <= 28123; n++)
            {
                (bool, long, long) result = HasAbundantAddends(n);
                bool hasAbundantAddends = result.Item1;
                long addend1 = result.Item2;
                long addend2 = result.Item3;

                //Console.WriteLine($"{n}, {hasAbundantAddends}, {addend1}, {addend2}");

                if (n % 1000 == 0)
                {
                    Console.WriteLine($"{n}");
                }

                if (!hasAbundantAddends)
                {
                    numbersWithoutAbundantAddends.Add(n);
                }
            }

            long sum = numbersWithoutAbundantAddends.Sum(n => n);

            return sum;
        }

        private static (bool, long, long) HasAbundantAddends(long number)
        {
            for (long n = 12; n <= number - 12; n++)
            {
                long addend1 = n;
                long addend2 = number - n;
                // 12 <= number - n

                bool abundant1 = IsAbundantNumber(addend1);
                bool abundant2 = IsAbundantNumber(addend2);

                if (abundant1 && abundant2)
                {
                    return (true, addend1, addend2);
                }
            }

            return (false, 0, 0);
        }

        private static bool IsAbundantNumber(long number)
        {
            return GetPerfectType(number) == PerfectType.Abundant;
        }

        private static void Test()
        {
            const long num = 28;
            long sumOfProperDivisors = SumOfProperDivisors(num);
            Console.WriteLine($"SumOfProperDivisors({num}) = {sumOfProperDivisors}");

            List<long> numbers = new List<long>
            {
                12,
                28
            };

            foreach(long number in numbers)
            {
                PerfectType perfectType = GetPerfectType(number);
                Console.WriteLine($"number = {number}, perfectType = {perfectType.ToString()}");
            }
        }

        private static PerfectType GetPerfectType(long number)
        {
            long sumOfDivisors = SumOfProperDivisors(number);

            if (number == sumOfDivisors)
            {
                return PerfectType.Perfect;
            }
            else if (number > sumOfDivisors)
            {
                return PerfectType.Deficient;
            }
            else
            {
                return PerfectType.Abundant;
            }
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
