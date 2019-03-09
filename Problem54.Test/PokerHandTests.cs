using NUnit.Framework;

namespace Problem54.Test
{
    [TestFixture]
    public class PokerHandTests
    {
        [Test]
        // Is royal flush
        [TestCase("AC", "KC", "QC", "JC", "TC", true)]
        [TestCase("AD", "KD", "QD", "JD", "TD", true)]
        [TestCase("AH", "KH", "QH", "JH", "TH", true)]
        [TestCase("AS", "KS", "QS", "JS", "TS", true)]
        // Is not royal flush
        [TestCase("AD", "KD", "QD", "JD", "TC", false)]
        public void IsRoyalFlushTest(
            string card1String, 
            string card2String, 
            string card3String, 
            string card4String, 
            string card5String, 
            bool expectedResult)
        {
            // Arrange
            Hand hand = new Hand(
                card1String, 
                card2String, 
                card3String, 
                card4String, 
                card5String);

            // Act
            bool actualResult = hand.IsRoyalFlush();
            
            // Assert
            Assert.That(actualResult, Is.EqualTo(expectedResult));
        }

        [Test]
        // Is straight flush
        [TestCase("KC", "QC", "JC", "TC", "9C", true)]
        [TestCase("QC", "JC", "TC", "9C", "8C", true)]
        [TestCase("JC", "TC", "9C", "8C", "7C", true)]
        [TestCase("TC", "9C", "8C", "7C", "6C", true)]
        [TestCase("9C", "8C", "7C", "6C", "5C", true)]
        [TestCase("8C", "7C", "6C", "5C", "4C", true)]
        [TestCase("7C", "6C", "5C", "4C", "3C", true)]
        [TestCase("6C", "5C", "4C", "3C", "2C", true)]
        
        [TestCase("KD", "QD", "JD", "TD", "9D", true)]
        [TestCase("QD", "JD", "TD", "9D", "8D", true)]
        [TestCase("JD", "TD", "9D", "8D", "7D", true)]
        [TestCase("TD", "9D", "8D", "7D", "6D", true)]
        [TestCase("9D", "8D", "7D", "6D", "5D", true)]
        [TestCase("8D", "7D", "6D", "5D", "4D", true)]
        [TestCase("7D", "6D", "5D", "4D", "3D", true)]
        [TestCase("6D", "5D", "4D", "3D", "2D", true)]
        
        [TestCase("KH", "QH", "JH", "TH", "9H", true)]
        [TestCase("QH", "JH", "TH", "9H", "8H", true)]
        [TestCase("JH", "TH", "9H", "8H", "7H", true)]
        [TestCase("TH", "9H", "8H", "7H", "6H", true)]
        [TestCase("9H", "8H", "7H", "6H", "5H", true)]
        [TestCase("8H", "7H", "6H", "5H", "4H", true)]
        [TestCase("7H", "6H", "5H", "4H", "3H", true)]
        [TestCase("6H", "5H", "4H", "3H", "2H", true)]
        
        [TestCase("KS", "QS", "JS", "TS", "9S", true)]
        [TestCase("QS", "JS", "TS", "9S", "8S", true)]
        [TestCase("JS", "TS", "9S", "8S", "7S", true)]
        [TestCase("TS", "9S", "8S", "7S", "6S", true)]
        [TestCase("9S", "8S", "7S", "6S", "5S", true)]
        [TestCase("8S", "7S", "6S", "5S", "4S", true)]
        [TestCase("7S", "6S", "5S", "4S", "3S", true)]
        [TestCase("6S", "5S", "4S", "3S", "2S", true)]
        // Is not royal flush
        [TestCase("AC", "KC", "QC", "JC", "TC", false)]
        [TestCase("AD", "KD", "QD", "JD", "TD", false)]
        [TestCase("AH", "KH", "QH", "JH", "TH", false)]
        [TestCase("AS", "KS", "QS", "JS", "TS", false)]
        // Is other
        [TestCase("AC", "KC", "QC", "JC", "TC", false)]
        [TestCase("6D", "5D", "4D", "3D", "2S", false)]
        [TestCase("TH", "9S", "8H", "7H", "6H", false)]
        public void IsStraightFlushTest(
            string card1String, 
            string card2String, 
            string card3String, 
            string card4String, 
            string card5String, 
            bool expectedResult)
        {
            // Arrange
            Hand hand = new Hand(
                card1String, 
                card2String, 
                card3String, 
                card4String, 
                card5String);

            // Act
            bool actualResult = hand.IsStraightFlush();
            
            // Assert
            Assert.That(actualResult, Is.EqualTo(expectedResult));
        }

        [Test]
        // Is four of a kind
        [TestCase("2C", "2D", "2H", "2S", "6H", true)]
        [TestCase("3C", "3D", "3H", "3S", "6H", true)]
        [TestCase("4C", "4D", "4H", "4S", "6H", true)]
        [TestCase("5C", "5D", "5H", "5S", "6H", true)]
        [TestCase("6C", "6D", "6H", "6S", "5H", true)]
        [TestCase("7C", "7D", "7H", "7S", "6H", true)]
        [TestCase("8C", "8D", "8H", "8S", "6H", true)]
        [TestCase("9C", "9D", "9H", "9S", "6H", true)]
        [TestCase("TC", "TD", "TH", "TS", "6H", true)]
        [TestCase("JC", "JD", "JH", "JS", "6H", true)]
        [TestCase("QC", "QD", "QH", "QS", "6H", true)]
        [TestCase("KC", "KD", "KH", "KS", "6H", true)]
        // Is not royal flush
        [TestCase("AC", "KC", "QC", "JC", "TC", false)]
        [TestCase("AD", "KD", "QD", "JD", "TD", false)]
        [TestCase("AH", "KH", "QH", "JH", "TH", false)]
        [TestCase("AS", "KS", "QS", "JS", "TS", false)]
        // Is not straight flush
        [TestCase("KC", "QC", "JC", "TC", "9C", false)]
        [TestCase("QC", "JC", "TC", "9C", "8C", false)]
        [TestCase("JC", "TC", "9C", "8C", "7C", false)]
        [TestCase("TC", "9C", "8C", "7C", "6C", false)]
        [TestCase("9C", "8C", "7C", "6C", "5C", false)]
        [TestCase("8C", "7C", "6C", "5C", "4C", false)]
        [TestCase("7C", "6C", "5C", "4C", "3C", false)]
        [TestCase("6C", "5C", "4C", "3C", "2C", false)]
        
        [TestCase("KD", "QD", "JD", "TD", "9D", false)]
        [TestCase("QD", "JD", "TD", "9D", "8D", false)]
        [TestCase("JD", "TD", "9D", "8D", "7D", false)]
        [TestCase("TD", "9D", "8D", "7D", "6D", false)]
        [TestCase("9D", "8D", "7D", "6D", "5D", false)]
        [TestCase("8D", "7D", "6D", "5D", "4D", false)]
        [TestCase("7D", "6D", "5D", "4D", "3D", false)]
        [TestCase("6D", "5D", "4D", "3D", "2D", false)]
        
        [TestCase("KH", "QH", "JH", "TH", "9H", false)]
        [TestCase("QH", "JH", "TH", "9H", "8H", false)]
        [TestCase("JH", "TH", "9H", "8H", "7H", false)]
        [TestCase("TH", "9H", "8H", "7H", "6H", false)]
        [TestCase("9H", "8H", "7H", "6H", "5H", false)]
        [TestCase("8H", "7H", "6H", "5H", "4H", false)]
        [TestCase("7H", "6H", "5H", "4H", "3H", false)]
        [TestCase("6H", "5H", "4H", "3H", "2H", false)]
        
