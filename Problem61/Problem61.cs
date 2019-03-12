using System.Collections.Generic;
using System.Linq;
using static System.Console;

namespace Problem61
{
    public static class Problem61
    {
        public static long Solve()
        {
            List<int> pentagonal3List = PentagonalNumbers.GetPentagonal3List();
            List<int> pentagonal4List = PentagonalNumbers.GetPentagonal4List();
            List<int> pentagonal5List = PentagonalNumbers.GetPentagonal5List();
            List<int> pentagonal6List = PentagonalNumbers.GetPentagonal6List();
            List<int> pentagonal7List = PentagonalNumbers.GetPentagonal7List();
            List<int> pentagonal8List = PentagonalNumbers.GetPentagonal8List();

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

                                    bool isCyclicSet = IsCyclicSet(pentagonalList);

                                    if (isCyclicSet)
                                    {
                                        long sum = pentagonalList.Sum(n => n);
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

        private static bool IsCyclicSet(List<int> pentagonalList)
        {
            // select first number and remove from list
            // get first 2 digits
            // is there a number in list beginning with those digits?
            // if no return false
            // if yes, get first 2 digits of that number
            // goto step 3
            
            //pentagonalList.
            
            return true;
        }

        public static void Solve2()
        {
            List<int> pentagonal3List = PentagonalNumbers.GetPentagonal3List();
            List<int> pentagonal4List = PentagonalNumbers.GetPentagonal4List();
            List<int> pentagonal5List = PentagonalNumbers.GetPentagonal5List();
            List<int> pentagonal6List = PentagonalNumbers.GetPentagonal6List();
            List<int> pentagonal7List = PentagonalNumbers.GetPentagonal7List();
            List<int> pentagonal8List = PentagonalNumbers.GetPentagonal8List();
            
            int count3 = pentagonal3List.Count;
            int count4 = pentagonal4List.Count;
            int count5 = pentagonal5List.Count;
            int count6 = pentagonal6List.Count;
            int count7 = pentagonal7List.Count;
            int count8 = pentagonal8List.Count;
            
            WriteLine($"count3 = {count3}");
            WriteLine($"count4 = {count4}");
            WriteLine($"count5 = {count5}");
            WriteLine($"count6 = {count6}");
            WriteLine($"count7 = {count7}");
            WriteLine($"count8 = {count8}");

            int product = count3 * count4 * count5 * count6 * count7 * count8;
            WriteLine($"product = {product}");
        }
    }
}