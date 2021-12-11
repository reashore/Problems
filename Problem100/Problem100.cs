
using System;

namespace Problem100
{
    internal class Problem100
    {
        public static int Solve(int row, int col)
        {
            bool firstRowPair = row % 2 == 1;
            //int rowPair = GetRowPair(row);

            //---------------------------------------

            //bool evenRow = row % 2 == 0;
            //int rowPair;

            //if (evenRow)
            //{
            //    rowPair = row / 2;
            //}
            //else
            //{
            //    rowPair = row / 2 + 1;
            //}

            //if (firstRowPair)
            //{
            //    rowPair = row / 2 + 1;
            //}
            //else
            //{
            //    rowPair = row / 2;
            //}

            int rowPair = row / 2 + (firstRowPair ? 1 : 0);


            //---------------------------------------

            int baseNumber = 10 * (rowPair - 1);
            //int value;

            //if (firstRowPair)
            //{
            //    value = 2 * (col - 1);
            //}
            //else
            //{
            //    value = 2 * (col - 1) + 1;
            //}

            int baseColValue = 2 * (col - 1) + (firstRowPair ? 0 : 1);

            int value = baseNumber + baseColValue;

            //value += baseNumber;

            return value;
        }

        //public static int Solve(int row, int col)
        //{
        //    bool firstRowPair = row % 2 == 1;
        //    int rowPair = GetRowPair(row);


        //    int baseNumber = 10 * (rowPair - 1);
        //    int value;

        //    if (firstRowPair)
        //    {
        //        value = 2 * (col - 1);
        //    }
        //    else
        //    {
        //        value = 2 * (col - 1) + 1;
        //    }

        //    value += baseNumber;

        //    return value;
        //}

        public static int GetRowPair(int row)
        {
            bool evenRow = row % 2 == 0;
            int rowPair;

            if (evenRow)
            {
                rowPair = row / 2;
            }
            else
            {
                rowPair = row / 2 + 1;
            }

            return rowPair;
        }

        public static void TestRowPair()
        {
            for (int row = 1; row < 20; row++)
            {
                int rowPair = GetRowPair(row);
                bool firstRowPair = row % 2 == 1;
                int baseNumber = 10 * (rowPair - 1);

                string message = $"row = {row}, rowPair = {rowPair}, firstRowPair = {firstRowPair}, baseNumber = {baseNumber}";
                Console.WriteLine(message);
            }
        }

        public static void Test()
        {
            for (int row = 1; row <= 5; row++)
            {
                int rowPair = GetRowPair(row);
                bool firstRowPair = row % 2 == 1;
                int baseNumber = 10 * (rowPair - 1);

                string message = $"row = {row}, rowPair = {rowPair}, firstRowPair = {firstRowPair}, baseNumber = {baseNumber}";
                Console.WriteLine(message);

                for (int col = 1; col <= 5; col++)
                {
                    int value;

                    if (firstRowPair)
                    {
                        value = 2 * (col - 1);
                    }
                    else
                    {
                        value = 2 * (col - 1) + 1;
                    }

                    value += baseNumber;

                    Console.WriteLine($"value = {value}");
                }
            }
        }
    }
}
