using NUnit.Framework;

namespace Problem54.Test
{
    [TestFixture]
    public class CardTests
    {
        [Test]
        [TestCase("2D")]
        [TestCase("2C")]
        [TestCase("2H")]
        [TestCase("2S")]
        
        [TestCase("3D")]
        [TestCase("3C")]
        [TestCase("3H")]
        [TestCase("3S")]
        
        [TestCase("4D")]
        [TestCase("4C")]
        [TestCase("4H")]
        [TestCase("4S")]
        
        [TestCase("5D")]
        [TestCase("5C")]
        [TestCase("5H")]
        [TestCase("5S")]
        
        [TestCase("6D")]
        [TestCase("6C")]
        [TestCase("6H")]
        [TestCase("6S")]
        
        [TestCase("7D")]
        [TestCase("7C")]
        [TestCase("7H")]
        [TestCase("7S")]
        
        [TestCase("8D")]
        [TestCase("8C")]
        [TestCase("8H")]
        [TestCase("8S")]
        
        [TestCase("9D")]
        [TestCase("9C")]
        [TestCase("9H")]
        [TestCase("9S")]
        
        [TestCase("TD")]
        [TestCase("TC")]
        [TestCase("TH")]
        [TestCase("TS")]
        
        [TestCase("JD")]
        [TestCase("JC")]
        [TestCase("JH")]
        [TestCase("JS")]
        
        [TestCase("QD")]
        [TestCase("QC")]
        [TestCase("QH")]
        [TestCase("QS")]
        
        [TestCase("KD")]
        [TestCase("KC")]
        [TestCase("KH")]
        [TestCase("KS")]
        
        [TestCase("AD")]
        [TestCase("AC")]
        [TestCase("AH")]
        [TestCase("AS")]
        public void ConvertCardsFromStringAndToStringTest(string expectedCardString)
        {
            // Arrange
            Card card = new Card(expectedCardString);
            
            // Act
            string actualCardString = card.ToString();
            
            // Assert
            Assert.That(actualCardString, Is.EqualTo(expectedCardString));
        }
    }
}