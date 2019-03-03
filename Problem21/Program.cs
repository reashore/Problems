using static System.Console;

namespace Problem21
{
    // ReSharper disable once ClassNeverInstantiated.Global
    public class Program
    {
        public static void Main()
        {
            WriteLine("Problem 21");

            int answer = Problem21.Solve();
            WriteLine($"sumOfAmicableNumbers = {answer}");
        }
    }
}
