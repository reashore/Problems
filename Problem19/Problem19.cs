using System;

namespace Problem19
{
    public static class Problem19
    {
        public static int Solve()
        {
            DateTime startDate = new(1901, 1, 1);
            DateTime endDate = new(2000, 12, 31);
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