        [TestCase("KS", "QS", "JS", "TS", "9S", false)]
        [TestCase("QS", "JS", "TS", "9S", "8S", false)]
        [TestCase("JS", "TS", "9S", "8S", "7S", false)]
        [TestCase("TS", "9S", "8S", "7S", "6S", false)]
        [TestCase("9S", "8S", "7S", "6S", "5S", false)]
        [TestCase("8S", "7S", "6S", "5S", "4S", false)]
        [TestCase("7S", "6S", "5S", "4S", "3S", false)]
        [TestCase("6S", "5S", "4S", "3S", "2S", false)]
        // Other tests
        [TestCase("AC", "KC", "QC", "JC", "TC", false)]
        [TestCase("6D", "5D", "4D", "3D", "2D", false)]
        [TestCase("TH", "9H", "8H", "7H", "6H", false)]
        public void IsFourOfKindTest(
            string card1String, 
            string card2String, 
            string card3String, 
            string card4String, 
            string card5String, 
            bool expectedResult)
        {
            // Arrange
            Hand hand = new Hand(
                card1String, 
                card2String, 
                card3String, 
                card4String, 
                card5String);

            // Act
            bool actualResult = hand.IsFourOfKind();
            
            // Assert
            Assert.That(actualResult, Is.EqualTo(expectedResult));
        }
        
        [Test]
        // Is full-house
        [TestCase("2C", "2D", "2H", "3S", "3H", true)]
        [TestCase("3C", "3D", "3H", "2S", "2H", true)]
        [TestCase("4C", "4D", "4H", "3S", "3H", true)]
        [TestCase("5C", "5D", "5H", "3S", "3H", true)]
        [TestCase("6C", "6D", "6H", "3S", "3H", true)]
        [TestCase("7C", "7D", "7H", "3S", "3H", true)]
        [TestCase("8C", "8D", "8H", "3S", "3H", true)]
        [TestCase("9C", "9D", "9H", "3S", "3H", true)]
        [TestCase("TC", "TD", "TH", "3S", "3H", true)]
        [TestCase("JC", "JD", "JH", "3S", "3H", true)]
        [TestCase("QC", "QD", "QH", "3S", "3H", true)]
        [TestCase("KC", "KD", "KH", "3S", "3H", true)]
        [TestCase("AC", "AD", "AH", "3S", "3H", true)]
        // Is not royal flush
        [TestCase("AC", "KC", "QC", "JC", "TC", false)]
        [TestCase("AD", "KD", "QD", "JD", "TD", false)]
        [TestCase("AH", "KH", "QH", "JH", "TH", false)]
        [TestCase("AS", "KS", "QS", "JS", "TS", false)]
        // Is not straight flush
        [TestCase("KC", "QC", "JC", "TC", "9C", false)]
        [TestCase("QC", "JC", "TC", "9C", "8C", false)]
        [TestCase("JC", "TC", "9C", "8C", "7C", false)]
        [TestCase("TC", "9C", "8C", "7C", "6C", false)]
        [TestCase("9C", "8C", "7C", "6C", "5C", false)]
        [TestCase("8C", "7C", "6C", "5C", "4C", false)]
        [TestCase("7C", "6C", "5C", "4C", "3C", false)]
        [TestCase("6C", "5C", "4C", "3C", "2C", false)]
        
        [TestCase("KD", "QD", "JD", "TD", "9D", false)]
        [TestCase("QD", "JD", "TD", "9D", "8D", false)]
        [TestCase("JD", "TD", "9D", "8D", "7D", false)]
        [TestCase("TD", "9D", "8D", "7D", "6D", false)]
        [TestCase("9D", "8D", "7D", "6D", "5D", false)]
        [TestCase("8D", "7D", "6D", "5D", "4D", false)]
        [TestCase("7D", "6D", "5D", "4D", "3D", false)]
        [TestCase("6D", "5D", "4D", "3D", "2D", false)]
        
        [TestCase("KH", "QH", "JH", "TH", "9H", false)]
        [TestCase("QH", "JH", "TH", "9H", "8H", false)]
        [TestCase("JH", "TH", "9H", "8H", "7H", false)]
        [TestCase("TH", "9H", "8H", "7H", "6H", false)]
        [TestCase("9H", "8H", "7H", "6H", "5H", false)]
        [TestCase("8H", "7H", "6H", "5H", "4H", false)]
        [TestCase("7H", "6H", "5H", "4H", "3H", false)]
        [TestCase("6H", "5H", "4H", "3H", "2H", false)]
        
        [TestCase("KS", "QS", "JS", "TS", "9S", false)]
        [TestCase("QS", "JS", "TS", "9S", "8S", false)]
        [TestCase("JS", "TS", "9S", "8S", "7S", false)]
        [TestCase("TS", "9S", "8S", "7S", "6S", false)]
        [TestCase("9S", "8S", "7S", "6S", "5S", false)]
        [TestCase("8S", "7S", "6S", "5S", "4S", false)]
        [TestCase("7S", "6S", "5S", "4S", "3S", false)]
        [TestCase("6S", "5S", "4S", "3S", "2S", false)]
        // Is not four of a kind
        [TestCase("2C", "2D", "2H", "2S", "6H", false)]
        [TestCase("3C", "3D", "3H", "3S", "6H", false)]
        [TestCase("4C", "4D", "4H", "4S", "6H", false)]
        [TestCase("5C", "5D", "5H", "5S", "6H", false)]
        [TestCase("6C", "6D", "6H", "6S", "5H", false)]
        [TestCase("7C", "7D", "7H", "7S", "6H", false)]
        [TestCase("8C", "8D", "8H", "8S", "6H", false)]
        [TestCase("9C", "9D", "9H", "9S", "6H", false)]
        [TestCase("TC", "TD", "TH", "TS", "6H", false)]
        [TestCase("JC", "JD", "JH", "JS", "6H", false)]
        [TestCase("QC", "QD", "QH", "QS", "6H", false)]
        [TestCase("KC", "KD", "KH", "KS", "6H", false)]
        // Is other
        [TestCase("7C", "7D", "4H", "4S", "4H", true)]
        [TestCase("7C", "7D", "7H", "7S", "4H", false)]
        public void IsFullHouseTest(
            string card1String, 
            string card2String, 
            string card3String, 
            string card4String, 
            string card5String, 
            bool expectedResult)
        {
            // Arrange
            Hand hand = new Hand(
                card1String, 
                card2String, 
                card3String, 
                card4String, 
                card5String);

            // Act
            bool actualResult = hand.IsFullHouse();
            
            // Assert
            Assert.That(actualResult, Is.EqualTo(expectedResult));
        }

        [Test]
        // Is flush
        [TestCase("2C", "4C", "6C", "8C", "TC", true)]
        [TestCase("2D", "4D", "6D", "8D", "TD", true)]
        [TestCase("2H", "4H", "6H", "8H", "TH", true)]
        [TestCase("2S", "4S", "6S", "8S", "TS", true)]
        
        [TestCase("3C", "5C", "7C", "9C", "TC", true)]
        [TestCase("3D", "5D", "7D", "9D", "TD", true)]
        [TestCase("3H", "5H", "7H", "9H", "TH", true)]
        [TestCase("3S", "5S", "7S", "9S", "TS", true)]
        // Is not royal flush
        [TestCase("AC", "KC", "QC", "JC", "TC", false)]
        [TestCase("AD", "KD", "QD", "JD", "TD", false)]
        [TestCase("AH", "KH", "QH", "JH", "TH", false)]
        [TestCase("AS", "KS", "QS", "JS", "TS", false)]
        // Is not straight flush
        [TestCase("KC", "QC", "JC", "TC", "9C", false)]
        [TestCase("QC", "JC", "TC", "9C", "8C", false)]
        [TestCase("JC", "TC", "9C", "8C", "7C", false)]
        [TestCase("TC", "9C", "8C", "7C", "6C", false)]
        [TestCase("9C", "8C", "7C", "6C", "5C", false)]
        [TestCase("8C", "7C", "6C", "5C", "4C", false)]
        [TestCase("7C", "6C", "5C", "4C", "3C", false)]
        [TestCase("6C", "5C", "4C", "3C", "2C", false)]
        
