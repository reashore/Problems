using static System.Console;

namespace Problem54
{
    public class Card
    {
        public Card(string cardString)
        {
            char rankChar = cardString[0];
            char suitChar = cardString[1];

            SetRank(rankChar);
            SetSuit(suitChar);
        }

        public Rank Rank { get; private set; }
        
        public Suit Suit { get; private set; }

        public override string ToString()
        {
            char rankChar = GetRankChar();
            char suitChar = GetSuitChar();
            
            return $"{rankChar}{suitChar}";
        }

        private void SetRank(char rankChar)
        {
            switch (rankChar)
            {
                case '2' :
                    Rank = Rank.C2;
                    break;
                    
                case '3':
                    Rank = Rank.C3;
                    break;
                    
                case '4':
                    Rank = Rank.C4;
                    break;
                    
                case '5':
                    Rank = Rank.C5;
                    break;
                    
                case '6':
                    Rank = Rank.C6;
                    break;
                    
                case '7':
                    Rank = Rank.C7;
                    break;
                    
                case '8':
                    Rank = Rank.C8;
                    break;
                    
                case '9':
                    Rank = Rank.C9;
                    break;
                    
                case 'T':
                    Rank = Rank.C10;
                    break;
                    
                case 'J':
                    Rank = Rank.Jack;
                    break;
                    
                case 'Q':
                    Rank = Rank.Queen;
                    break;
                    
                case 'K':
                    Rank = Rank.King;
                    break;
                    
                case 'A':
                    Rank = Rank.Ace;
                    break;
                
                default:
                    WriteLine($"Invalid card rank, {rankChar}");
                    break;
            }
        }

        private void SetSuit(char suitChar)
        {
            switch (suitChar)
            {
                case 'C' :
                    Suit = Suit.Clubs;
                    break;
                    
                case 'D':
                    Suit = Suit.Diamonds;
                    break;
                    
                case 'H':
                    Suit = Suit.Hearts;
                    break;
                    
                case 'S':
                    Suit = Suit.Spades;
                    break;
                
                default:
                    WriteLine($"Invalid card suit, {suitChar}");
                    break;
            }
        }

        private char GetRankChar()
        {
            char rankChar = ' ';
            
            switch (Rank)
            {
                case Rank.C2:
                    rankChar = '2';
                    break;
                    
                case Rank.C3:
                    rankChar = '3';
                    break;
                    
                case Rank.C4:
                    rankChar = '4';
                    break;
                    
                case Rank.C5:
                    rankChar = '5';
                    break;
                    
                case Rank.C6:
                    rankChar = '6';
                    break;
                    
                case Rank.C7:
                    rankChar = '7';
                    break;
                    
                case Rank.C8:
                    rankChar = '8';
                    break;
                    
                case Rank.C9:
                    rankChar = '9';
                    break;
                    
                case Rank.C10:
                    rankChar = 'T';
                    break;
                    
                case Rank.Jack:
                    rankChar = 'J';
                    break;
                    
                case Rank.Queen:
                    rankChar = 'Q';
                    break;
                    
                case Rank.King:
                    rankChar = 'K';
                    break;
                    
                case Rank.Ace:
                    rankChar = 'A';
                    break;
                
                default:
                    WriteLine($"Invalid card suit, {Rank.ToString()}");
                    break;
            }

            return rankChar;
        }

        private char GetSuitChar()
        {
            char suitChar = ' ';
            
            // ReSharper disable once SwitchStatementMissingSomeCases
            switch (Suit)
            {
                case Suit.Clubs:
                    suitChar = 'C';
                    break;
                    
                case Suit.Diamonds:
                    suitChar = 'D';
                    break;
                    
                case Suit.Hearts:
                    suitChar = 'H';
                    break;
                    
                case Suit.Spades:
                    suitChar = 'S';
                    break;
            }

            return suitChar;
        }
        
    }
}