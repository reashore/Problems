using static System.Console;

namespace Problem29
{
    // ReSharper disable once ClassNeverInstantiated.Global
    public class Program
    {
        public static void Main()
        {
            WriteLine("Problem 29");

            long distinctPowers = Problem29.Solve();
            WriteLine($"distinctPowers = {distinctPowers}");
       }
    }
}
