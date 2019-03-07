using NUnit.Framework;

namespace Problem54.Test
{
    [TestFixture]
    public class PokerDealTests
    {
        [Test]
        [TestCase("AC AD 9C 7C 5C AH AS 9H 7D 4D", true)]
        [TestCase("AC AD 9C 7C 5C AH AS 9H 6D 4D", true)]
        [TestCase("AC AD 9C 7C 5C AH AS 8H 7D 4D", true)]
        [TestCase("9C 7C 5C AC AD 9H 7D 4D AH AS", true)]
        [TestCase("9C 7C 5C AC AD 9H 6D 4D AH AS", true)]
        [TestCase("9C 7C 5C AC AD 8H 7D 4D AH AS", true)]
        public void Hand1WithOnePairWinsTie(
            string dealString, 
            bool expectedHand1WinsTie)
        {
            string[] dealStringArray = dealString.Split(' ');
            string hand1Card1String = dealStringArray[0];
            string hand1Card2String = dealStringArray[1];
            string hand1Card3String = dealStringArray[2];
            string hand1Card4String = dealStringArray[3];
            string hand1Card5String = dealStringArray[4];
            
            string hand2Card1String = dealStringArray[5];
            string hand2Card2String = dealStringArray[6];
            string hand2Card3String = dealStringArray[7];
            string hand2Card4String = dealStringArray[8];
            string hand2Card5String = dealStringArray[9];
            
            // Arrange
            Hand hand1 = new Hand(
                hand1Card1String, 
                hand1Card2String, 
                hand1Card3String, 
                hand1Card4String, 
                hand1Card5String);
            Hand hand2 = new Hand(
                hand2Card1String, 
                hand2Card2String, 
                hand2Card3String, 
                hand2Card4String, 
                hand2Card5String);
            Deal deal = new Deal(hand1, hand2);

            // Act
            bool actualHand1WinsTie = deal.Hand1WithOnePairWinsTie();
            
            // Assert
            Assert.That(actualHand1WinsTie, Is.EqualTo(expectedHand1WinsTie));
        }
        
        [Test]
        [TestCase("AC KC TC 8C 7C AD KD TD 8D 6D", true)]
        [TestCase("AC KC TC 9C 7C AD KD TD 8D 6D", true)]
        [TestCase("AC KC JC 9C 7C AD KD TD 8D 6D", true)]
        [TestCase("AC KC JC 9C 7C AD QD TD 8D 6D", true)]
        public void Hand1WithHighCardWinsTieTest(
            string dealString, 
            bool expectedHand1WinsTie)
        {
            string[] dealStringArray = dealString.Split(' ');
            string hand1Card1String = dealStringArray[0];
            string hand1Card2String = dealStringArray[1];
            string hand1Card3String = dealStringArray[2];
            string hand1Card4String = dealStringArray[3];
            string hand1Card5String = dealStringArray[4];
            
            string hand2Card1String = dealStringArray[5];
            string hand2Card2String = dealStringArray[6];
            string hand2Card3String = dealStringArray[7];
            string hand2Card4String = dealStringArray[8];
            string hand2Card5String = dealStringArray[9];
            
            // Arrange
            Hand hand1 = new Hand(
                hand1Card1String, 
                hand1Card2String, 
                hand1Card3String, 
                hand1Card4String, 
                hand1Card5String);
            Hand hand2 = new Hand(
                hand2Card1String, 
                hand2Card2String, 
                hand2Card3String, 
                hand2Card4String, 
                hand2Card5String);
            Deal deal = new Deal(hand1, hand2);

            // Act
            bool actualHand1WinsTie = deal.Hand1WithHighCardWinsTie();
            
            // Assert
            Assert.That(actualHand1WinsTie, Is.EqualTo(expectedHand1WinsTie));
        }
    }
}