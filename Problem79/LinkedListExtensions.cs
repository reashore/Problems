using System.Collections.Generic;

namespace Problem79
{
    public static class LinkedListExtensions
    {
        public static bool IsDigit1BeforeDigit2(this LinkedList<int> numericLinkedList, int digit1, int digit2)
        {
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

        public static string ConvertLinkedListToString(this LinkedList<int> linkedList)
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