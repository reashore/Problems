using static Common.Utilities;
using static System.Console;

namespace Problem63
{
    // https://www.mathblog.dk/project-euler-63-n-digit-nth-power/

    // ReSharper disable once ClassNeverInstantiated.Global
    internal class Program
    {
        private static void Main()
        {
            WriteLine("Problem 63");

            Test();

            int result = Solve();
            WriteLine($"result = {result}");

            WriteLine("Done");
            ReadKey();
        }

        private static void Test()
        {
            long power = Pow(10, 1);
            Assert(power == 10);

            power = Pow(10, 2);
            Assert(power == 100);

            power = Pow(7, 5);
            Assert(power == 16807);

            power = Pow(8, 9);
            Assert(power == 134217728);

            (bool, int) result = IsEqualToAnNthPower(16807, 5);
            Assert(result.Item1);
            Assert(result.Item2 == 7);

            result = IsEqualToAnNthPower(134217728, 9);
            Assert(result.Item1);
            Assert(result.Item2 == 8);
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
                    Assert(Pow(baseNumber, numberLength) == number);
                    WriteLine($"Pow({baseNumber}, {numberLength}) = {number,10}");
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
