using System;
using System.Collections.Generic;

namespace Problem61
{
    public static class PentagonalNumbers
    {
        public static List<int> GetPentagonal3List()
        {
            return GetPentagonalNumberList(GetPentagonal3);
        }
        
        public static List<int> GetPentagonal4List()
        {
            return GetPentagonalNumberList(GetPentagonal4);
        }
        
        public static List<int> GetPentagonal5List()
        {
            return GetPentagonalNumberList(GetPentagonal5);
        }
        
        public static List<int> GetPentagonal6List()
        {
            return GetPentagonalNumberList(GetPentagonal6);
        }
        
        public static List<int> GetPentagonal7List()
        {
            return GetPentagonalNumberList(GetPentagonal7);
        }
        
        public static List<int> GetPentagonal8List()
        {
            return GetPentagonalNumberList(GetPentagonal8);
        }
        
        //---------------------------------------------------------------------------------------

        private static List<int> GetPentagonalNumberList(Func<int, int> getPentagonalNumber)
        {
            List<int> pentagonalNumberList = new();

            int number = 1;
            
            while (true)
            {
                int pentagonalNumber = getPentagonalNumber(number);
                int pentagonalNumberLength = pentagonalNumber.ToString().Length;

                if (pentagonalNumberLength == 4)
                {
                    pentagonalNumberList.Add(pentagonalNumber);
                }

                if (pentagonalNumberLength == 5)
                {
                    break;
                }

                number++;
            }

            return pentagonalNumberList;
        }
        
        //---------------------------------------------------------------------------------------
        
        private static int GetPentagonal3(int n)
        {
            return n * (n + 1) / 2;
        }
        
        private static int GetPentagonal4(int n)
        {
            return n * n;
        }
        
        private static int GetPentagonal5(int n)
        {
            return n * (3 * n - 1) / 2;
        }
        
        private static int GetPentagonal6(int n)
        {
            return n * (2 * n - 1);
        }
        
        private static int GetPentagonal7(int n)
        {
            return n * (5 * n - 3) / 2;
        }
        
        private static int GetPentagonal8(int n)
        {
            return n * (3 * n - 2);
        }
    }
}