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

            Test();

            Solve();

            Console.WriteLine("Done");
            Console.ReadKey();
        }

        private static void Solve()
        {
            //for (int n = 1; n <= 28123; n++)
            //{
            //    PerfectType perfectType = GetPerfectType(number);


            //}
        }

        private static void Test()
        {
            List<int> numbers = new List<int>
            {
                12,
                28
            };

            foreach(int number in numbers)
            {
                PerfectType perfectType = GetPerfectType(number);
                Console.WriteLine($"perfectType = {perfectType.ToString()}");
            }
        }

        private static PerfectType GetPerfectType(int number)
        {
            List<int> properDivisors = GetProperDivisors(number);
            int sumOfDivisors = properDivisors.Sum(n => n);

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

        private static List<int> GetProperDivisors(int number)
        {
            List<int> divisors = new List<int>();

            for (int n = 1; n < number; n++)
            {
                if (number % n == 0)
                {
                    divisors.Add(n);
                }
            }

            return divisors;
        }
    }
}
