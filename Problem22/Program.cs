using static System.Console;

namespace Problem22
{
    // ReSharper disable once ClassNeverInstantiated.Global
    public class Program
    {
        public static void Main()
        {
            WriteLine("Problem 22");

            long answer = Problem22.Solve();
            WriteLine($"sumNamesScores = {answer}");
        }
    }
}
