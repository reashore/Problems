using System.Collections.Generic;
using NUnit.Framework;

namespace Problem79.Tests
{
    [TestFixture]
    public class LinkedListTests
    {
        [Test]
        [TestCase(3, 1, true)]
        [TestCase(3, 9, true)]
        [TestCase(3, 6, true)]
        [TestCase(3, 8, true)]
        [TestCase(3, 0, true)]
        [TestCase(3, 2, true)]
        [TestCase(3, 7, true)]
        [TestCase(9, 6, true)]
        [TestCase(9, 2, true)]
        [TestCase(0, 7, true)]
        [TestCase(1, 3, false)]
        [TestCase(9, 3, false)]
        [TestCase(2, 9, false)]
        [TestCase(7, 0, false)]
        public void CompareDigitsOfLinkedListTest(int digit1, int digit2, bool expectedIsDigit1BeforeDigit2)
        {
            // Arrange
            const string password = "31968027";
            LinkedList<int> passwordLinkedList = CreatePasswordLinkedList(password);
            
            // Act
            bool isDigit1BeforeDigit2 = passwordLinkedList.IsDigit1BeforeDigit2(digit1, digit2);
            
            // Assert
            Assert.That(isDigit1BeforeDigit2, Is.EqualTo(expectedIsDigit1BeforeDigit2));
        }
        
        [Test]
        [TestCase(1, 3, "23145678")]
        [TestCase(2, 3, "13245678")]
        [TestCase(3, 6, "12456378")]
        [TestCase(6, 7, "12345768")]
        [TestCase(4, 8, "12356784")]
        [TestCase(8, 1, "18234567")]
        [TestCase(7, 2, "12734568")]
        public void ReorderDigitsOfLinkedListTest(int digit1, int digit2, string expectedPassword)
        {
            // Arrange
            const string password = "12345678";
            LinkedList<int> passwordLinkedList = CreatePasswordLinkedList(password);
            
            // Act
            passwordLinkedList.MoveDigit1AfterDigit2(digit1, digit2);
            
            // Assert
            string actualPassword = passwordLinkedList.GetString();
            Assert.That(actualPassword, Is.EqualTo(expectedPassword));
        }

        // todo remove duplication
        private static LinkedList<int> CreatePasswordLinkedList(string password)
        {
            LinkedList<int> passwordLinkedList = new LinkedList<int>();
            
            foreach (char character in password)
            {
                string characterString = character.ToString();
                passwordLinkedList.AddLast(int.Parse(characterString));
            }

            return passwordLinkedList;
        }
    }
}