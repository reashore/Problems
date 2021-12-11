using System;
using System.Collections.Generic;
using System.Linq;
using static System.Console;

namespace Problem30
{
    // ReSharper disable once ClassNeverInstantiated.Global
    public class Program
    {
        public static void Main()
        {
            WriteLine("Problem 30");

            long answer = Solve();
            WriteLine($"specialNumbersSum = {answer}");

            WriteLine("Done");
            ReadKey();
        }

        public static long Solve()
        {
            // Beyond empirically determined upperLimit, the digits sum always exceeds the number
            const int upperLimit = 200000;
            long number = 2;
            List<long> specialNumbersList = new();

            while (number < upperLimit)
            {
                string numberString = number.ToString();

                long sum = 0;

                foreach (char character in numberString)
                {
                    int digit = Convert.ToInt32(character.ToString());
                    sum += digit * digit * digit * digit * digit;
                }

                if (sum == number)
                {
                    specialNumbersList.Add(number);
                    //WriteLine($"{number}, sum = {sum}");
                }

                number++;
            }

            long specialNumbersSum = specialNumbersList.Sum(n => n);

            return specialNumbersSum;
        }
    }
}
