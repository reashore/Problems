using System.Collections.Generic;
using NUnit.Framework;

namespace Problem79.Tests
{
    [TestFixture]
    public class ComputePasswordTests
    {
        [Test]
        public void GetPasswordTest()
        {
            // Arrange
            const string expectedPassword = "12345678";
            LinkedList<int> passwordLinkedList = TestUtilities.CreatePasswordLinkedList(expectedPassword);
            
            // Act
            string actualPassword = passwordLinkedList.GetString();
            
            // Assert
            Assert.That(actualPassword, Is.EqualTo(expectedPassword));
        }
        
        [Test]
        [TestCase(1, 2, true)]
        [TestCase(1, 3, true)]
        [TestCase(1, 4, true)]
        [TestCase(4, 5, true)]
        [TestCase(2, 1, false)]
        [TestCase(4, 3, false)]
        [TestCase(7, 5, false)]
        [TestCase(8, 2, false)]
        public void IsDigit1BeforeDigit2Test(int digit1, int digit2, bool expectedResult)
        {
            // Arrange
            const string password = "12345678";
            LinkedList<int> passwordLinkedList = TestUtilities.CreatePasswordLinkedList(password);
            
            // Act
            bool result = passwordLinkedList.IsDigit1BeforeDigit2(digit1, digit2);
            
            // Assert
            Assert.That(result, Is.EqualTo(expectedResult));
        }
        
        [Test]
        [TestCase(1, 2, "21345678")]
        [TestCase(1, 3, "23145678")]
        [TestCase(1, 4, "23415678")]
        [TestCase(4, 5, "12354678")]
        [TestCase(2, 6, "13456278")]
        [TestCase(4, 7, "12356748")]
        [TestCase(7, 8, "12345687")]
        [TestCase(2, 8, "13456782")]
        [TestCase(8, 2, "12834567")]
        public void MoveDigit1AfterDigit2Test(int digit1, int digit2, string expectedResult)
        {
            // Arrange
            const string password = "12345678";
            LinkedList<int> passwordLinkedList = TestUtilities.CreatePasswordLinkedList(password);
            
            // Act
            passwordLinkedList.MoveDigit1AfterDigit2(digit1, digit2);
            
            // Assert
            string actualPassword = passwordLinkedList.GetString();
            Assert.That(actualPassword, Is.EqualTo(expectedResult));
        }
        
        [Test]
        [TestCase(2, 1, "21345678", true)]
        [TestCase(4, 3, "12435678", true)]
        [TestCase(7, 5, "12346758", true)]
        [TestCase(8, 2, "13456782", true)]
        [TestCase(1, 2, "12345678", false)]
        [TestCase(2, 4, "12345678", false)]
        [TestCase(5, 7, "12345678", false)]
        [TestCase(3, 7, "12345678", false)]
        public void OrderDigitsTest(int digit1, int digit2, string expectedPassword, bool expectedPasswordChanged)
        {
            // Arrange
            const string password = "12345678";
            LinkedList<int> passwordLinkedList = TestUtilities.CreatePasswordLinkedList(password);
            
            // Act
            bool actualPasswordChanged = passwordLinkedList.OrderDigits(digit1, digit2);
            string actualPassword = passwordLinkedList.GetString();
            
            // Assert
            Assert.That(actualPassword, Is.EqualTo(expectedPassword));
            Assert.That(actualPasswordChanged, Is.EqualTo(expectedPasswordChanged));
        }
        
        [Test]
        [TestCase("31968027", "319", "31968027")]
        [TestCase("31968027", "680", "31968027")]
        [TestCase("31968027", "180", "31968027")]
        [TestCase("31968027", "690", "31698027")]
        public void PasswordOrderingTest(string passwordBefore, string passcode, string expectedPasswordAfter)
        {
            // Arrange
            LinkedList<int> passwordLinkedList = TestUtilities.CreatePasswordLinkedList(passwordBefore);
            
            // Act
            passwordLinkedList.ReorderPasswordToMatchPasscode(passcode);
            
            // Assert
            string actualPasswordAfter = passwordLinkedList.GetString();
            Assert.That(actualPasswordAfter, Is.EqualTo(expectedPasswordAfter));
        }
    }
}