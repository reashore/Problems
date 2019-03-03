using static System.Console;

namespace Problem11
{
    // ReSharper disable once ClassNeverInstantiated.Global
    public class Program
    {
        public static void Main()
        {
            WriteLine("Problem 11");

            int answer = Problem11.Solve();
            WriteLine($"maxProduct = {answer}");
        }
    }
}
