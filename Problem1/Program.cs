using System.Collections.Generic;
using System.Linq;
using static System.Console;

namespace Problem1
{
    // ReSharper disable once ClassNeverInstantiated.Global
    public class Program
    {
        public static void Main()
        {
            WriteLine("Problem 1");

            const int upperLimit = 1000;
            int result = Solve(upperLimit);
            WriteLine($"Result = {result}", result);

            WriteLine("Done");
            ReadKey();
        }

        public static int Solve(int upperLimit)
        {
            List<int> factors = new List<int>();

            for (int n = 3; n < upperLimit; n++)
            {
                if (n % 3 == 0 || n % 5 == 0)
                {
                    factors.Add(n);
                }
            }

            int result = factors.Sum();

            return result;
        }
    }
}
