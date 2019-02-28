using System.Collections.Generic;
using NUnit.Framework;

namespace Problem79.Tests
{
    public class Tests
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
        public void LinkedListDigitComparisonTest(int digit1, int digit2, bool expectedIsDigit1BeforeDigit2)
        {
            // Arrange
            const string password = "31968027";
            LinkedList<int> passwordLinkedList = CreatePasswordLinkedList(password);
            
            // Act
            bool isDigit1BeforeDigit2 = passwordLinkedList.IsDigit1BeforeDigit2(digit1, digit2);
            
            // Assert
            Assert.That(isDigit1BeforeDigit2, Is.EqualTo(expectedIsDigit1BeforeDigit2));
        }
        
        [TestCase(7, 0, false)]
        public void LinkedListDigitReorderingTest(int digit1, int digit2, bool expectedIsDigit1BeforeDigit2)
        {
            // Arrange
            const string password = "31968027";
            LinkedList<int> passwordLinkedList = CreatePasswordLinkedList(password);
            
            // Act
            bool isDigit1BeforeDigit2 = passwordLinkedList.IsDigit1BeforeDigit2(digit1, digit2);
            
            // Assert
            Assert.That(isDigit1BeforeDigit2, Is.EqualTo(expectedIsDigit1BeforeDigit2));
        }

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