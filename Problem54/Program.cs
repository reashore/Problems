﻿using static System.Console;

namespace Problem54
{
    // ReSharper disable once ClassNeverInstantiated.Global
    public class Program
    {
        public static void Main()
        {
            WriteLine("Problem 54");
            
            //Deal.GetDealsWhereBothHandsAreSamePokerType();
            
            int answer = Problem54.Solve();                
            WriteLine($"answer = {answer}");                // 376
        }
    }
}