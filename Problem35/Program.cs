using System;
using System.Collections.Generic;
using static Common.Utilities;
using static System.Console;

namespace Problem35
{
    // ReSharper disable once ClassNeverInstantiated.Global
    public class Program
    {
        public static void Main()
        {
            WriteLine("Problem 35");

            long count = Solve();
            WriteLine($"count = {count}");      // 55

            WriteLine("Done");
            ReadKey();
        }

        public static long Solve()
        {
            const long upperBound = 1000000;
            int count = 0;

            for (long number = 2; number < upperBound; number++)
            {
                IEnumerable<long> digitRotations = GetDigitRotations(number);

                bool isCircularPrime = true;

                foreach (long numberRotation in digitRotations)
                {
                    if (!IsPrime(numberRotation))
                    {
                        isCircularPrime = false;
                    }
                }

                if (isCircularPrime)
                {
                    count++;
                    //WriteLine($"{number} is a circular prime");
                }
            }

            return count;
        }

        private static IEnumerable<long> GetDigitRotations(long number)
        {
            List<long> digitRotations = new List<long>();
            string numberString = number.ToString();

            digitRotations.Add(number);

            while (true)
            {
                string rotatedNumberString = Rotate(numberString);
                int rotatedNumber = Convert.ToInt32(rotatedNumberString);

                if (rotatedNumber != number)
                {
                    digitRotations.Add(rotatedNumber);
                }
                else
                {
                    break;
                }

                numberString = rotatedNumberString;
            }

            return digitRotations;
        }

        private static string Rotate(string value)
        {
            int length = value.Length;

            if (length == 1)
            {
                return value;
            }

            string leftCharacter = value.Substring(0, 1);
            string rest = value.Substring(1);
            string rotatedValue = rest + leftCharacter;

            return rotatedValue;
        }
    }
}
