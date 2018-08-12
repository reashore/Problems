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

            long numberEquivalentCurrencyChanges = Solve();
            Console.WriteLine($"numberEquivalentCurrencyChanges = {numberEquivalentCurrencyChanges}");

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
            for (int valueIn = 0; valueIn <= 200; valueIn++)
            {
                var money = Money.GetMoneyFromValue(valueIn);
                int valueOut = Money.GetValueFromMoney(money);

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
            Money money2 = new Money
            {
                Pense100 = 1,
                Pense50 = 1,
                Pense20 = 2,
                Pense5 = 1,
                Pense2 = 1,
                Pense1 = 3
            };
            Utilities.Assert(Money.AreEqual(money1, money2));

            money1 = new Money(388);
            money2 = new Money
            {
                Pense200 = 1,
                Pense100 = 1,
                Pense50 = 1,
                Pense20 = 1,
                Pense10 = 1,
                Pense5 = 1,
                Pense2 = 1,
                Pense1 = 1
            };
            Utilities.Assert(Money.AreEqual(money1, money2));
        }

        #endregion

        private static long Solve()
        {
            Money money = new Money(200);


            return 0;
        }
    }
}
