using static System.Console;

namespace Problem50
{
    // ReSharper disable once ClassNeverInstantiated.Global
    public class Program
    {
        public static void Main()
        {
            WriteLine("Problem 50");

            long answer = Problem50.Solve();
            WriteLine($"prime = {answer}");        // 997651
        }
    }
}
