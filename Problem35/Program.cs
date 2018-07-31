using System;
using System.Collections.Generic;

namespace Problem35
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Problem 35");

            Test();

            long upperBound = 100;
            long count = Solve(upperBound);
            Console.WriteLine($"count = {count}");      // 13

            upperBound = 1000000;
            count = Solve(upperBound);
            Console.WriteLine($"count = {count}");      // 55

            Console.WriteLine("Done");
            Console.ReadKey();
        }

        private static void Test()
        {
            string value = "123456";
            string rotatedValue = Rotate(value);

            int number = 123;
            List<long> digitRotations = GetDigitRotations(number);
        }

        private static long Solve(long upperBound)
        {
            int count = 0;

            for (long number = 2; number < upperBound; number++)
            {
                List<long> digitRotations = GetDigitRotations(number);

                bool isCircularPrime = true;

                foreach (int numberRotation in digitRotations)
                {
                    if (!IsPrime(numberRotation))
                    {
                        isCircularPrime = false;
                    }
                }

                if (isCircularPrime)
                {
                    count++;
                    //Console.WriteLine($"{number} is a circular prime");
                }
            }

            return count;
        }

        private static List<long> GetDigitRotations(long number)
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

        public static bool IsPrime(int candidate)
        {
            if ((candidate & 1) == 0)
            {
                if (candidate == 2)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }

            for (int i = 3; (i * i) <= candidate; i += 2)
            {
                if (candidate % i == 0)
                {
                    return false;
                }
            }

            return candidate != 1;
        }
    }
}
