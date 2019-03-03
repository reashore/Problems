using static System.Console;

namespace Problem2
{
    // ReSharper disable once ClassNeverInstantiated.Global
    public class Program
    {
        public static void Main()
        {
            WriteLine("Problem 2");

            int sumOfEvenTerms = Problem2.Solve();
            WriteLine($"sumOfEvenTerms = { sumOfEvenTerms}");
        }
    }
}
