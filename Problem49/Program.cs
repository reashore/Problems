using static System.Console;

namespace Problem49
{
    // ReSharper disable once ClassNeverInstantiated.Global
    public class Program
    {
        public static void Main()
        {
            WriteLine("Problem 49");

            string answer = Problem49.Solve();
            WriteLine($"Concatenation = {answer}");      // 296962999629
        }
    }
}
