using System.Collections.Generic;
using System.Linq;
using static Common.Utilities;
using static System.Console;

namespace Problem3
{
    // ReSharper disable once ClassNeverInstantiated.Global
    public  class Program
    {
        private static void Main()
        {
            WriteLine("Problem 3");
            const long number = 600851475143;

            long result = Solve(number);
            WriteLine($"largestPrimeFactor = {result}");    //  6857

            WriteLine("Done");
            ReadKey();
        }

        public static long Solve(long number)
        {
            List<long> primeFactors = GetPrimeFactors(number);
            long largestPrimeFactor = primeFactors.Max(n => n);
            return largestPrimeFactor;
        }
    }
}
