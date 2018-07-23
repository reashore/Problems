using System;
using System.Collections.Generic;

namespace Problem12
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Problem 12");
            const int maxDivisors = 500;

            var result = GetTriangleNumberWithDivisors(maxDivisors);
            int number = result.Item1;
            int triangleNumber = result.Item2;
            int divisorCount = result.Item3;

            // GetTriangleNumber(12375) = 76576500, divisorCount = 576
            Console.WriteLine($"GetTriangleNumber({number}) = {triangleNumber}, divisorCount = {divisorCount}");
            Console.WriteLine("Done");
            Console.ReadKey();
        }

        private static (int, int, int) GetTriangleNumberWithDivisors(int maxDivisors)
        {
            int number = 1;
            int triangleNumber;
            int divisorCount = 0;

            while (true)
            {
                triangleNumber = GetTriangleNumber(number);
                var divisors = GetDivisors(triangleNumber);
                divisorCount = divisors.Count;

                if (maxDivisors < divisorCount)
                {
                    break;
                }

                number++;
            }

            return (number, triangleNumber, divisorCount);
        }

        private static List<int> GetDivisors(int number)
        {
            List<int> divisors = new List<int>();

            for (int n = 1; n <= number; n++)
            {
                if (number % n == 0)
                {
                    divisors.Add(n);
                }
            }

            return divisors;
        }

        private static int GetTriangleNumber(int number)
        {
            int sum = 0;

            for (int n = 1; n <= number; n++)
            {
                sum += n;
            }

            return sum;
        }

        public static List<int> GetPrimeFactors(int number)
        {
            var primes = new List<int>();

            for (int divor = 2; divor <= number; divor++)
            {
                while (number % divor == 0)
                {
                    primes.Add(divor);
                    number = number / divor;
                }
            }

            return primes;
        }
    }
}
