using System.Collections.Generic;
using Common;

namespace Problem79
{
    public static class LinkedListExtensions
    {
        public static void ReorderPasswordToMatchPasscode(this LinkedList<int> passwordLinkedList, string passcode)
        {
            List<int> passcodeDigitList = Utilities.ConvertNumericStringToList(passcode);

            int digit1 = passcodeDigitList[0];
            int digit2 = passcodeDigitList[1];
            passwordLinkedList.OrderDigits(digit1, digit2);
            
            digit1 = passcodeDigitList[1];
            digit2 = passcodeDigitList[2];
            passwordLinkedList.OrderDigits(digit1, digit2);
            
            digit1 = passcodeDigitList[0];
            digit2 = passcodeDigitList[2];
            passwordLinkedList.OrderDigits(digit1, digit2);
        }
        
        public static bool OrderDigits(this LinkedList<int> passwordLinkedList, int digit1, int digit2)
        {
            bool changed = false;
            
            bool isDigit1BeforeDigit2 = passwordLinkedList.IsDigit1BeforeDigit2(digit1, digit2);
            
            if (!isDigit1BeforeDigit2)
            {
                passwordLinkedList.MoveDigit1AfterDigit2(digit1, digit2);
                changed = true;
            }

            return changed;
        }

        public static bool IsDigit1BeforeDigit2(this LinkedList<int> numericLinkedList, int digit1, int digit2)
        {
            // Assumes digit1 < digit2
            foreach (int digit in numericLinkedList)
            {
                if (digit == digit1)
                {
                    return true;
                }
                else if (digit == digit2)
                {
                    return false;
                }
            }
            
            return true;
        }

        public static void MoveDigit1AfterDigit2(this LinkedList<int> numericLinkedList, int digit1, int digit2)
        {
            LinkedListNode<int> digit1Link = numericLinkedList.Find(digit1);

            if (digit1Link != null)
            {
                numericLinkedList.Remove(digit1Link);
            }
            
            LinkedListNode<int> digit2Link = numericLinkedList.Find(digit2);

            if (digit2Link != null)
            {
                numericLinkedList.AddAfter(digit2Link, digit1);
            }
        }

        public static string GetString(this LinkedList<int> linkedList)
        {
            string result = "";

            foreach (int digit in linkedList)
            {
                result += digit.ToString();
            }

            return result;
        }
    }
}