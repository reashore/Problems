using System;
using System.Collections.Generic;

namespace Problem12
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Problem 12");

            TestTriangularNumbers();
            Test();

            Console.WriteLine("Done");
            Console.ReadKey();
        }

        private static void TestTriangularNumbers()
        {
            for (ulong n = 1; n <= 10; n++)
            {
                ulong triangularNumber = GetTriangleNumber(n);
                List<ulong> divisors = GetDivisors(triangularNumber);
                Console.WriteLine($"n = {n}, triangulatNumber = {triangularNumber}");
                divisors.ForEach(Console.WriteLine);
            }
        }

        private static void Test()
        {
            List<ulong> maxDivisorsList = new List<ulong> { 2, 4, 5, 500 };

            foreach (ulong maxDivisors in maxDivisorsList)
            {
                (ulong, ulong, ulong) result = GetTriangleNumberWithDivisors(maxDivisors);
                ulong number = result.Item1;
                ulong triangleNumber = result.Item2;
                ulong divisorCount = result.Item3;

                // GetTriangleNumber(12375) = 76576500, maxDivisors = 500 divisorCount = 576
                Console.WriteLine($"GetTriangleNumber({number}) = {triangleNumber}, maxDivisors = {maxDivisors} divisorCount = {divisorCount}");
            }
        }

        private static (ulong, ulong, ulong) GetTriangleNumberWithDivisors(ulong maxDivisors)
        {
            ulong number = 1;
            ulong triangleNumber;
            ulong divisorCount = 0;

            while (true)
            {
                checked
                {
                    triangleNumber = GetTriangleNumber(number);
                    divisorCount = GetDivisorsCount(triangleNumber);
                }

                if (maxDivisors < divisorCount)
                {
                    break;
                }

                number++;
            }

            return (number, triangleNumber, divisorCount);
        }

        private static ulong GetTriangleNumber(ulong number)
        {
            ulong sum = 0;

            for (ulong n = 1; n <= number; n++)
            {
                sum += n;
            }

            return sum;
        }

        private static List<ulong> GetDivisors(ulong number)
        {
            List<ulong> divisors = new List<ulong>();

            for (ulong n = 1; n <= number; n++)
            {
                if (number % n == 0)
                {
                    divisors.Add(n);
                }
            }

            return divisors;
        }

        private static ulong GetDivisorsCount(ulong number)
        {
            ulong divisorsCount = 0;

            for (ulong n = 1; n <= number; n++)
            {
                if (number % n == 0)
                {
                    divisorsCount++;
                }
            }

            return divisorsCount;
        }
    }
}
