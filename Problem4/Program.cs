using static System.Console;

namespace Problem4
{
    // ReSharper disable once ClassNeverInstantiated.Global
    public class Program
    {
        public static void Main()
        {
            WriteLine("Problem 4");

            int maxPalindrome = Problem4.Solve();
            WriteLine($"maxPalindrome = {maxPalindrome}");
        }
    }
}
