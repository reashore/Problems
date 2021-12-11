using System.Collections.Generic;

namespace Problem79.Tests
{
    public static class TestUtilities
    {
        public static LinkedList<int> CreatePasswordLinkedList(string password)
        {
            LinkedList<int> passwordLinkedList = new();
            
            foreach (char character in password)
            {
                string characterString = character.ToString();
                passwordLinkedList.AddLast(int.Parse(characterString));
            }

            return passwordLinkedList;
        }
    }
}