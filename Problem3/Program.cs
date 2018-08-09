using System;
using System.Collections.Generic;
using System.Linq;
using Common;

namespace Problem3
{
    // ReSharper disable once ClassNeverInstantiated.Global
    internal class Program
    {
        private static void Main()
        {
            Console.WriteLine("Problem 3");
            const long number = 600851475143;

            List<long> primeFactors = MathUtilities.GetPrimeFactors(number);
            long largestPrimeFactor = primeFactors.Max(n => n);
            Console.WriteLine($"largestPrimeFactor = {largestPrimeFactor}");    //  6857

            Console.WriteLine("Done");
            Console.ReadKey();
        }
    }
}