        [TestCase("KD", "QD", "JD", "TD", "9D", false)]
        [TestCase("QD", "JD", "TD", "9D", "8D", false)]
        [TestCase("JD", "TD", "9D", "8D", "7D", false)]
        [TestCase("TD", "9D", "8D", "7D", "6D", false)]
        [TestCase("9D", "8D", "7D", "6D", "5D", false)]
        [TestCase("8D", "7D", "6D", "5D", "4D", false)]
        [TestCase("7D", "6D", "5D", "4D", "3D", false)]
        [TestCase("6D", "5D", "4D", "3D", "2D", false)]
        
        [TestCase("KH", "QH", "JH", "TH", "9H", false)]
        [TestCase("QH", "JH", "TH", "9H", "8H", false)]
        [TestCase("JH", "TH", "9H", "8H", "7H", false)]
        [TestCase("TH", "9H", "8H", "7H", "6H", false)]
        [TestCase("9H", "8H", "7H", "6H", "5H", false)]
        [TestCase("8H", "7H", "6H", "5H", "4H", false)]
        [TestCase("7H", "6H", "5H", "4H", "3H", false)]
        [TestCase("6H", "5H", "4H", "3H", "2H", false)]
        
        [TestCase("KS", "QS", "JS", "TS", "9S", false)]
        [TestCase("QS", "JS", "TS", "9S", "8S", false)]
        [TestCase("JS", "TS", "9S", "8S", "7S", false)]
        [TestCase("TS", "9S", "8S", "7S", "6S", false)]
        [TestCase("9S", "8S", "7S", "6S", "5S", false)]
        [TestCase("8S", "7S", "6S", "5S", "4S", false)]
        [TestCase("7S", "6S", "5S", "4S", "3S", false)]
        [TestCase("6S", "5S", "4S", "3S", "2S", false)]
        // Is not four of a kind
        [TestCase("2C", "2D", "2H", "2S", "6H", false)]
        [TestCase("3C", "3D", "3H", "3S", "6H", false)]
        [TestCase("4C", "4D", "4H", "4S", "6H", false)]
        [TestCase("5C", "5D", "5H", "5S", "6H", false)]
        [TestCase("6C", "6D", "6H", "6S", "5H", false)]
        [TestCase("7C", "7D", "7H", "7S", "6H", false)]
        [TestCase("8C", "8D", "8H", "8S", "6H", false)]
        [TestCase("9C", "9D", "9H", "9S", "6H", false)]
        [TestCase("TC", "TD", "TH", "TS", "6H", false)]
        [TestCase("JC", "JD", "JH", "JS", "6H", false)]
        [TestCase("QC", "QD", "QH", "QS", "6H", false)]
        [TestCase("KC", "KD", "KH", "KS", "6H", false)]
        // Is not full-house
        [TestCase("2C", "2D", "2H", "3S", "3H", false)]
        [TestCase("3C", "3D", "3H", "2S", "2H", false)]
        [TestCase("4C", "4D", "4H", "3S", "3H", false)]
        [TestCase("5C", "5D", "5H", "3S", "3H", false)]
        [TestCase("6C", "6D", "6H", "3S", "3H", false)]
        [TestCase("7C", "7D", "7H", "3S", "3H", false)]
        [TestCase("8C", "8D", "8H", "3S", "3H", false)]
        [TestCase("9C", "9D", "9H", "3S", "3H", false)]
        [TestCase("TC", "TD", "TH", "3S", "3H", false)]
        [TestCase("JC", "JD", "JH", "3S", "3H", false)]
        [TestCase("QC", "QD", "QH", "3S", "3H", false)]
        [TestCase("KC", "KD", "KH", "3S", "3H", false)]
        [TestCase("AC", "AD", "AH", "3S", "3H", false)]
        // Is other
        [TestCase("2S", "4S", "6S", "8S", "TD", false)]
        public void IsFLushTest(
            string card1String, 
            string card2String, 
            string card3String, 
            string card4String, 
            string card5String, 
            bool expectedResult)
        {
            // Arrange
            Hand hand = new Hand(
                card1String, 
                card2String, 
                card3String, 
                card4String, 
                card5String);

            // Act
            bool actualResult = hand.IsFlush();
            
            // Assert
            Assert.That(actualResult, Is.EqualTo(expectedResult));
        }

        [Test]
        // Is straight
        [TestCase("2C", "3H", "4D", "5S", "6C", true)]
        [TestCase("3C", "4H", "5D", "6S", "7C", true)]
        [TestCase("4C", "5H", "6D", "7S", "8C", true)]
        [TestCase("5C", "6H", "7D", "8S", "9C", true)]
        [TestCase("6C", "7H", "8D", "9S", "TC", true)]
        [TestCase("7C", "8H", "9D", "TS", "JC", true)]
        [TestCase("8C", "9H", "TD", "JS", "QC", true)]
        [TestCase("9C", "TH", "JD", "QS", "KC", true)]
        [TestCase("TC", "JH", "QD", "KS", "AC", true)]
        // Is not royal flush
        [TestCase("AC", "KC", "QC", "JC", "TC", false)]
        [TestCase("AD", "KD", "QD", "JD", "TD", false)]
        [TestCase("AH", "KH", "QH", "JH", "TH", false)]
        [TestCase("AS", "KS", "QS", "JS", "TS", false)]
        // Is not straight flush
        [TestCase("KC", "QC", "JC", "TC", "9C", false)]
        [TestCase("QC", "JC", "TC", "9C", "8C", false)]
        [TestCase("JC", "TC", "9C", "8C", "7C", false)]
        [TestCase("TC", "9C", "8C", "7C", "6C", false)]
        [TestCase("9C", "8C", "7C", "6C", "5C", false)]
        [TestCase("8C", "7C", "6C", "5C", "4C", false)]
        [TestCase("7C", "6C", "5C", "4C", "3C", false)]
        [TestCase("6C", "5C", "4C", "3C", "2C", false)]
        
        [TestCase("KD", "QD", "JD", "TD", "9D", false)]
        [TestCase("QD", "JD", "TD", "9D", "8D", false)]
        [TestCase("JD", "TD", "9D", "8D", "7D", false)]
        [TestCase("TD", "9D", "8D", "7D", "6D", false)]
        [TestCase("9D", "8D", "7D", "6D", "5D", false)]
        [TestCase("8D", "7D", "6D", "5D", "4D", false)]
        [TestCase("7D", "6D", "5D", "4D", "3D", false)]
        [TestCase("6D", "5D", "4D", "3D", "2D", false)]
        
        [TestCase("KH", "QH", "JH", "TH", "9H", false)]
        [TestCase("QH", "JH", "TH", "9H", "8H", false)]
        [TestCase("JH", "TH", "9H", "8H", "7H", false)]
        [TestCase("TH", "9H", "8H", "7H", "6H", false)]
        [TestCase("9H", "8H", "7H", "6H", "5H", false)]
        [TestCase("8H", "7H", "6H", "5H", "4H", false)]
        [TestCase("7H", "6H", "5H", "4H", "3H", false)]
        [TestCase("6H", "5H", "4H", "3H", "2H", false)]
        
