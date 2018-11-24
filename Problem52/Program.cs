using System.Collections.Generic;
using System.Linq;
using static Common.Utilities;
using static System.Console;

namespace Problem52
{
    // ReSharper disable once ClassNeverInstantiated.Global
    internal class Program
    {
        private static void Main()
        {
            WriteLine("Problem 52");

            Test();

            const ulong upperBound = 1000000;
            ulong result = Solve(upperBound);
            WriteLine($"result = {result}");    // 142857

            WriteLine("Done");
            ReadKey();
        }

        private static void Test()
        {
            const ulong number = 125874;
            const ulong number2 = number * 2;

            List<int> numberDigits = GetDistinctSortedDigits(number);
            bool numbersContainSameDigits = DoNumbersContainSameDigits(numberDigits, number2);
            Assert(numbersContainSameDigits);
        }

        private static ulong Solve(ulong upperBound)
        {
            ulong numberWithSameDigitsProperty = 0;

            for (ulong number = 100; number < upperBound; number++)
            {
                ulong number2 = number * 2;
                ulong number3 = number * 3;
                ulong number4 = number * 4;
                ulong number5 = number * 5;
                ulong number6 = number * 6;

                List<int> number2Digits = GetDistinctSortedDigits(number2);

                if (!DoNumbersContainSameDigits(number2Digits, number3))
                {
                    continue;
                }

                if (!DoNumbersContainSameDigits(number2Digits, number4))
                {
                    continue;
                }

                if (!DoNumbersContainSameDigits(number2Digits, number5))
                {
                    continue;
                }

                if (!DoNumbersContainSameDigits(number2Digits, number6))
                {
                    continue;
                }

                numberWithSameDigitsProperty = number;
                break;
            }

            return numberWithSameDigitsProperty;
        }

        private static bool DoNumbersContainSameDigits(IReadOnlyList<int> numberDigits, ulong otherNumber)
        {
            List<int> otherNumberDigits = GetDistinctSortedDigits(otherNumber);

            if (numberDigits.Count != otherNumberDigits.Count)
            {
                return false;
            }

            int numberDigitsCount = numberDigits.Count;

            for (int n = 0; n < numberDigitsCount; n++)
            {
                if (numberDigits[n] != otherNumberDigits[n])
                {
                    return false;
                }
            }

            return true;
        }

        private static List<int> GetDistinctSortedDigits(ulong number)
        {
            string numberString = number.ToString();
            List<int> digitList = ConvertNumericStringToList(numberString);
            List<int> distinctOrderedDigitList = digitList.Distinct().OrderBy(n => n).ToList();

            return distinctOrderedDigitList;
        }
    }
}
