using NUnit.Framework;

namespace Problem54.Test
{
    [TestFixture]
    public class PokerTests
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

        [Test]
        [TestCase("AC", "KC", "QC", "JC", "TC", true)]
        [TestCase("AD", "KD", "QD", "JD", "TD", true)]
        [TestCase("AH", "KH", "QH", "JH", "TH", true)]
        [TestCase("AS", "KS", "QS", "JS", "TS", true)]
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
        [TestCase("6D", "5D", "4D", "3D", "2D", true)]
        [TestCase("TH", "9H", "8H", "7H", "6H", true)]
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
        [TestCase("5C", "5D", "5H", "5S", "6H", true)]
        [TestCase("KC", "KD", "KH", "KS", "6H", true)]
        [TestCase("5C", "KD", "5D", "5H", "5S", true)]
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
        [TestCase("5C", "5D", "5H", "3S", "3H", true)]
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
        [TestCase("2C", "4C", "6C", "8C", "TC", true)]
        [TestCase("2D", "4D", "6D", "8D", "TD", true)]
        [TestCase("2H", "4H", "6H", "8H", "TH", true)]
        [TestCase("2S", "4S", "6S", "8S", "TS", true)]
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
        [TestCase("6C", "5H", "4D", "3S", "2C", true)]
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
        [TestCase("6C", "6H", "6D", "3S", "2C", true)]
        [TestCase("5C", "6H", "6D", "6S", "2C", true)]
        [TestCase("8C", "6H", "5D", "5S", "5C", true)]
        [TestCase("5C", "6H", "7D", "5S", "5C", true)]
        // todo add failing tests
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
        [TestCase("6C", "6H", "4D", "4S", "2C", true)]
        [TestCase("6C", "6H", "2D", "4S", "4C", true)]
        [TestCase("6C", "4H", "2D", "4S", "6C", true)]
        [TestCase("3C", "4H", "6D", "6S", "4C", true)]
        // todo add failing tests
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
        [TestCase("6C", "6H", "5D", "4S", "2C", true)]
        [TestCase("6C", "6H", "2D", "4S", "3C", true)]
        [TestCase("6C", "4H", "2D", "8S", "6C", true)]
        [TestCase("3C", "5H", "6D", "6S", "4C", true)]
        
        [TestCase("3C", "4H", "6D", "6S", "4C", false)]
        // todo add failing tests
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
        [TestCase("6C", "3H", "4D", "7S", "2C", true)]
        // todo add failing tests
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
        
        [Test]
        [Ignore("Not finished")]
        public void Problem54Test()
        {
            // Arrange
            const int expectedResult = 376;
            
            // Act
            int answer = Program.Solve();

            // Assert
            Assert.That(answer, Is.EqualTo(expectedResult));
        }

    }
}