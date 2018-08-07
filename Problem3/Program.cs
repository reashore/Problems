using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem3
{
    // Find the largest prime factor of 600851475143.
    // ReSharper disable once ClassNeverInstantiated.Global
    internal class Program
    {
        private static void Main()
        {
            Console.WriteLine("Problem 3");
            const long number = 600851475143;

            List<long> primeFactors = GetPrimeFactors(number);
            long largestPrimeFactor = primeFactors.Max(n => n);
            Console.WriteLine($"largestPrimeFactor = {largestPrimeFactor}");    //  6857

            Console.WriteLine("Done");
            Console.ReadKey();
        }

        // ReSharper disable once ReturnTypeCanBeEnumerable.Local
        private static List<long> GetPrimeFactors(long number)
        {
            List<long> primes = new List<long>();

            for (long divsor = 2; divsor <= number; divsor++)
            {
                while (number % divsor == 0)
                {
                    primes.Add(divsor);
                    number = number / divsor;
                }
            }

            return primes;
        }
    }
}
