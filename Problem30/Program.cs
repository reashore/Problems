using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem30
{
    // ReSharper disable once ClassNeverInstantiated.Global
    public class Program
    {
        private static void Main()
        {
            Console.WriteLine("Problem 30");

            Solve();

            Console.WriteLine("Done");
            Console.ReadKey();
        }

        private static void Solve()
        {
            // Beyond empirically determined upperLimit, the digits sum always exceeds the number
            const int upperLimit = 200000;
            long number = 2;
            List<long> specialNumbersList = new List<long>();

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
                    Console.WriteLine($"{number}, sum = {sum}");
                }

                number++;
            }

            long specialNumbersSum = specialNumbersList.Sum(n => n);
            Console.WriteLine($"specialNumbersSum = {specialNumbersSum}");
        }
    }
}
