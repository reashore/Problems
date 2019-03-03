using static System.Console;

namespace Problem63
{
    // https://www.mathblog.dk/project-euler-63-n-digit-nth-power/

    // ReSharper disable once ClassNeverInstantiated.Global
    public class Program
    {
        public static void Main()
        {
            WriteLine("Problem 63");

            int count = Problem63.Solve();
            WriteLine($"Number powerful digits = {count}");        // 49
        }
    }
}
