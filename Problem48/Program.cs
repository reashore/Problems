using static System.Console;

namespace Problem48
{
    // ReSharper disable once ClassNeverInstantiated.Global
    public class Program
    {
        public static void Main()
        {
            WriteLine("Problem 48");

            string answer = Problem48.Solve();
            WriteLine($"lastTenDigits = {answer}");        // 9110846700
        }
    }
}
