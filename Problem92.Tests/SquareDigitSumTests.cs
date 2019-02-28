using NUnit.Framework;

namespace Problem92.Tests
{
    public class SquareDigitSumTests
    {
        [Test]
        [TestCase(44, 32)]
        [TestCase(32, 13)]
        [TestCase(13, 10)]
        [TestCase(10, 1)]
        [TestCase(1, 1)]
        public void ChainSequence1Test(int number, int expectedSquareDigitSum)
        {
            // Arrange
            
            // Act
            int squareDigitSum = Program.GetSquareDigitSum(number);
            
            // Asserts
            Assert.That(squareDigitSum, Is.EqualTo(expectedSquareDigitSum));
        }
        
        [Test]
        [TestCase(85, 89)]
        [TestCase(89, 145)]
        [TestCase(145, 42)]
        [TestCase(42, 20)]
        [TestCase(20, 4)]
        [TestCase(4, 16)]
        [TestCase(16, 37)]
        [TestCase(37, 58)]
        [TestCase(58, 89)]
        public void ChainSequence2Test(int number, int expectedSquareDigitSum)
        {
            // Arrange
            
            // Act
            int squareDigitSum = Program.GetSquareDigitSum(number);
            
            // Asserts
            Assert.That(squareDigitSum, Is.EqualTo(expectedSquareDigitSum));
        }
        
        [Test]
        [TestCase(44, 1)]
        [TestCase(85, 89)]
        public void ChainTerminatorTest(int number, int expectedChainTerminator)
        {
            // Arrange
            
            // Act
            int chainTerminator = Program.CreateSquareDigitSumChain(number);
            
            // Asserts
            Assert.That(chainTerminator, Is.EqualTo(expectedChainTerminator));
        }
    }
}