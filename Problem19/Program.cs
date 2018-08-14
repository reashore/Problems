using System;
using Common;

namespace Problem19
{
    // ReSharper disable once ClassNeverInstantiated.Global
    internal class Program
    {
        private static void Main()
        {
            Console.WriteLine("Problem 19");

            Test();

            int numberSundaysOnFirstOfMonth = Solve();
            Console.WriteLine($"numberSundaysOnFirstOfMonth = {numberSundaysOnFirstOfMonth}");      // 171

            Console.WriteLine("Done");
            Console.ReadKey();
        }

        private static void Test()
        {
            DateTime startDate = new DateTime(1900, 1, 1);
            Utilities.Assert(startDate.DayOfWeek == DayOfWeek.Monday);

            DateTime firstOfMonth = startDate.Add(TimeSpan.FromDays(31));
            Utilities.Assert(IsFirstOfMonth(firstOfMonth));
        }

        private static int Solve()
        {
            DateTime startDate = new DateTime(1901, 1, 1);
            DateTime endDate = new DateTime(2000, 12, 31);
            TimeSpan oneDay = TimeSpan.FromDays(1);
            int numberSundaysOnFirstOfMonth = 0;
            DateTime dateTime = startDate;

            while (true)
            {
                if (IsSunday(dateTime) && IsFirstOfMonth(dateTime))
                {
                    numberSundaysOnFirstOfMonth++;
                }

                dateTime = dateTime.Add(oneDay);

                if (dateTime == endDate)
                {
                    break;
                }
            }

            return numberSundaysOnFirstOfMonth;
        }

        private static bool IsSunday(DateTime dateTime)
        {
            return dateTime.DayOfWeek == DayOfWeek.Sunday;
        }

        private static bool IsFirstOfMonth(DateTime dateTime)
        {
            return dateTime.Day == 1;
        }
    }
}
