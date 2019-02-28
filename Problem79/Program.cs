using System.Collections.Generic;
using System.IO;
using Common;
using static System.Console;

namespace Problem79
{
    public class Program
    {
        public static void Main()
        {
            WriteLine("Problem 57");

            string answer = Solve();
            WriteLine($"answer = {answer}");
            
            WriteLine("Done");
            ReadKey();
        }

        public static string Solve()
        {
            List<string> passcodeList =ReadPasscodes();
            List<int> digitList = GetDigitsFromPasscodes(passcodeList);            // 31968027
            LinkedList<int> passwordLinkedList = new LinkedList<int>();

            foreach (int digit in digitList)
            {
                passwordLinkedList.AddLast(digit);
            }
           
            foreach (string passcode in passcodeList)
            {
                ReorderPasswordToMatchPasscode(passcode, passwordLinkedList);
            }

            string password = passwordLinkedList.ConvertLinkedListToString();
            
            return password;
        }

        private static List<string> ReadPasscodes()
        {
            const string fileName = "Passcodes.txt";
            string[] passcodesArray = File.ReadAllLines(fileName);
            List<string> passcodeList = new List<string>(passcodesArray);
            
            return passcodeList;
        }

        private static List<int> GetDigitsFromPasscodes(List<string> passcodeList)
        {
            List<int> digitList = new List<int>();

            foreach (string passcode in passcodeList)
            {
                List<int> passcodeDigitList = Utilities.ConvertNumericStringToList(passcode);

                foreach (int digit in passcodeDigitList)
                {
                    if (!digitList.Contains(digit))
                    {
                        digitList.Add(digit);
                    }
                }
                
            }

            return digitList;
        }

        private static void ReorderPasswordToMatchPasscode(string passcode, LinkedList<int> passwordLinkedList)
        {
            List<int> passcodeDigitList = Utilities.ConvertNumericStringToList(passcode);

            int digit1 = passcodeDigitList[0];
            int digit2 = passcodeDigitList[1];
            bool isDigit1BeforeDigit2 = passwordLinkedList.IsDigit1BeforeDigit2(digit1, digit2);
            if (!isDigit1BeforeDigit2)
            {
                passwordLinkedList.MoveDigit1AfterDigit2(digit1, digit2);
            }
            
            digit1 = passcodeDigitList[1];
            digit2 = passcodeDigitList[2];
            isDigit1BeforeDigit2 = passwordLinkedList.IsDigit1BeforeDigit2(digit1, digit2);
            if (isDigit1BeforeDigit2)
            {
                passwordLinkedList.MoveDigit1AfterDigit2(digit1, digit2);
            }
            
            digit1 = passcodeDigitList[0];
            digit2 = passcodeDigitList[2];
            isDigit1BeforeDigit2 = passwordLinkedList.IsDigit1BeforeDigit2(digit1, digit2);
            if (isDigit1BeforeDigit2)
            {
                passwordLinkedList.MoveDigit1AfterDigit2(digit1, digit2);
            }
        }
    }
}