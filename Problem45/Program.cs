using static System.Console;

namespace Problem45
{
    // ReSharper disable once ClassNeverInstantiated.Global
    public class Program
    {
        public static void Main()
        {
            WriteLine("Problem 45");

            long answer = Problem45.Solve();
            WriteLine($"triangleNumber = {answer}");        // 1533776805
        }
    }
}
