using static System.Console;

namespace Problem25
{
    // ReSharper disable once ClassNeverInstantiated.Global
    public class Program
    {
        public static void Main()
        {
            WriteLine("Problem 25");

            int answer = Problem25.Solve();
            WriteLine($"FibonacciIndex = {answer, 7}");

            WriteLine("Done");
            ReadKey();
        }

    }
}
