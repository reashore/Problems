using static System.Console;

namespace Problem39
{
    // ReSharper disable once ClassNeverInstantiated.Global
    public class Program
    {
        public static void Main()
        {
            WriteLine("Problem 39");

            int answer = Problem39.Solve();

            WriteLine($"maxPerimeter = {answer}");        // 840
        }
    }
}
