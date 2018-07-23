using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem6
{
    class Program
    {
        // Problem 6 www.eulerproject.net
        static void Main()
        {
            Console.WriteLine("Problem 6");

            int number = 10;
            int result = Solve(number);
            Console.WriteLine($"number = {number, 5}, result = {result, 20}");

            number = 100;
            result = Solve(number);
            Console.WriteLine($"number = {number, 5}, result = {result, 20}");

            number = 1000;
            result = Solve(number);
            Console.WriteLine($"number = {number,5}, result = {result,20}");

            Console.WriteLine("Done");
            Console.ReadKey();
        }

        private static int Solve(int number)
        {
            IEnumerable<int> sequence = Enumerable.Range(1, number);

            int sumOfTerms = sequence.Sum(n => n);
            int sumOfTermsSquared = sequence.Sum(n => n * n);

            int difference = sumOfTerms * sumOfTerms - sumOfTermsSquared;

            return difference;
        }
    }
}
