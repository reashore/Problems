using System.Collections.Generic;
using static System.Console;

namespace Problem61
{
    public static class Problem61
    {
        public static void Solve()
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
        }
    }
}