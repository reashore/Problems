using System;
using Common;

namespace Problem63
{
    // https://www.mathblog.dk/project-euler-63-n-digit-nth-power/

    // ReSharper disable once ClassNeverInstantiated.Global
    internal class Program
    {
        private static void Main()
        {
            Console.WriteLine("Problem 63");

            Test();

            int result = Solve();
            Console.WriteLine($"result = {result}");

            Console.WriteLine("Done");
            Console.ReadKey();
        }

        private static void Test()
        {
            long power = Pow(10, 1);
            Utilities.Assert(power == 10);

            power = Pow(10, 2);
            Utilities.Assert(power == 100);

            power = Pow(7, 5);
            Utilities.Assert(power == 16807);

            power = Pow(8, 9);
            Utilities.Assert(power == 134217728);

            (bool, int) result = IsEqualToAnNthPower(16807, 5);
            Utilities.Assert(result.Item1);
            Utilities.Assert(result.Item2 == 7);

            result = IsEqualToAnNthPower(134217728, 9);
            Utilities.Assert(result.Item1);
            Utilities.Assert(result.Item2 == 8);
        }

        private static int Solve()
        {
            int rangeBound = 10;
            int numberLength = 1;
            int powerNumberCount = 0;

            for (int number = 1; number < Pow(10, 9); number++)
            {
                if (number == rangeBound)
                {
                    rangeBound *= 10;
                    numberLength++;
                }

                (bool, int) result = IsEqualToAnNthPower(number, numberLength);
                bool match = result.Item1;
                int baseNumber = result.Item2;

                if (match)
                {
                    Utilities.Assert(Pow(baseNumber, numberLength) == number);
                    Console.WriteLine($"Pow({baseNumber}, {numberLength}) = {number,10}");
                    powerNumberCount++;
                }
            }

            return powerNumberCount;
        }

        private static (bool, int) IsEqualToAnNthPower(int number, int exponent)
        {
            int baseNumber = 1;

            while (true)
            {
                long power = Pow(baseNumber, exponent);

                if (number == power)
                {
                    return (true, baseNumber);
                }

                if (power > number)
                {
                    return (false, 0);
                }

                baseNumber++;
            }
        }

        private static long Pow(int number, int exponent)
        {
            long power = 1;

            for (int n = 1; n <= exponent; n++)
            {
                power *= number;
            }

            return power;
        }
    }
}
