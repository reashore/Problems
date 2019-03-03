using static System.Console;

namespace Problem28
{
    // ReSharper disable once ClassNeverInstantiated.Global
    public class Program
    {
        public static void Main()
        {
            WriteLine("Problem 28");

            long answer = Problem28.Solve();
            WriteLine($"sumBothDiagonals = {answer}");
        }
    }
}
