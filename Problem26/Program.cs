using System.Collections.Generic;
using System.Numerics;
using static Common.Utilities;
using static System.Console;

namespace Problem26
{
    // https://www.mathblog.dk/project-euler-26-find-the-value-of-d-1000-for-which-1d-contains-the-longest-recurring-cycle/

    // https://www.xarg.org/puzzle/project-euler/problem-26/

    // https://eli.thegreenplace.net/2009/02/25/project-euler-problem-26

    // https://codeshelter.wordpress.com/2011/01/19/project-euler-26/

    // http://thecprojectt.blogspot.com/2014/10/reciprocal-cycles-problem-26-project.html

    // ReSharper disable once ClassNeverInstantiated.Global
    public class Program
    {
        public static void Main()
        {
            WriteLine("Problem 26");

            Test();

            const int upperBound = 1000;
            (long, long, string) result = Solve(upperBound);
            long maxDenominator = result.Item1;
            long maxDigitStringLength = result.Item2;
            string maxDigitString = result.Item3;

            WriteLine($"maxDenominator = {maxDenominator}, maxDigitStringLength = {maxDigitStringLength}, maxDigitString = {maxDigitString}");

            WriteLine("Done");
            ReadKey();
        }

        private static void Test()
        {
            // 1/2 = 0.5(0)
            string repeatingDigitList = GetRepeatingDecimalDigits(2);
            PrintList(repeatingDigitList);
            Assert(repeatingDigitList.Length == 1);

            // 1/3 = 0.(3)
            repeatingDigitList = GetRepeatingDecimalDigits(3);
            PrintList(repeatingDigitList);
            Assert(repeatingDigitList.Length == 1);
            
            // 1/4 = 0.25(0)
            repeatingDigitList = GetRepeatingDecimalDigits(4);
            PrintList(repeatingDigitList);
            Assert(repeatingDigitList.Length == 1);

            // 1/5 = 0.2(0)
            repeatingDigitList = GetRepeatingDecimalDigits(5);
            PrintList(repeatingDigitList);
            Assert(repeatingDigitList.Length == 1);

            // 1/6 = 0.1(6)
            repeatingDigitList = GetRepeatingDecimalDigits(6);
            PrintList(repeatingDigitList);
            Assert(repeatingDigitList.Length == 1);

            // 1/7 = 0.(142857)
            repeatingDigitList = GetRepeatingDecimalDigits(7);
            PrintList(repeatingDigitList);
            Assert(repeatingDigitList.Length == 6);

            // 1/8 = 0.125(0)
            repeatingDigitList = GetRepeatingDecimalDigits(8);
            PrintList(repeatingDigitList);
            Assert(repeatingDigitList.Length == 1);

            // 1/9 = 0.(1)
            repeatingDigitList = GetRepeatingDecimalDigits(9);
            PrintList(repeatingDigitList);
            Assert(repeatingDigitList.Length == 1);

            // 1/10 = 0.1(0)
            repeatingDigitList = GetRepeatingDecimalDigits(10);
            PrintList(repeatingDigitList);
            Assert(repeatingDigitList.Length == 1);

            // 1/983 = 0.??
            repeatingDigitList = GetRepeatingDecimalDigits(983);
            PrintList(repeatingDigitList);
            Assert(repeatingDigitList.Length == 985);
        }

        private static (long, long, string) Solve(int upperBound)
        {
            int maxRepeatingDigitStringLength = 0;
            string maxRepeatingDigitString = "";
            int maxRepeatingDenominator = 0;

            for (int denominator = 2; denominator < upperBound; denominator++)
            {
                string repeatingDigitString = GetRepeatingDecimalDigits(denominator);
                int repeatinDigitStringLength = repeatingDigitString.Length;

                // ReSharper disable once InvertIf
                if (repeatinDigitStringLength > maxRepeatingDigitStringLength)
                {
                    maxRepeatingDigitStringLength = repeatinDigitStringLength;
                    maxRepeatingDigitString = repeatingDigitString;
                    maxRepeatingDenominator = denominator;

                    WriteLine($"maxRepeatingDenominator = {maxRepeatingDenominator}, maxRepeatingDigitStringLength = {maxRepeatingDigitStringLength}, maxRepeatingDigitString = {maxRepeatingDigitString}");
                }
            }

            return (maxRepeatingDenominator, maxRepeatingDigitStringLength, maxRepeatingDigitString);
        }

        private static string GetRepeatingDecimalDigits(int denominator)
        {
            List<int> digitList1 = new List<int>();
            List<int> digitList2 = new List<int>();
            int power = 1;

            // first pass through repeating digits
            // may contain a non-repeating prefix, as in 1/6 = 0.166666... = 0.1(6)
            while (true)
            {
                BigInteger numerator = BigInteger.Pow(10, power);
                BigInteger fraction =  numerator / denominator;
                BigInteger remainder = fraction % 10;
                int digit = int.Parse(remainder.ToString());

                if (digitList1.Contains(digit))
                {
                    break;
                }

                digitList1.Add(digit);
                power++;
            }

            // second pass through repeating digits
            while (true)
            {
                BigInteger numerator = BigInteger.Pow(10, power);
                BigInteger fraction =  numerator / denominator;
                BigInteger remainder = fraction % 10;
                int digit = int.Parse(remainder.ToString());

                if (digitList2.Contains(digit))
                {
                    break;
                }

                digitList2.Add(digit);
                power++;
            }

            // repeating digits with the non-repeating prefix are in digitList2
            string digitList2String = ConvertListToString(digitList2);

            return digitList2String;
        }
    }
}
