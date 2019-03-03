using static System.Console;

namespace Problem42
{
    // ReSharper disable once ClassNeverInstantiated.Global
    public class Program
    {
        public static void Main()
        {
            WriteLine("Problem 42");

            long answer = Problem42.Solve();
            WriteLine($"numberTriangularWords = {answer}");      // 162
        }
    }
}
