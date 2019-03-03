using System;

namespace Problem9
{
    public static class Problem9
    {
        public static int Solve()
        {
            int product = 0;
            
            for (int a = 1; a < 1000; a++)
            {
                for (int b = a + 1; b < 1000; b++)
                {
                    for (int c = b + 1; c < 1000; c++)
                    {
                        // ReSharper disable once InvertIf
                        if (a * a + b * b == c * c && a + b + c == 1000)
                        {
                            product = a * b * c;
                            Console.WriteLine($"{a} x {b} x {c} = {product}");

                            break;
                        }
                    }
                }
            }

            return product;
        }
    }
}