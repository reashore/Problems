using static System.Console;

namespace Problem19
{
    // ReSharper disable once ClassNeverInstantiated.Global
    public class Program
    {
        public static void Main()
        {
            WriteLine("Problem 19");

            int numberSundaysOnFirstOfMonth = Problem19.Solve();
            WriteLine($"numberSundaysOnFirstOfMonth = {numberSundaysOnFirstOfMonth}");      // 171

            WriteLine("Done");
            ReadKey();
        }

    }
}