        [TestCase("KS", "QS", "JS", "TS", "9S", false)]
        [TestCase("QS", "JS", "TS", "9S", "8S", false)]
        [TestCase("JS", "TS", "9S", "8S", "7S", false)]
        [TestCase("TS", "9S", "8S", "7S", "6S", false)]
        [TestCase("9S", "8S", "7S", "6S", "5S", false)]
        [TestCase("8S", "7S", "6S", "5S", "4S", false)]
        [TestCase("7S", "6S", "5S", "4S", "3S", false)]
        [TestCase("6S", "5S", "4S", "3S", "2S", false)]
        // Is not four of a kind
        [TestCase("2C", "2D", "2H", "2S", "6H", false)]
        [TestCase("3C", "3D", "3H", "3S", "6H", false)]
        [TestCase("4C", "4D", "4H", "4S", "6H", false)]
        [TestCase("5C", "5D", "5H", "5S", "6H", false)]
        [TestCase("6C", "6D", "6H", "6S", "5H", false)]
        [TestCase("7C", "7D", "7H", "7S", "6H", false)]
        [TestCase("8C", "8D", "8H", "8S", "6H", false)]
        [TestCase("9C", "9D", "9H", "9S", "6H", false)]
        [TestCase("TC", "TD", "TH", "TS", "6H", false)]
        [TestCase("JC", "JD", "JH", "JS", "6H", false)]
        [TestCase("QC", "QD", "QH", "QS", "6H", false)]
        [TestCase("KC", "KD", "KH", "KS", "6H", false)]
        // Is not full-house
        [TestCase("2C", "2D", "2H", "3S", "3H", false)]
        [TestCase("3C", "3D", "3H", "2S", "2H", false)]
        [TestCase("4C", "4D", "4H", "3S", "3H", false)]
        [TestCase("5C", "5D", "5H", "3S", "3H", false)]
        [TestCase("6C", "6D", "6H", "3S", "3H", false)]
        [TestCase("7C", "7D", "7H", "3S", "3H", false)]
        [TestCase("8C", "8D", "8H", "3S", "3H", false)]
        [TestCase("9C", "9D", "9H", "3S", "3H", false)]
        [TestCase("TC", "TD", "TH", "3S", "3H", false)]
        [TestCase("JC", "JD", "JH", "3S", "3H", false)]
        [TestCase("QC", "QD", "QH", "3S", "3H", false)]
        [TestCase("KC", "KD", "KH", "3S", "3H", false)]
        [TestCase("AC", "AD", "AH", "3S", "3H", false)]
        // Is not flush
        [TestCase("2C", "4C", "6C", "8C", "TC", false)]
        [TestCase("2D", "4D", "6D", "8D", "TD", false)]
        [TestCase("2H", "4H", "6H", "8H", "TH", false)]
        [TestCase("2S", "4S", "6S", "8S", "TS", false)]
        
        [TestCase("3C", "5C", "7C", "9C", "TC", false)]
        [TestCase("3D", "5D", "7D", "9D", "TD", false)]
        [TestCase("3H", "5H", "7H", "9H", "TH", false)]
        [TestCase("3S", "5S", "7S", "9S", "TS", false)]
        // Is other
        [TestCase("KC", "QH", "JD", "TS", "9C", true)]
        [TestCase("KC", "QH", "JD", "TS", "8C", false)]
        public void IsStraightTest(
            string card1String, 
            string card2String, 
            string card3String, 
            string card4String, 
            string card5String, 
            bool expectedResult)
        {
            // Arrange
            Hand hand = new Hand(
                card1String, 
                card2String, 
                card3String, 
                card4String, 
                card5String);

            // Act
            bool actualResult = hand.IsStraight();
            
            // Assert
            Assert.That(actualResult, Is.EqualTo(expectedResult));
        }

        [Test]
        // Is three of a kind
        [TestCase("2C", "2H", "2D", "3S", "4C", true)]
        [TestCase("3C", "3H", "3D", "6S", "4C", true)]
        [TestCase("4C", "4H", "4D", "3S", "5C", true)]
        [TestCase("5C", "5H", "5D", "3S", "4C", true)]
        [TestCase("6C", "6H", "6D", "3S", "4C", true)]
        [TestCase("7C", "7H", "7D", "3S", "4C", true)]
        [TestCase("8C", "8H", "8D", "3S", "4C", true)]
        [TestCase("9C", "9H", "9D", "3S", "4C", true)]
        [TestCase("TC", "TH", "TD", "3S", "4C", true)]
        [TestCase("JC", "JH", "JD", "3S", "4C", true)]
        [TestCase("QC", "QH", "QD", "3S", "4C", true)]
        [TestCase("KC", "KH", "KD", "3S", "4C", true)]
        [TestCase("AC", "AH", "AD", "3S", "4C", true)]
        // Is not royal flush
        [TestCase("AC", "KC", "QC", "JC", "TC", false)]
        [TestCase("AD", "KD", "QD", "JD", "TD", false)]
        [TestCase("AH", "KH", "QH", "JH", "TH", false)]
        [TestCase("AS", "KS", "QS", "JS", "TS", false)]
        // Is not straight flush
        [TestCase("KC", "QC", "JC", "TC", "9C", false)]
        [TestCase("QC", "JC", "TC", "9C", "8C", false)]
        [TestCase("JC", "TC", "9C", "8C", "7C", false)]
        [TestCase("TC", "9C", "8C", "7C", "6C", false)]
        [TestCase("9C", "8C", "7C", "6C", "5C", false)]
        [TestCase("8C", "7C", "6C", "5C", "4C", false)]
        [TestCase("7C", "6C", "5C", "4C", "3C", false)]
        [TestCase("6C", "5C", "4C", "3C", "2C", false)]
        
        [TestCase("KD", "QD", "JD", "TD", "9D", false)]
        [TestCase("QD", "JD", "TD", "9D", "8D", false)]
        [TestCase("JD", "TD", "9D", "8D", "7D", false)]
        [TestCase("TD", "9D", "8D", "7D", "6D", false)]
        [TestCase("9D", "8D", "7D", "6D", "5D", false)]
        [TestCase("8D", "7D", "6D", "5D", "4D", false)]
        [TestCase("7D", "6D", "5D", "4D", "3D", false)]
        [TestCase("6D", "5D", "4D", "3D", "2D", false)]
        
        [TestCase("KH", "QH", "JH", "TH", "9H", false)]
        [TestCase("QH", "JH", "TH", "9H", "8H", false)]
        [TestCase("JH", "TH", "9H", "8H", "7H", false)]
        [TestCase("TH", "9H", "8H", "7H", "6H", false)]
        [TestCase("9H", "8H", "7H", "6H", "5H", false)]
        [TestCase("8H", "7H", "6H", "5H", "4H", false)]
        [TestCase("7H", "6H", "5H", "4H", "3H", false)]
        [TestCase("6H", "5H", "4H", "3H", "2H", false)]
        
