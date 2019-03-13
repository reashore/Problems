using System.Collections.Generic;
using System.Linq;
using static System.Console;

namespace Problem61
{
    public static class Problem61
    {
        public static long Solve()
        {
            var pentagonal3List = PentagonalNumbers.GetPentagonal3List();
            var pentagonal4List = PentagonalNumbers.GetPentagonal4List();
            var pentagonal5List = PentagonalNumbers.GetPentagonal5List();
            var pentagonal6List = PentagonalNumbers.GetPentagonal6List();
            var pentagonal7List = PentagonalNumbers.GetPentagonal7List();
            var pentagonal8List = PentagonalNumbers.GetPentagonal8List();

            foreach (int p3Number in pentagonal3List)
            {
                foreach (int p4Number in pentagonal4List)
                {
                    foreach (int p5Number in pentagonal5List)
                    {
                        foreach (int p6Number in pentagonal6List)
                        {
                            foreach (int p7Number in pentagonal7List)
                            {
                                foreach (int p8Number in pentagonal8List)
                                {
                                    List<int> pentagonalList = new List<int>
                                    {
                                        p3Number, 
                                        p4Number, 
                                        p5Number, 
                                        p6Number,
                                        p7Number,
                                        p8Number
                                    };
                                    long sum = pentagonalList.Sum(n => n);

                                    bool isCyclicNumberSet = IsCyclicNumberSet(pentagonalList);

                                    if (isCyclicNumberSet)
                                    {
                                        WriteLine($"p3 = {p3Number}, p4 = {p4Number}, p5 = {p5Number}, p6 = {p6Number}, p7 = {p7Number}, p8 = {p8Number}");
                                        return sum;
                                    }
                                }
                            }
                        }
                    }
                }
            }

            return 0;
        }

        public static bool IsCyclicNumberSet(List<int> pentagonalList)
        {
            int firstElement = pentagonalList[0];
            pentagonalList.Remove(firstElement);
            string lastTwoDigits = GetLastTwoDigits(firstElement);

            while (pentagonalList.Count > 0)
            {
                int element = pentagonalList.FirstOrDefault(n => GetFirstTwoDigits(n) == lastTwoDigits);
                if (element == 0)
                {
                    return false;
                }
                pentagonalList.Remove(element);
                lastTwoDigits = GetLastTwoDigits(element);
            }

            bool finalCheck = lastTwoDigits == GetFirstTwoDigits(firstElement);
            
            return finalCheck;
        }
        
        public static string GetFirstTwoDigits(int number)
        {
            string numberString = number.ToString();
            string firstTwoDigits = numberString.Substring(0, 2);

            return firstTwoDigits;
        }
        
        public  static string GetLastTwoDigits(int number)
        {
            string numberString = number.ToString();
            int length = numberString.Length;
            string firstTwoDigits = numberString.Substring(length - 2, 2);

            return firstTwoDigits;
        } 
    }
}