using System;
using System.Collections.Generic;
using System.Linq;
using Common;

namespace Problem49
{
    public static class Problem49
    {
        public static string Solve()
        {
            const int upperBound = 10000;
            string answer = "";

            for (int n = 1; n <= upperBound; n++)
            {
                int number1 = n;
                int number2 = number1 + 3330;
                int number3 = number2 + 3330;

                bool allNumbersArePrime = Utilities.IsPrime(number1) && Utilities.IsPrime(number2) && Utilities.IsPrime(number3);
                bool allNumbersArePermutationsOfEachOther = AllNumbersArePermutationsOfEachOther(number1, number2, number3);

                // ReSharper disable once InvertIf
                if (allNumbersArePrime && allNumbersArePermutationsOfEachOther)
                {
                    answer = $"{number1}{number2}{number3}";

                    // looking for the second 4-digit sequence
                    if (answer.Length == 12 && number1 != 1487)
                    {
                        break;
                    }
                }
            }

            return answer;
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

            string number1OrderedString = Utilities.ConvertListToString(number1OrderedList);
            string number2OrderedString = Utilities.ConvertListToString(number2OrderedList);
            string number3OrderedString = Utilities.ConvertListToString(number3OrderedList);

            bool areEqual = number1OrderedString == number2OrderedString &&
                            number2OrderedString == number3OrderedString;

            return areEqual;
        }

        private static IEnumerable<int> ConvertStringToList(string stringValue)
        {
            List<int> list = new();

            foreach (char character in stringValue)
            {
                int digit = Convert.ToInt32(character.ToString());
                list.Add(digit);
            }

            return list;
        }
    }
}