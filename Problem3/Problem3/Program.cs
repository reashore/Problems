using System;
using System.Collections.Generic;

namespace Problem3
{
    // Find the largest prime factor of 600851475143.
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Problem 3");
            const long number = 600851475143;

            Test();

            long result = GetLargestPrimeFactorOf(number);
            Console.WriteLine($"result = {result}");

            Console.WriteLine("Done");
            Console.ReadKey();
        }

        private static long GetLargestPrimeFactorOf(long number)
        {
            long result = 1;

            for (long n = number - 1; 1 <= n; n--)
            {
                if (n % 100000000 == 0)
                {
                    Console.WriteLine($"{n}");
                }

                if (number % n == 0)
                {
                    result = n;
                    break;
                }
            }

            return result;
        }

        #region Test Code

        private static void Test()
        {
            for (int n = 1; n <= 20; n++)
            {
                List<long> primefactors = GetPrimeFactors(n);
                string primeFactorsString = ToString(primefactors);

                long largestPrimeFactor = GetLargestPrimeFactorOf(n);

                Console.WriteLine($"{n} : {primeFactorsString}, Largest = {largestPrimeFactor}");
            }
        }

        private static List<long> GetPrimeFactors(long number)
        {
            List<long> primeFactors = new List<long>();

            for (long n = 1; n <= number; n++)
            {
                if (number % n == 0)
                {
                    primeFactors.Add(n);
                }
            }

            return primeFactors;
        }

        private static string ToString(List<long> list)
        {
            string result = "";

            foreach(long item in list)
            {
                result += item.ToString() + " ";
            }

            return result;
        }

        #endregion
    }
}
