using static System.Console;

namespace Problem31
{
    // ReSharper disable once ClassNeverInstantiated.Global
    public class Program
    {
        public static void Main()
        {
            WriteLine("Problem 31");

            ulong answer = Solve();
            WriteLine($"numberCurrencyChanges = {answer}");      // 73682

            WriteLine("Done");
            ReadKey();
        }

        public static ulong Solve()
        {
            uint numberCurrencyChanges = 0;

            for (uint p200 = 0; p200 <= 1; p200++)
            {
                for (uint p100 = 0; p100 <= 2; p100++)
                {
                    for (uint p50 = 0; p50 <= 4; p50++)
                    {
                        for (uint p20 = 0; p20 <= 10; p20++)
                        {
                            for (uint p10 = 0; p10 <= 20; p10++)
                            {
                                for (uint p5 = 0; p5 <= 40; p5++)
                                {
                                    for (uint p2 = 0; p2 <= 100; p2++)
                                    {
                                        for (uint p1 = 0; p1 <= 200; p1++)
                                        {
                                            Money money = new Money(p200, p100, p50, p20, p10, p5, p2, p1);

                                            if (money.Value == 200)
                                            {
                                                numberCurrencyChanges++;
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }

            return numberCurrencyChanges;
        }
    }
}
