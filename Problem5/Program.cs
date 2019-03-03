using static System.Console;

namespace Problem5
{
    // ReSharper disable once ClassNeverInstantiated.Global
    public class Program
    {
        public static void Main()
        {
            WriteLine("Problem 5");

            int smallestNumber = Problem5.Solve();
            WriteLine($"smallestNumber = {smallestNumber}");
        }
    }
}
