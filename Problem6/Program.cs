using System.Collections.Generic;
using System.Linq;
using static System.Console;

namespace Problem6
{
    // ReSharper disable once ClassNeverInstantiated.Global
    public class Program
    {
        private static void Main()
        {
            WriteLine("Problem 6");

            const int number = 100;
            int result = Solve(number);
            WriteLine($"number = {number, 5}, result = {result, 20}");

            WriteLine("Done");
            ReadKey();
        }

        public static int Solve(int number)
        {
            IEnumerable<int> sequence = Enumerable.Range(1, number);

            // ReSharper disable once PossibleMultipleEnumeration
            int sumOfTerms = sequence.Sum(n => n);
            // ReSharper disable once PossibleMultipleEnumeration
            int sumOfTermsSquared = sequence.Sum(n => n * n);

            int difference = sumOfTerms * sumOfTerms - sumOfTermsSquared;

            return difference;
        }
    }
}
