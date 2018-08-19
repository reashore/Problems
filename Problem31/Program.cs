using Common;
using System;

namespace Problem31
{
    // ReSharper disable once ClassNeverInstantiated.Global
    internal class Program
    {
        private static void Main()
        {
            Console.WriteLine("Problem 31");

            Test();

            ulong numberCurrencyChanges = Solve();
            Console.WriteLine($"numberCurrencyChanges = {numberCurrencyChanges}");      // 73682

            Console.WriteLine("Done");
            Console.ReadKey();
        }

        #region Tests

        private static void Test()
        {
            Test1();
            Test2();
            Test3();

            Console.WriteLine("Tests done");
        }

        private static void Test1()
        {
            for (uint valueIn = 0; valueIn <= 200; valueIn++)
            {
                Money money = Money.GetMoneyFromValue(valueIn);
                uint valueOut = Money.GetValueFromMoney(money);

                if (valueIn != valueOut)
                {
                    Console.WriteLine($"Failed for {valueIn}");
                }
            }
        }

        private static void Test2()
        {
            Money money = new Money(200);
            Utilities.Assert(money.Pense200 == 1);

            money = new Money(100);
            Utilities.Assert(money.Pense100 == 1);

            money = new Money(50);
            Utilities.Assert(money.Pense50 == 1);

            money = new Money(20);
            Utilities.Assert(money.Pense20 == 1);

            money = new Money(10);
            Utilities.Assert(money.Pense10 == 1);

            money = new Money(5);
            Utilities.Assert(money.Pense5 == 1);

            money = new Money(2);
            Utilities.Assert(money.Pense2 == 1);

            money = new Money(1);
            Utilities.Assert(money.Pense1 == 1);

            money = new Money(263);
            Utilities.Assert(money.Pense200 == 1);
            Utilities.Assert(money.Pense50 == 1);
            Utilities.Assert(money.Pense10 == 1);
            Utilities.Assert(money.Pense2 == 1);
            Utilities.Assert(money.Pense1 == 1);
        }

        private static void Test3()
        {
            Money money1 = new Money(200);
            Money money2 = new Money(0, 1, 1, 2, 0, 1, 1, 3);
            Utilities.Assert(money1 == money2);

            money1 = new Money(388);
            money2 = new Money(1, 1, 1, 1, 1, 1, 1, 1);
            Utilities.Assert(money1 == money2);
        }

        #endregion

        private static ulong Solve()
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