        [TestCase("KS", "QS", "JS", "TS", "9S", false)]
        [TestCase("QS", "JS", "TS", "9S", "8S", false)]
        [TestCase("JS", "TS", "9S", "8S", "7S", false)]
        [TestCase("TS", "9S", "8S", "7S", "6S", false)]
        [TestCase("9S", "8S", "7S", "6S", "5S", false)]
        [TestCase("8S", "7S", "6S", "5S", "4S", false)]
        [TestCase("7S", "6S", "5S", "4S", "3S", false)]
        [TestCase("6S", "5S", "4S", "3S", "2S", false)]
        // Is not four of a kind
        [TestCase("2C", "2D", "2H", "2S", "6H", false)]
        [TestCase("3C", "3D", "3H", "3S", "6H", false)]
        [TestCase("4C", "4D", "4H", "4S", "6H", false)]
        [TestCase("5C", "5D", "5H", "5S", "6H", false)]
        [TestCase("6C", "6D", "6H", "6S", "5H", false)]
        [TestCase("7C", "7D", "7H", "7S", "6H", false)]
        [TestCase("8C", "8D", "8H", "8S", "6H", false)]
        [TestCase("9C", "9D", "9H", "9S", "6H", false)]
        [TestCase("TC", "TD", "TH", "TS", "6H", false)]
        [TestCase("JC", "JD", "JH", "JS", "6H", false)]
        [TestCase("QC", "QD", "QH", "QS", "6H", false)]
        [TestCase("KC", "KD", "KH", "KS", "6H", false)]
        // Is not full-house
        [TestCase("2C", "2D", "2H", "3S", "3H", false)]
        [TestCase("3C", "3D", "3H", "2S", "2H", false)]
        [TestCase("4C", "4D", "4H", "3S", "3H", false)]
        [TestCase("5C", "5D", "5H", "3S", "3H", false)]
        [TestCase("6C", "6D", "6H", "3S", "3H", false)]
        [TestCase("7C", "7D", "7H", "3S", "3H", false)]
        [TestCase("8C", "8D", "8H", "3S", "3H", false)]
        [TestCase("9C", "9D", "9H", "3S", "3H", false)]
        [TestCase("TC", "TD", "TH", "3S", "3H", false)]
        [TestCase("JC", "JD", "JH", "3S", "3H", false)]
        [TestCase("QC", "QD", "QH", "3S", "3H", false)]
        [TestCase("KC", "KD", "KH", "3S", "3H", false)]
        [TestCase("AC", "AD", "AH", "3S", "3H", false)]
        // Is not flush
        [TestCase("2C", "4C", "6C", "8C", "TC", false)]
        [TestCase("2D", "4D", "6D", "8D", "TD", false)]
        [TestCase("2H", "4H", "6H", "8H", "TH", false)]
        [TestCase("2S", "4S", "6S", "8S", "TS", false)]
        
        [TestCase("3C", "5C", "7C", "9C", "TC", false)]
        [TestCase("3D", "5D", "7D", "9D", "TD", false)]
        [TestCase("3H", "5H", "7H", "9H", "TH", false)]
        [TestCase("3S", "5S", "7S", "9S", "TS", false)]
        // Is not straight
        [TestCase("2C", "3H", "4D", "5S", "6C", false)]
        [TestCase("3C", "4H", "5D", "6S", "7C", false)]
        [TestCase("4C", "5H", "6D", "7S", "8C", false)]
        [TestCase("5C", "6H", "7D", "8S", "9C", false)]
        [TestCase("6C", "7H", "8D", "9S", "TC", false)]
        [TestCase("7C", "8H", "9D", "TS", "JC", false)]
        [TestCase("8C", "9H", "TD", "JS", "QC", false)]
        [TestCase("9C", "TH", "JD", "QS", "KC", false)]
        [TestCase("TC", "JH", "QD", "KS", "AC", false)]
        // Is other
        [TestCase("5C", "6H", "6D", "6S", "2C", true)]
        [TestCase("8C", "6H", "5D", "5S", "5C", true)]
        [TestCase("5C", "6H", "7D", "5S", "5C", true)]
        public void IsThreeOfKindTest(
            string card1String, 
            string card2String, 
            string card3String, 
            string card4String, 
            string card5String, 
            bool expectedResult)
        {
            // Arrange
            Hand hand = new Hand(
                card1String, 
                card2String, 
                card3String, 
                card4String, 
                card5String);

            // Act
            bool actualResult = hand.IsThreeOfKind();
            
            // Assert
            Assert.That(actualResult, Is.EqualTo(expectedResult));
        }

        [Test]
        // Is two pairs
        [TestCase("2C", "2H", "AD", "3S", "3C", true)]
        [TestCase("4C", "4H", "AD", "3S", "3C", true)]
        [TestCase("5C", "5H", "AD", "3S", "3C", true)]
        [TestCase("6C", "6H", "AD", "3S", "3C", true)]
        [TestCase("7C", "7H", "AD", "3S", "3C", true)]
        [TestCase("8C", "8H", "AD", "3S", "3C", true)]
        [TestCase("9C", "9H", "AD", "3S", "3C", true)]
        [TestCase("TC", "TH", "AD", "3S", "3C", true)]
        [TestCase("JC", "JH", "AD", "3S", "3C", true)]
        [TestCase("QC", "QH", "AD", "3S", "3C", true)]
        [TestCase("KC", "KH", "AD", "3S", "3C", true)]
        // Is not royal flush
        [TestCase("AC", "KC", "QC", "JC", "TC", false)]
        [TestCase("AD", "KD", "QD", "JD", "TD", false)]
        [TestCase("AH", "KH", "QH", "JH", "TH", false)]
        [TestCase("AS", "KS", "QS", "JS", "TS", false)]
        // Is not straight flush
        [TestCase("KC", "QC", "JC", "TC", "9C", false)]
        [TestCase("QC", "JC", "TC", "9C", "8C", false)]
        [TestCase("JC", "TC", "9C", "8C", "7C", false)]
        [TestCase("TC", "9C", "8C", "7C", "6C", false)]
        [TestCase("9C", "8C", "7C", "6C", "5C", false)]
        [TestCase("8C", "7C", "6C", "5C", "4C", false)]
        [TestCase("7C", "6C", "5C", "4C", "3C", false)]
        [TestCase("6C", "5C", "4C", "3C", "2C", false)]
        
        [TestCase("KD", "QD", "JD", "TD", "9D", false)]
        [TestCase("QD", "JD", "TD", "9D", "8D", false)]
        [TestCase("JD", "TD", "9D", "8D", "7D", false)]
        [TestCase("TD", "9D", "8D", "7D", "6D", false)]
        [TestCase("9D", "8D", "7D", "6D", "5D", false)]
        [TestCase("8D", "7D", "6D", "5D", "4D", false)]
        [TestCase("7D", "6D", "5D", "4D", "3D", false)]
        [TestCase("6D", "5D", "4D", "3D", "2D", false)]
        
        [TestCase("KH", "QH", "JH", "TH", "9H", false)]
        [TestCase("QH", "JH", "TH", "9H", "8H", false)]
        [TestCase("JH", "TH", "9H", "8H", "7H", false)]
        [TestCase("TH", "9H", "8H", "7H", "6H", false)]
        [TestCase("9H", "8H", "7H", "6H", "5H", false)]
        [TestCase("8H", "7H", "6H", "5H", "4H", false)]
        [TestCase("7H", "6H", "5H", "4H", "3H", false)]
        [TestCase("6H", "5H", "4H", "3H", "2H", false)]
        
