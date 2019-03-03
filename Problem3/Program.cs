using static System.Console;

namespace Problem3
{
    // ReSharper disable once ClassNeverInstantiated.Global
    public  class Program
    {
        public static void Main()
        {
            WriteLine("Problem 3");

            long answer = Problem3.Solve();
            WriteLine($"largestPrimeFactor = {answer}");    //  6857
        }
    }
}
