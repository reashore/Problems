using static System.Console;

namespace Problem9
{
    // ReSharper disable once ClassNeverInstantiated.Global
    public class Program
    {
        public static void Main()
        {
            WriteLine("Problem 9");

            int answer = Solve();
            WriteLine($"answer = {answer}");

            WriteLine("Done");
            ReadKey();
        }

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
                            WriteLine($"{a} x {b} x {c} = {product}");

                            break;
                        }
                    }
                }
            }

            return product;
        }
    }
}
