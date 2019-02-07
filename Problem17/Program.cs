using System.Collections.Generic;
using System.Text;
using static System.Console;

namespace Problem17
{
    // ReSharper disable once ClassNeverInstantiated.Global
    public class Program
    {
        private static void Main()
        {
            WriteLine("Problem 17");

            SortedDictionary<int, string> numbersDictionary = new SortedDictionary<int, string>();

            AssignBasicNumbers(numbersDictionary);
            AssignNumbers21To99(numbersDictionary);
            AssignNumbers101To999(numbersDictionary);
            Print(numbersDictionary);
            int letterCount = CountLetters(numbersDictionary);
            WriteLine($"letterCount = {letterCount}");      // 21124

            WriteLine("Done");
            ReadKey();
        }

        private static void AssignBasicNumbers(IDictionary<int, string> numbersDictionary)
        {
            numbersDictionary[1] = "one";
            numbersDictionary[2] = "two";
            numbersDictionary[3] = "three";
            numbersDictionary[4] = "four";
            numbersDictionary[5] = "five";
            numbersDictionary[6] = "six";
            numbersDictionary[7] = "seven";
            numbersDictionary[8] = "eight";
            numbersDictionary[9] = "nine";
            numbersDictionary[10] = "ten";

            numbersDictionary[11] = "eleven";
            numbersDictionary[12] = "twelve";
            numbersDictionary[13] = "thirteen";
            numbersDictionary[14] = "fourteen";
            numbersDictionary[15] = "fifteen";
            numbersDictionary[16] = "sixteen";
            numbersDictionary[17] = "seventeen";
            numbersDictionary[18] = "eighteen";
            numbersDictionary[19] = "nineteen";

            numbersDictionary[20] = "twenty";
            numbersDictionary[30] = "thirty";
            numbersDictionary[40] = "forty";
            numbersDictionary[50] = "fifty";
            numbersDictionary[60] = "sixty";
            numbersDictionary[70] = "seventy";
            numbersDictionary[80] = "eighty";
            numbersDictionary[90] = "ninety";

            numbersDictionary[1000] = "one thousand";
        }

        private static void AssignNumbers21To99(IDictionary<int, string> numbersDictionary)
        {
            for (int start = 20; start <= 90; start += 10)
            {
                string prefix = numbersDictionary[start] + " ";

                for (int n = 1; n <= 9; n++)
                {
                    numbersDictionary[start + n] = prefix + numbersDictionary[n];
                }
            }
        }

        private static void AssignNumbers101To999(IDictionary<int, string> numbersDictionary)
        {
            for (int start = 100; start <= 900; start += 100)
            {
                string hundred = numbersDictionary[start / 100];
                numbersDictionary[start] = hundred + " hundred";
                string prefix = hundred + " hundred and ";

                for (int n = 1; n <= 99; n++)
                {
                    numbersDictionary[start + n] = prefix + numbersDictionary[n];
                }
            }
        }

        private static void Print(SortedDictionary<int, string> numbersDictionary)
        {
            foreach (KeyValuePair<int, string> item in numbersDictionary)
            {
                WriteLine($"{item.Key} = {item.Value}");
            }
        }

        private static int CountLetters(SortedDictionary<int, string> numbersDictionary)
        {
            StringBuilder stringBuilder = new StringBuilder();

            foreach (KeyValuePair<int, string> item in numbersDictionary)
            {
                stringBuilder.Append(item.Value);
            }

            string allNumbersFrom1To1000 = stringBuilder.ToString();
            allNumbersFrom1To1000 = allNumbersFrom1To1000.Replace(" ", "");
            int letterCount = allNumbersFrom1To1000.Length;

            return letterCount;
        }
    }
}
