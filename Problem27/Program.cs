using System;

namespace Problem27
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Problem 27");

            Test();

            //const int upperLimit = 1002;
            const int upperLimit = 1000;
            (int, int, int) result = Solve4(upperLimit);
            int aValue = result.Item1;
            int bValue = result.Item2;
            int maxPrimes = result.Item3;
            int product = aValue * bValue;
            Console.WriteLine($"product = {product}");

            Console.WriteLine("Done");
            Console.ReadKey();
        }

        private static void Test()
        {
            Func<int, int> Quadratic;

            Quadratic = n => n * n + 999 * n + 997;
            int maxPrimes0 = FindMaxNumberPrimesForQuadratic(Quadratic);    // 5

            Quadratic = n => n * n + n + 41;
            int maxPrimes1 = FindMaxNumberPrimesForQuadratic(Quadratic);    // 40

            Quadratic = n => n * n - 39 * n - 23;
            int maxPrimes2 = FindMaxNumberPrimesForQuadratic(Quadratic);    // 45

            Quadratic = n => n * n - 79 * n + 1601;
            int maxPrimes3 = FindMaxNumberPrimesForQuadratic(Quadratic);    // 80

            Quadratic = n => n * n - 999 * n - 999;
            int maxPrimes4 = FindMaxNumberPrimesForQuadratic(Quadratic);    // 1000

            Quadratic = n => n * n - 999 * n + 61;
            int maxPrimes5 = FindMaxNumberPrimesForQuadratic(Quadratic);    // 1011
        }

        private static (int, int, int) Solve(int upperLimit)
        {
            int lowerLimit = -upperLimit;
            int maxPrimes = 0;
            int aValue = 0;
            int bValue = 0;

            for (int a = lowerLimit + 1; a < upperLimit; a++)
            {
                for (int b = lowerLimit; b <= upperLimit; b++)
                {
                    //Console.WriteLine($"a = {a, 4}, b = {b, 4}");

                    bool assertion = Math.Abs(a) < upperLimit && Math.Abs(b) <= upperLimit;
                    if (!assertion)
                    {
                        Console.WriteLine($"Assertion failed for a = {a} and b = {b}");
                    }

                    Func<int, int> Quadratic = n => n * n + a * n + b;
                    int numberPrimes = FindMaxNumberPrimesForQuadratic(Quadratic);

                    if (numberPrimes > maxPrimes)
                    {
                        maxPrimes = numberPrimes;
                        aValue = a;
                        bValue = b;

                        Console.WriteLine($"aValue = {aValue, 5}, bValue = {bValue, 5}, maxPrimes = {maxPrimes, 10}");
                    }
                }
            }

            return (aValue, bValue, maxPrimes);
        }

        private static (int, int, int) Solve2(int upperLimit)
        {
            int maxPrimes = 0;
            int aValue = 0;
            int bValue = 0;

            for (int a = -upperLimit; a <= upperLimit; a++)
            {
                for (int b = -upperLimit; b <= upperLimit; b++)
                {
                    //Console.WriteLine($"a = {a, 4}, b = {b, 4}");

                    //bool assertion = Math.Abs(a) < upperLimit && Math.Abs(b) <= upperLimit;
                    //if (!assertion)
                    //{
                    //    Console.WriteLine($"Assertion failed for a = {a} and b = {b}");
                    //    continue;
                    //}

                    Func<int, int> Quadratic = n => n * n + a * n + b;
                    int numberPrimes = FindMaxNumberPrimesForQuadratic(Quadratic);

                    if (numberPrimes > maxPrimes)
                    {
                        maxPrimes = numberPrimes;
                        aValue = a;
                        bValue = b;

                        Console.WriteLine($"aValue = {aValue, 5}, bValue = {bValue, 5}, maxPrimes = {maxPrimes, 10}");
                    }
                }
            }

            return (aValue, bValue, maxPrimes);
        }

        private static (int, int, int) Solve3(int upperLimit)
        {
            int maxPrimes = 0;
            int aValue = 0;
            int bValue = 0;

            for (int a = upperLimit - 1; -upperLimit < a; a--)
            {
                for (int b = upperLimit; -upperLimit <= b; b--)
                {
                    //Console.WriteLine($"a = {a, 4}, b = {b, 4}");

                    bool assertion = Math.Abs(a) < upperLimit && Math.Abs(b) <= upperLimit;
                    if (!assertion)
                    {
                        Console.WriteLine($"Assertion failed for a = {a} and b = {b}");
                    }

                    Func<int, int> Quadratic = n => n * n + a * n + b;
                    int numberPrimes = FindMaxNumberPrimesForQuadratic(Quadratic);

                    if (numberPrimes > maxPrimes)
                    {
                        maxPrimes = numberPrimes;
                        aValue = a;
                        bValue = b;

                        Console.WriteLine($"aValue = {aValue,5}, bValue = {bValue,5}, maxPrimes = {maxPrimes,10}");
                    }
                }
            }

            return (aValue, bValue, maxPrimes);
        }

        private static (int, int, int) Solve4(int upperLimit)
        {
            int lowerLimit = -upperLimit;
            int maxPrimes = 0;
            int aValue = 0;
            int bValue = 0;

            for (int a = -upperLimit; a < upperLimit; a++)
            {
                for (int b = -upperLimit; b <= upperLimit; b++)
                {
                    //Console.WriteLine($"a = {a, 4}, b = {b, 4}");

                    bool assertion = Math.Abs(a) < upperLimit && Math.Abs(b) <= upperLimit;
                    if (!assertion)
                    {
                        Console.WriteLine($"Assertion failed for a = {a} and b = {b}");
                    }

                    Func<int, int> Quadratic = n => n * n + a * n + b;
                    int numberPrimes = FindMaxNumberPrimesForQuadratic(Quadratic);

                    if (numberPrimes > maxPrimes)
                    {
                        maxPrimes = numberPrimes;
                        aValue = a;
                        bValue = b;

                        Console.WriteLine($"aValue = {aValue,5}, bValue = {bValue,5}, maxPrimes = {maxPrimes,10}");
                    }
                }
            }

            return (aValue, bValue, maxPrimes);
        }

        private static int FindMaxNumberPrimesForQuadratic(Func<int, int> Quadratic)
        {
            int numberPrimes = 0;
            int number = 0;

            while (true)
            {
                int value = Quadratic(number);

                if (IsPrime(value))
                {
                    numberPrimes++;
                }
                else
                {
                    break;
                }

                number++;
            }

            return numberPrimes;
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