        [TestCase("KS", "QS", "JS", "TS", "9S", false)]
        [TestCase("QS", "JS", "TS", "9S", "8S", false)]
        [TestCase("JS", "TS", "9S", "8S", "7S", false)]
        [TestCase("TS", "9S", "8S", "7S", "6S", false)]
        [TestCase("9S", "8S", "7S", "6S", "5S", false)]
        [TestCase("8S", "7S", "6S", "5S", "4S", false)]
        [TestCase("7S", "6S", "5S", "4S", "3S", false)]
        [TestCase("6S", "5S", "4S", "3S", "2S", false)]
        // Is not four of a kind
        [TestCase("2C", "2D", "2H", "2S", "6H", false)]
        [TestCase("3C", "3D", "3H", "3S", "6H", false)]
        [TestCase("4C", "4D", "4H", "4S", "6H", false)]
        [TestCase("5C", "5D", "5H", "5S", "6H", false)]
        [TestCase("6C", "6D", "6H", "6S", "5H", false)]
        [TestCase("7C", "7D", "7H", "7S", "6H", false)]
        [TestCase("8C", "8D", "8H", "8S", "6H", false)]
        [TestCase("9C", "9D", "9H", "9S", "6H", false)]
        [TestCase("TC", "TD", "TH", "TS", "6H", false)]
        [TestCase("JC", "JD", "JH", "JS", "6H", false)]
        [TestCase("QC", "QD", "QH", "QS", "6H", false)]
        [TestCase("KC", "KD", "KH", "KS", "6H", false)]
        // Is not full-house
        [TestCase("2C", "2D", "2H", "3S", "3H", false)]
        [TestCase("3C", "3D", "3H", "2S", "2H", false)]
        [TestCase("4C", "4D", "4H", "3S", "3H", false)]
        [TestCase("5C", "5D", "5H", "3S", "3H", false)]
        [TestCase("6C", "6D", "6H", "3S", "3H", false)]
        [TestCase("7C", "7D", "7H", "3S", "3H", false)]
        [TestCase("8C", "8D", "8H", "3S", "3H", false)]
        [TestCase("9C", "9D", "9H", "3S", "3H", false)]
        [TestCase("TC", "TD", "TH", "3S", "3H", false)]
        [TestCase("JC", "JD", "JH", "3S", "3H", false)]
        [TestCase("QC", "QD", "QH", "3S", "3H", false)]
        [TestCase("KC", "KD", "KH", "3S", "3H", false)]
        [TestCase("AC", "AD", "AH", "3S", "3H", false)]
        // Is not flush
        [TestCase("2C", "4C", "6C", "8C", "TC", false)]
        [TestCase("2D", "4D", "6D", "8D", "TD", false)]
        [TestCase("2H", "4H", "6H", "8H", "TH", false)]
        [TestCase("2S", "4S", "6S", "8S", "TS", false)]
        
        [TestCase("3C", "5C", "7C", "9C", "TC", false)]
        [TestCase("3D", "5D", "7D", "9D", "TD", false)]
        [TestCase("3H", "5H", "7H", "9H", "TH", false)]
        [TestCase("3S", "5S", "7S", "9S", "TS", false)]
        // Is not straight
        [TestCase("2C", "3H", "4D", "5S", "6C", false)]
        [TestCase("3C", "4H", "5D", "6S", "7C", false)]
        [TestCase("4C", "5H", "6D", "7S", "8C", false)]
        [TestCase("5C", "6H", "7D", "8S", "9C", false)]
        [TestCase("6C", "7H", "8D", "9S", "TC", false)]
        [TestCase("7C", "8H", "9D", "TS", "JC", false)]
        [TestCase("8C", "9H", "TD", "JS", "QC", false)]
        [TestCase("9C", "TH", "JD", "QS", "KC", false)]
        [TestCase("TC", "JH", "QD", "KS", "AC", false)]
        // Is not three of a kind
        [TestCase("2C", "2H", "2D", "3S", "4C", false)]
        [TestCase("3C", "3H", "3D", "6S", "4C", false)]
        [TestCase("4C", "4H", "4D", "3S", "5C", false)]
        [TestCase("5C", "5H", "5D", "3S", "4C", false)]
        [TestCase("6C", "6H", "6D", "3S", "4C", false)]
        [TestCase("7C", "7H", "7D", "3S", "4C", false)]
        [TestCase("8C", "8H", "8D", "3S", "4C", false)]
        [TestCase("9C", "9H", "9D", "3S", "4C", false)]
        [TestCase("TC", "TH", "TD", "3S", "4C", false)]
        [TestCase("JC", "JH", "JD", "3S", "4C", false)]
        [TestCase("QC", "QH", "QD", "3S", "4C", false)]
        [TestCase("KC", "KH", "KD", "3S", "4C", false)]
        [TestCase("AC", "AH", "AD", "3S", "4C", false)]
        // Is other
        [TestCase("6C", "6H", "2D", "4S", "4C", true)]
        [TestCase("6C", "4H", "2D", "4S", "6C", true)]
        [TestCase("3C", "4H", "6D", "6S", "4C", true)]
        public void IsTwoPairsTest(
            string card1String, 
            string card2String, 
            string card3String, 
            string card4String, 
            string card5String, 
            bool expectedResult)
        {
            // Arrange
            Hand hand = new Hand(
                card1String, 
                card2String, 
                card3String, 
                card4String, 
                card5String);

            // Act
            bool actualResult = hand.IsTwoPairs();
            
            // Assert
            Assert.That(actualResult, Is.EqualTo(expectedResult));
        }

        [Test]
        // Is one pair
        [TestCase("2C", "2H", "5D", "4S", "7C", true)]
        [TestCase("3C", "3H", "5D", "4S", "7C", true)]
        [TestCase("4C", "4H", "5D", "QS", "7C", true)]
        [TestCase("5C", "5H", "QD", "4S", "7C", true)]
        [TestCase("6C", "6H", "5D", "4S", "7C", true)]
        [TestCase("7C", "7H", "5D", "4S", "KC", true)]
        [TestCase("8C", "8H", "5D", "4S", "7C", true)]
        [TestCase("9C", "9H", "5D", "4S", "7C", true)]
        [TestCase("TC", "TH", "5D", "4S", "7C", true)]
        [TestCase("JC", "JH", "5D", "4S", "7C", true)]
        [TestCase("QC", "QH", "5D", "4S", "7C", true)]
        [TestCase("KC", "KH", "5D", "4S", "7C", true)]
        [TestCase("AC", "AH", "5D", "4S", "7C", true)]
        // Is not royal flush
        [TestCase("AC", "KC", "QC", "JC", "TC", false)]
        [TestCase("AD", "KD", "QD", "JD", "TD", false)]
        [TestCase("AH", "KH", "QH", "JH", "TH", false)]
        [TestCase("AS", "KS", "QS", "JS", "TS", false)]
        // Is not straight flush
        [TestCase("KC", "QC", "JC", "TC", "9C", false)]
        [TestCase("QC", "JC", "TC", "9C", "8C", false)]
        [TestCase("JC", "TC", "9C", "8C", "7C", false)]
        [TestCase("TC", "9C", "8C", "7C", "6C", false)]
        [TestCase("9C", "8C", "7C", "6C", "5C", false)]
        [TestCase("8C", "7C", "6C", "5C", "4C", false)]
        [TestCase("7C", "6C", "5C", "4C", "3C", false)]
        [TestCase("6C", "5C", "4C", "3C", "2C", false)]
        
        [TestCase("KD", "QD", "JD", "TD", "9D", false)]
        [TestCase("QD", "JD", "TD", "9D", "8D", false)]
        [TestCase("JD", "TD", "9D", "8D", "7D", false)]
        [TestCase("TD", "9D", "8D", "7D", "6D", false)]
        [TestCase("9D", "8D", "7D", "6D", "5D", false)]
        [TestCase("8D", "7D", "6D", "5D", "4D", false)]
        [TestCase("7D", "6D", "5D", "4D", "3D", false)]
        [TestCase("6D", "5D", "4D", "3D", "2D", false)]
        
        [TestCase("KH", "QH", "JH", "TH", "9H", false)]
        [TestCase("QH", "JH", "TH", "9H", "8H", false)]
        [TestCase("JH", "TH", "9H", "8H", "7H", false)]
        [TestCase("TH", "9H", "8H", "7H", "6H", false)]
        [TestCase("9H", "8H", "7H", "6H", "5H", false)]
        [TestCase("8H", "7H", "6H", "5H", "4H", false)]
        [TestCase("7H", "6H", "5H", "4H", "3H", false)]
        [TestCase("6H", "5H", "4H", "3H", "2H", false)]
        
