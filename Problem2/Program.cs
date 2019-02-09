using static System.Console;

namespace Problem2
{
    // ReSharper disable once ClassNeverInstantiated.Global
    public class Program
    {
        public static void Main()
        {
            WriteLine("Problem 2");

            int sumOfEvenTerms = Solve();
            WriteLine($"sumOfEvenTerms = { sumOfEvenTerms}");

            WriteLine("Done");
            ReadKey();
        }

        public static int Solve()
        {
            const int upperLimit = 4000000;
            int x1 = 0;
            int x2 = 1;
            int sum = 0;

            while (x2 < upperLimit)
            {
                var fibonacci = x1 + x2;
                var isEven = fibonacci % 2 == 0;

                if (fibonacci % 2 == 0)
                {
                    sum += fibonacci;
                }

                WriteLine($"{x1} + {x2} = {fibonacci}, isEven = {isEven}");

                x1 = x2;
                x2 = fibonacci;
            }

            return sum;
        }
    }
}
