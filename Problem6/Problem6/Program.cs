using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem6
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Problem 6");

            Test();

            Console.WriteLine("Done");
            Console.ReadKey();
        }

        private static void Test()
        {
            List<int> numbers = new List<int>{ 10, 100, 1000 };

            foreach(int number in numbers)
            {
                int result = Solve(number);
                Console.WriteLine($"number = {number, 5}, result = {result, 20}");
            }
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