        [TestCase("KS", "QS", "JS", "TS", "9S", false)]
        [TestCase("QS", "JS", "TS", "9S", "8S", false)]
        [TestCase("JS", "TS", "9S", "8S", "7S", false)]
        [TestCase("TS", "9S", "8S", "7S", "6S", false)]
        [TestCase("9S", "8S", "7S", "6S", "5S", false)]
        [TestCase("8S", "7S", "6S", "5S", "4S", false)]
        [TestCase("7S", "6S", "5S", "4S", "3S", false)]
        [TestCase("6S", "5S", "4S", "3S", "2S", false)]
        // Is not four of a kind
        [TestCase("2C", "2D", "2H", "2S", "6H", false)]
        [TestCase("3C", "3D", "3H", "3S", "6H", false)]
        [TestCase("4C", "4D", "4H", "4S", "6H", false)]
        [TestCase("5C", "5D", "5H", "5S", "6H", false)]
        [TestCase("6C", "6D", "6H", "6S", "5H", false)]
        [TestCase("7C", "7D", "7H", "7S", "6H", false)]
        [TestCase("8C", "8D", "8H", "8S", "6H", false)]
        [TestCase("9C", "9D", "9H", "9S", "6H", false)]
        [TestCase("TC", "TD", "TH", "TS", "6H", false)]
        [TestCase("JC", "JD", "JH", "JS", "6H", false)]
        [TestCase("QC", "QD", "QH", "QS", "6H", false)]
        [TestCase("KC", "KD", "KH", "KS", "6H", false)]
        // Is not full-house
        [TestCase("2C", "2D", "2H", "3S", "3H", false)]
        [TestCase("3C", "3D", "3H", "2S", "2H", false)]
        [TestCase("4C", "4D", "4H", "3S", "3H", false)]
        [TestCase("5C", "5D", "5H", "3S", "3H", false)]
        [TestCase("6C", "6D", "6H", "3S", "3H", false)]
        [TestCase("7C", "7D", "7H", "3S", "3H", false)]
        [TestCase("8C", "8D", "8H", "3S", "3H", false)]
        [TestCase("9C", "9D", "9H", "3S", "3H", false)]
        [TestCase("TC", "TD", "TH", "3S", "3H", false)]
        [TestCase("JC", "JD", "JH", "3S", "3H", false)]
        [TestCase("QC", "QD", "QH", "3S", "3H", false)]
        [TestCase("KC", "KD", "KH", "3S", "3H", false)]
        [TestCase("AC", "AD", "AH", "3S", "3H", false)]
        // Is not flush
        [TestCase("2C", "4C", "6C", "8C", "TC", false)]
        [TestCase("2D", "4D", "6D", "8D", "TD", false)]
        [TestCase("2H", "4H", "6H", "8H", "TH", false)]
        [TestCase("2S", "4S", "6S", "8S", "TS", false)]
        
        [TestCase("3C", "5C", "7C", "9C", "TC", false)]
        [TestCase("3D", "5D", "7D", "9D", "TD", false)]
        [TestCase("3H", "5H", "7H", "9H", "TH", false)]
        [TestCase("3S", "5S", "7S", "9S", "TS", false)]
        // Is not straight
        [TestCase("2C", "3H", "4D", "5S", "6C", false)]
        [TestCase("3C", "4H", "5D", "6S", "7C", false)]
        [TestCase("4C", "5H", "6D", "7S", "8C", false)]
        [TestCase("5C", "6H", "7D", "8S", "9C", false)]
        [TestCase("6C", "7H", "8D", "9S", "TC", false)]
        [TestCase("7C", "8H", "9D", "TS", "JC", false)]
        [TestCase("8C", "9H", "TD", "JS", "QC", false)]
        [TestCase("9C", "TH", "JD", "QS", "KC", false)]
        [TestCase("TC", "JH", "QD", "KS", "AC", false)]
        // Is not three of a kind
        [TestCase("2C", "2H", "2D", "3S", "4C", false)]
        [TestCase("3C", "3H", "3D", "6S", "4C", false)]
        [TestCase("4C", "4H", "4D", "3S", "5C", false)]
        [TestCase("5C", "5H", "5D", "3S", "4C", false)]
        [TestCase("6C", "6H", "6D", "3S", "4C", false)]
        [TestCase("7C", "7H", "7D", "3S", "4C", false)]
        [TestCase("8C", "8H", "8D", "3S", "4C", false)]
        [TestCase("9C", "9H", "9D", "3S", "4C", false)]
        [TestCase("TC", "TH", "TD", "3S", "4C", false)]
        [TestCase("JC", "JH", "JD", "3S", "4C", false)]
        [TestCase("QC", "QH", "QD", "3S", "4C", false)]
        [TestCase("KC", "KH", "KD", "3S", "4C", false)]
        [TestCase("AC", "AH", "AD", "3S", "4C", false)]
        // Is not two pairs
        [TestCase("2C", "2H", "AD", "3S", "3C", false)]
        [TestCase("4C", "4H", "AD", "3S", "3C", false)]
        [TestCase("5C", "5H", "AD", "3S", "3C", false)]
        [TestCase("6C", "6H", "AD", "3S", "3C", false)]
        [TestCase("7C", "7H", "AD", "3S", "3C", false)]
        [TestCase("8C", "8H", "AD", "3S", "3C", false)]
        [TestCase("9C", "9H", "AD", "3S", "3C", false)]
        [TestCase("TC", "TH", "AD", "3S", "3C", false)]
        [TestCase("JC", "JH", "AD", "3S", "3C", false)]
        [TestCase("QC", "QH", "AD", "3S", "3C", false)]
        [TestCase("KC", "KH", "AD", "3S", "3C", false)]
        
        // Is other
        [TestCase("6C", "6H", "2D", "4S", "3C", true)]
        [TestCase("6C", "4H", "2D", "8S", "6C", true)]
        [TestCase("3C", "5H", "6D", "6S", "4C", true)]
        [TestCase("3C", "4H", "6D", "6S", "4C", false)]
        public void IsOnePairTest(
            string card1String, 
            string card2String, 
            string card3String, 
            string card4String, 
            string card5String, 
            bool expectedResult)
        {
            // Arrange
            Hand hand = new Hand(
                card1String, 
                card2String, 
                card3String, 
                card4String, 
                card5String);

            // Act
            bool actualResult = hand.IsOnePair();
            
            // Assert
            Assert.That(actualResult, Is.EqualTo(expectedResult));
        }

        [Test]
        // Is high card
        [TestCase("2C", "5H", "7D", "9S", "JC", true)]
        [TestCase("3C", "5H", "7D", "9S", "JC", true)]
        // Is not royal flush
        [TestCase("AC", "KC", "QC", "JC", "TC", false)]
        [TestCase("AD", "KD", "QD", "JD", "TD", false)]
        [TestCase("AH", "KH", "QH", "JH", "TH", false)]
        [TestCase("AS", "KS", "QS", "JS", "TS", false)]
        // Is not straight flush
        [TestCase("KC", "QC", "JC", "TC", "9C", false)]
        [TestCase("QC", "JC", "TC", "9C", "8C", false)]
        [TestCase("JC", "TC", "9C", "8C", "7C", false)]
        [TestCase("TC", "9C", "8C", "7C", "6C", false)]
        [TestCase("9C", "8C", "7C", "6C", "5C", false)]
        [TestCase("8C", "7C", "6C", "5C", "4C", false)]
        [TestCase("7C", "6C", "5C", "4C", "3C", false)]
        [TestCase("6C", "5C", "4C", "3C", "2C", false)]
        
        [TestCase("KD", "QD", "JD", "TD", "9D", false)]
        [TestCase("QD", "JD", "TD", "9D", "8D", false)]
        [TestCase("JD", "TD", "9D", "8D", "7D", false)]
        [TestCase("TD", "9D", "8D", "7D", "6D", false)]
        [TestCase("9D", "8D", "7D", "6D", "5D", false)]
        [TestCase("8D", "7D", "6D", "5D", "4D", false)]
        [TestCase("7D", "6D", "5D", "4D", "3D", false)]
        [TestCase("6D", "5D", "4D", "3D", "2D", false)]
        
