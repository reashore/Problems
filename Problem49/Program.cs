using System;
using System.Collections.Generic;
using System.Linq;
using static Common.Utilities;
using static System.Console;

namespace Problem49
{
    // ReSharper disable once ClassNeverInstantiated.Global
    public class Program
    {
        private static void Main()
        {
            WriteLine("Problem 49");

            const int upperBound = 10000;
            string concatenation = Solve(upperBound);
            WriteLine($"Concatenation = {concatenation}");      // 296962999629

            WriteLine("Done");
            ReadKey();
        }

        private static string Solve(int upperBound)
        {
            string result = "";

            for (int n = 1; n <= upperBound; n++)
            {
                int number1 = n;
                int number2 = number1 + 3330;
                int number3 = number2 + 3330;

                bool allNumbersArePrime = IsPrime(number1) && IsPrime(number2) && IsPrime(number3);
                bool allNumbersArePermutationsOfEachOther = AllNumbersArePermutationsOfEachOther(number1, number2, number3);

                // ReSharper disable once InvertIf
                if (allNumbersArePrime && allNumbersArePermutationsOfEachOther)
                {
                    result = $"{number1}{number2}{number3}";

                    // looking for the second 4-digit sequence
                    if (result.Length == 12 && number1 != 1487)
                    {
                        break;
                    }
                }
            }

            return result;
        }

        private static bool AllNumbersArePermutationsOfEachOther(int number1, int number2, int number3)
        {
            string number1String = number1.ToString();
            string number2String = number2.ToString();
            string number3String = number3.ToString();

            IEnumerable<int> number1List = ConvertStringToList(number1String);
            IEnumerable<int> number2List = ConvertStringToList(number2String);
            IEnumerable<int> number3List = ConvertStringToList(number3String);

            List<int> number1OrderedList = number1List.OrderBy(p => p).ToList();
            List<int> number2OrderedList = number2List.OrderBy(p => p).ToList();
            List<int> number3OrderedList = number3List.OrderBy(p => p).ToList();

            string number1OrderedString = ConvertListToString(number1OrderedList);
            string number2OrderedString = ConvertListToString(number2OrderedList);
            string number3OrderedString = ConvertListToString(number3OrderedList);

            bool areEqual = number1OrderedString == number2OrderedString &&
                            number2OrderedString == number3OrderedString;

            return areEqual;
        }

        private static IEnumerable<int> ConvertStringToList(string stringValue)
        {
            List<int> list = new List<int>();

            foreach (char character in stringValue)
            {
                int digit = Convert.ToInt32(character.ToString());
                list.Add(digit);
            }

            return list;
        }
    }
}
