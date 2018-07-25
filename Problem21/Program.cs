﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem21
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Problem 21");

            int sum1 = SumOfProperDivisors(220);
            int sum2 = SumOfProperDivisors(284);
            bool isAmicableNumber1 = IsAmicableNumber(220);
            bool isAmicableNumber2 = IsAmicableNumber(284);
            int amicableNumberPartner1 = GetAmicableNumberPartner(220);
            int amicableNumberPartner2 = GetAmicableNumberPartner(284);

            const int upperBound = 10000;
            List<int> amicableNumbers = GetAmicableNumbers(upperBound);
            int sumOfAmicableNumbers = amicableNumbers.Sum(n => n);
            Console.WriteLine($"sumOfAmicableNumbers = {sumOfAmicableNumbers}");

            Console.WriteLine("Done");
            Console.ReadKey();
        }

        private static List<int> GetAmicableNumbers(int upperBound)
        {
            List<int> amicableNumbers = new List<int>();

            for (int n = 1; n < upperBound; n++)
            {
                bool isAmicableNumber = IsAmicableNumber(n);

                if (isAmicableNumber)
                {
                    amicableNumbers.Add(n);
                    Console.WriteLine($"IsAmicableNumber({n}) = {isAmicableNumber}, partner = {GetAmicableNumberPartner(n)}");
                }
            }

            return amicableNumbers;
        }

        private static List<int> GetProperDivisors(int number)
        {
            List<int> divisors = new List<int>();

            for (int n = 1; n < number; n++)
            {
                if (number % n == 0)
                {
                    divisors.Add(n);
                }
            }

            return divisors;
        }

        private static int SumOfProperDivisors(int number)
        {
            List<int> properDivisors = GetProperDivisors(number);
            int sumOfProperDivisors = properDivisors.Sum(n => n);

            return sumOfProperDivisors;
        }

        private static bool IsAmicableNumber(int number)
        {
            int sumOfProperDivisors1 = SumOfProperDivisors(number);
            int sumOfProperDivisors2 = SumOfProperDivisors(sumOfProperDivisors1);

            if (number == sumOfProperDivisors1)
            {
                return false;
            }

            return number == sumOfProperDivisors2;
        }

        private static int GetAmicableNumberPartner(int amicableNumber)
        {
            if (!IsAmicableNumber(amicableNumber))
            {
                throw new ArgumentException(nameof(amicableNumber));
            }

            return SumOfProperDivisors(amicableNumber);
        }
    }
}