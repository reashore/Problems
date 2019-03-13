using System.Collections.Generic;
using NUnit.Framework;

namespace Problem61.Tests
{
    public class Problem61Tests
    {
        [Test]
        public void GetFirstAndlastTwoDigitsTest()
        {
            // Arrange
            const int value = 1234;
            const string expectedFirstTwoDigits = "12";
            const string expectedLastTwoDigits = "34";
            
            // act
            string actualFirstTwoDigits = Problem61.GetFirstTwoDigits(value);
            string actualLastTwoDigits = Problem61.GetLastTwoDigits(value);

            // Assert
            Assert.That(actualFirstTwoDigits, Is.EqualTo(expectedFirstTwoDigits));
            Assert.That(actualLastTwoDigits, Is.EqualTo(expectedLastTwoDigits));
        }
        
        [Test]
        public void AreCyclicNumbersTest()
        {
            // Arrange
            List<int> cyclicNumberList = new List<int>
            {
                8128,
                2882,
                8281
            };
            const bool expectedResult = true;
            
            // act
            bool actualResult = Problem61.IsCyclicNumberSet(cyclicNumberList);

            // Assert
            Assert.That(actualResult, Is.EqualTo(expectedResult));
        }
    }
}