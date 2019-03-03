using static System.Console;

namespace Problem31
{
    // ReSharper disable once ClassNeverInstantiated.Global
    public class Program
    {
        public static void Main()
        {
            WriteLine("Problem 31");

            ulong answer = Problem31.Solve();
            WriteLine($"numberCurrencyChanges = {answer}");      // 73682
        }
    }
}
