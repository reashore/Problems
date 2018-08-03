using System;

namespace Problem9
{
    // ReSharper disable once ClassNeverInstantiated.Global
    internal class Program
    {
        private static void Main()
        {
            Console.WriteLine("Problem 9");

            Solve();

            Console.WriteLine("Done");
            Console.ReadKey();
        }

        private static void Solve()
        {
            for (int a = 1; a < 1000; a++)
            {
                for (int b = a + 1; b < 1000; b++)
                {
                    for (int c = b + 1; c < 1000; c++)
                    {
                        if (a * a + b * b == c * c && a + b + c == 1000)
                        {
                            int product = a * b * c;
                            Console.WriteLine($"{a} x {b} x {c} = {product}");

                            break;
                        }
                    }
                }
            }
        }
    }
}