        [TestCase("KH", "QH", "JH", "TH", "9H", false)]
        [TestCase("QH", "JH", "TH", "9H", "8H", false)]
        [TestCase("JH", "TH", "9H", "8H", "7H", false)]
        [TestCase("TH", "9H", "8H", "7H", "6H", false)]
        [TestCase("9H", "8H", "7H", "6H", "5H", false)]
        [TestCase("8H", "7H", "6H", "5H", "4H", false)]
        [TestCase("7H", "6H", "5H", "4H", "3H", false)]
        [TestCase("6H", "5H", "4H", "3H", "2H", false)]
        
        [TestCase("KS", "QS", "JS", "TS", "9S", false)]
        [TestCase("QS", "JS", "TS", "9S", "8S", false)]
        [TestCase("JS", "TS", "9S", "8S", "7S", false)]
        [TestCase("TS", "9S", "8S", "7S", "6S", false)]
        [TestCase("9S", "8S", "7S", "6S", "5S", false)]
        [TestCase("8S", "7S", "6S", "5S", "4S", false)]
        [TestCase("7S", "6S", "5S", "4S", "3S", false)]
        [TestCase("6S", "5S", "4S", "3S", "2S", false)]
        // Is not four of a kind
        [TestCase("2C", "2D", "2H", "2S", "6H", false)]
        [TestCase("3C", "3D", "3H", "3S", "6H", false)]
        [TestCase("4C", "4D", "4H", "4S", "6H", false)]
        [TestCase("5C", "5D", "5H", "5S", "6H", false)]
        [TestCase("6C", "6D", "6H", "6S", "5H", false)]
        [TestCase("7C", "7D", "7H", "7S", "6H", false)]
        [TestCase("8C", "8D", "8H", "8S", "6H", false)]
        [TestCase("9C", "9D", "9H", "9S", "6H", false)]
        [TestCase("TC", "TD", "TH", "TS", "6H", false)]
        [TestCase("JC", "JD", "JH", "JS", "6H", false)]
        [TestCase("QC", "QD", "QH", "QS", "6H", false)]
        [TestCase("KC", "KD", "KH", "KS", "6H", false)]
        // Is not full-house
        [TestCase("2C", "2D", "2H", "3S", "3H", false)]
        [TestCase("3C", "3D", "3H", "2S", "2H", false)]
        [TestCase("4C", "4D", "4H", "3S", "3H", false)]
        [TestCase("5C", "5D", "5H", "3S", "3H", false)]
        [TestCase("6C", "6D", "6H", "3S", "3H", false)]
        [TestCase("7C", "7D", "7H", "3S", "3H", false)]
        [TestCase("8C", "8D", "8H", "3S", "3H", false)]
        [TestCase("9C", "9D", "9H", "3S", "3H", false)]
        [TestCase("TC", "TD", "TH", "3S", "3H", false)]
        [TestCase("JC", "JD", "JH", "3S", "3H", false)]
        [TestCase("QC", "QD", "QH", "3S", "3H", false)]
        [TestCase("KC", "KD", "KH", "3S", "3H", false)]
        [TestCase("AC", "AD", "AH", "3S", "3H", false)]
        // Is not flush
        [TestCase("2C", "4C", "6C", "8C", "TC", false)]
        [TestCase("2D", "4D", "6D", "8D", "TD", false)]
        [TestCase("2H", "4H", "6H", "8H", "TH", false)]
        [TestCase("2S", "4S", "6S", "8S", "TS", false)]
        
        [TestCase("3C", "5C", "7C", "9C", "TC", false)]
        [TestCase("3D", "5D", "7D", "9D", "TD", false)]
        [TestCase("3H", "5H", "7H", "9H", "TH", false)]
        [TestCase("3S", "5S", "7S", "9S", "TS", false)]
        // Is not straight
        [TestCase("2C", "3H", "4D", "5S", "6C", false)]
        [TestCase("3C", "4H", "5D", "6S", "7C", false)]
        [TestCase("4C", "5H", "6D", "7S", "8C", false)]
        [TestCase("5C", "6H", "7D", "8S", "9C", false)]
        [TestCase("6C", "7H", "8D", "9S", "TC", false)]
        [TestCase("7C", "8H", "9D", "TS", "JC", false)]
        [TestCase("8C", "9H", "TD", "JS", "QC", false)]
        [TestCase("9C", "TH", "JD", "QS", "KC", false)]
        [TestCase("TC", "JH", "QD", "KS", "AC", false)]
        // Is not three of a kind
        [TestCase("2C", "2H", "2D", "3S", "4C", false)]
        [TestCase("3C", "3H", "3D", "6S", "4C", false)]
        [TestCase("4C", "4H", "4D", "3S", "5C", false)]
        [TestCase("5C", "5H", "5D", "3S", "4C", false)]
        [TestCase("6C", "6H", "6D", "3S", "4C", false)]
        [TestCase("7C", "7H", "7D", "3S", "4C", false)]
        [TestCase("8C", "8H", "8D", "3S", "4C", false)]
        [TestCase("9C", "9H", "9D", "3S", "4C", false)]
        [TestCase("TC", "TH", "TD", "3S", "4C", false)]
        [TestCase("JC", "JH", "JD", "3S", "4C", false)]
        [TestCase("QC", "QH", "QD", "3S", "4C", false)]
        [TestCase("KC", "KH", "KD", "3S", "4C", false)]
        [TestCase("AC", "AH", "AD", "3S", "4C", false)]
        // Is not two pairs
        [TestCase("2C", "2H", "AD", "3S", "3C", false)]
        [TestCase("4C", "4H", "AD", "3S", "3C", false)]
        [TestCase("5C", "5H", "AD", "3S", "3C", false)]
        [TestCase("6C", "6H", "AD", "3S", "3C", false)]
        [TestCase("7C", "7H", "AD", "3S", "3C", false)]
        [TestCase("8C", "8H", "AD", "3S", "3C", false)]
        [TestCase("9C", "9H", "AD", "3S", "3C", false)]
        [TestCase("TC", "TH", "AD", "3S", "3C", false)]
        [TestCase("JC", "JH", "AD", "3S", "3C", false)]
        [TestCase("QC", "QH", "AD", "3S", "3C", false)]
        [TestCase("KC", "KH", "AD", "3S", "3C", false)]
        // Is not one pair
        [TestCase("2C", "2H", "5D", "4S", "7C", false)]
        [TestCase("3C", "3H", "5D", "4S", "7C", false)]
        [TestCase("4C", "4H", "5D", "QS", "7C", false)]
        [TestCase("5C", "5H", "QD", "4S", "7C", false)]
        [TestCase("6C", "6H", "5D", "4S", "7C", false)]
        [TestCase("7C", "7H", "5D", "4S", "KC", false)]
        [TestCase("8C", "8H", "5D", "4S", "7C", false)]
        [TestCase("9C", "9H", "5D", "4S", "7C", false)]
        [TestCase("TC", "TH", "5D", "4S", "7C", false)]
        [TestCase("JC", "JH", "5D", "4S", "7C", false)]
        [TestCase("QC", "QH", "5D", "4S", "7C", false)]
        [TestCase("KC", "KH", "5D", "4S", "7C", false)]
        [TestCase("AC", "AH", "5D", "4S", "7C", false)]
        public void IsHighCardTest(
            string card1String, 
            string card2String, 
            string card3String, 
            string card4String, 
            string card5String, 
            bool expectedResult)
        {
            // Arrange
            Hand hand = new Hand(
                card1String, 
                card2String, 
                card3String, 
                card4String, 
                card5String);

            // Act
            bool actualResult = hand.IsHighCard();
            
            // Assert
            Assert.That(actualResult, Is.EqualTo(expectedResult));
        }
    }
}