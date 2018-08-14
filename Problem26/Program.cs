using System;
using System.Collections;
using System.Numerics;

namespace Problem26
{
    // https://www.mathblog.dk/project-euler-26-find-the-value-of-d-1000-for-which-1d-contains-the-longest-recurring-cycle/

    // https://www.xarg.org/puzzle/project-euler/problem-26/

    // https://eli.thegreenplace.net/2009/02/25/project-euler-problem-26

    // https://codeshelter.wordpress.com/2011/01/19/project-euler-26/

    // ReSharper disable once ClassNeverInstantiated.Global
    internal class Program
    {
        private static void Main()
        {
            Console.WriteLine("Problem 26");

            const int upperBound = 1000;
            string maxRecurringDecimalPattern = Solve(upperBound);
            Console.WriteLine($"maxRecurringDecimalPattern = {maxRecurringDecimalPattern}");

            Console.WriteLine("Done");
            Console.ReadKey();
        }

        private static string Solve(int upperBound)
        {
            int divideBy = 7;
            foreach (int fractionDecimal in GetDecimalsReversed(divideBy, divideBy * 2))
            {
                Console.WriteLine($"fractionDecimal = {fractionDecimal}");
            }


            return "";
        }

        private static IEnumerable GetDecimalsReversed(int denominator, int numberOfDecimals)
        {
            int exponent = numberOfDecimals;

            while (exponent > 0)
            {
                BigInteger fraction = BigInteger.Pow(10, --exponent) * 1 / denominator;
                BigInteger remainder = fraction % 10;
                yield return int.Parse(remainder.ToString());
            }
        }

        //private static IEnumerable GetDecimalsReversed(int numerator, int denominator, int numberOfDecimals)
        //{
        //    int exponent = numberOfDecimals;

        //    while (exponent > 0)
        //    {
        //        yield return int.Parse((((BigInteger.Pow(10, --exponent) * 1) / denominator) % (BigInteger)10).ToString());
        //    }
        //}
    }
}
