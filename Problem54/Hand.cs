using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Problem54
{
    public class Hand
    {
        public Hand(string card0String, string card1String, string card2String, string card3String, string card4String)
        {
            Card1 = new Card(card0String);
            Card2 = new Card(card1String);
            Card3 = new Card(card2String);
            Card4 = new Card(card3String);
            Card5 = new Card(card4String);

            AddCardsToList();
        }

        private List<Card> _cardList;

        private Card Card1 { get; }
        private Card Card2 { get; }
        private Card Card3 { get; }
        private Card Card4 { get; }
        private Card Card5 { get; }

        private void AddCardsToList()
        {
            _cardList = new List<Card>
            {
                Card1,
                Card2,
                Card3,
                Card4,
                Card5
            };
        }

        public override string ToString()
        {
            StringBuilder handStringBuilder = new StringBuilder();
            
            foreach (Card card in _cardList)
            {
                string cardString = card.ToString();
                handStringBuilder.Append($"{cardString} ");
            }

            return handStringBuilder.ToString().TrimEnd();
        }

        // todo add high card
        public PokerHandType GetPokerHandType()
        {
            PokerHandType pokerHandType = PokerHandType.HighCard;

            if (IsRoyalFlush())
            {
                pokerHandType = PokerHandType.RoyalFlush;
            }
            else if (IsStraightFlush())
            {
                pokerHandType = PokerHandType.StraightFlush;
            }
            else if (IsFourOfKind())
            {
                pokerHandType = PokerHandType.FourOfKind;
            }
            else if (IsFullHouse())
            {
                pokerHandType = PokerHandType.FullHouse;
            }
            else if (IsFlush())
            {
                pokerHandType = PokerHandType.Flush;
            }
            else if (IsStraight())
            {
                pokerHandType = PokerHandType.Straight;
            }
            else if (IsThreeOfKind())
            {
                pokerHandType = PokerHandType.ThreeOfKind;
            }
            else if (IsTwoPairs())
            {
                pokerHandType = PokerHandType.TwoPair;
            }
            else if (IsOnePair())
            {
                pokerHandType = PokerHandType.OnePair;
            }
            else if (IsHighCard())
            {
                pokerHandType = PokerHandType.HighCard;
            }

            return pokerHandType;
        }
        
        //----------------------------

        public bool IsRoyalFlush()
        {
            if (!IsHandSameSuit())
            {
                return false;
            }

            bool isRoyalFlush = ContainsCardOfRank(Rank.Ace) &&
                                ContainsCardOfRank(Rank.King) &&
                                ContainsCardOfRank(Rank.Queen) &&
                                ContainsCardOfRank(Rank.Jack) &&
                                ContainsCardOfRank(Rank.C10);

            return isRoyalFlush;
        }

        public bool IsStraightFlush()
        {
            if (IsHigherValueHand(PokerHandType.StraightFlush))
            {
                return false;
            }
            
            if (!IsHandSameSuit())
            {
                return false;
            }

            Rank rank5 = GetHighestRank();
            Rank rank4 = GetNextLowerRank(rank5);
            Rank rank3 = GetNextLowerRank(rank4);
            Rank rank2 = GetNextLowerRank(rank3);
            Rank rank1 = GetNextLowerRank(rank2);
            
            bool isStraightFlush = ContainsCardOfRank(rank5) &&
                                   ContainsCardOfRank(rank4) &&
                                   ContainsCardOfRank(rank3) &&
                                   ContainsCardOfRank(rank2) &&
                                   ContainsCardOfRank(rank1);
            
            
            return isStraightFlush;
        }

        public bool IsFourOfKind()
        {
            if (IsHigherValueHand(PokerHandType.FourOfKind))
            {
                return false;
            }

            bool isFourOfKind = false;
            
            foreach (Rank rank in GetAllRanks())
            {
                isFourOfKind = ContainsCardOfRankAndSuit(rank, Suit.Clubs) &&
                               ContainsCardOfRankAndSuit(rank, Suit.Diamonds) &&
                               ContainsCardOfRankAndSuit(rank, Suit.Hearts) &&
                               ContainsCardOfRankAndSuit(rank, Suit.Spades);

                if (isFourOfKind)
                {
                    break;
                }
            }
            
            return isFourOfKind;
        }

        public bool IsFullHouse()
        {
            if (IsHigherValueHand(PokerHandType.FullHouse))
            {
                return false;
            }

            bool threeOfKind = false;
            bool onePair = false;
            Rank threeOfKindRank = Rank.C2;

            foreach (Rank rank in GetAllRanks())
            {
                if (NumberCardsOfRank(rank) == 3)
                {
                    threeOfKind = true;
                    threeOfKindRank = rank;
                    break;
                }
            }

            if (!threeOfKind)
            {
                return false;
            }
            
            foreach (Rank rank in GetAllRanks())
            {
                if (rank != threeOfKindRank && NumberCardsOfRank(rank) == 2 )
                {
                    onePair = true;
                    break;
                }
            }

            return onePair;
        }

        public bool IsFlush()
        {
            if (IsHigherValueHand(PokerHandType.Flush))
            {
                return false;
            }

            bool isFlush = IsHandSameSuit();
            
            return isFlush;
        }

        public bool IsStraight()
        {
            if (IsHigherValueHand(PokerHandType.Straight))
            {
                return false;
            }
            
            Rank rank5 = GetHighestRank();
            Rank rank4 = GetNextLowerRank(rank5);
            Rank rank3 = GetNextLowerRank(rank4);
            Rank rank2 = GetNextLowerRank(rank3);
            Rank rank1 = GetNextLowerRank(rank2);
            
            bool isStraight = ContainsCardOfRank(rank5) &&
                              ContainsCardOfRank(rank4) &&
                              ContainsCardOfRank(rank3) &&
                              ContainsCardOfRank(rank2) &&
                              ContainsCardOfRank(rank1);
            
            return isStraight;
        }

        public bool IsThreeOfKind()
        {
            if (IsHigherValueHand(PokerHandType.ThreeOfKind))
            {
                return false;
            }
            
            bool threeOfKind = false;

            foreach (Rank rank in GetAllRanks())
            {
                if (NumberCardsOfRank(rank) == 3)
                {
                    threeOfKind = true;
                    break;
                }
            }

            return threeOfKind;
        }

        public bool IsTwoPairs()
        {
            if (IsHigherValueHand(PokerHandType.TwoPair))
            {
                return false;
            }
            
            bool firstPair = false;
            bool secondPair = false;
            Rank firstPairRank = Rank.C2;

            foreach (Rank rank in GetAllRanks())
            {
                if (NumberCardsOfRank(rank) == 2)
                {
                    firstPair = true;
                    firstPairRank = rank;
                    break;
                }
            }

            if (!firstPair)
            {
                return false;
            }
            
            foreach (Rank rank in GetAllRanks())
            {
                if (rank != firstPairRank && NumberCardsOfRank(rank) == 2 )
                {
                    secondPair = true;
                    break;
                }
            }

            return secondPair;
        }

        public bool IsOnePair()
        {
            if (IsHigherValueHand(PokerHandType.OnePair))
            {
                return false;
            }
            
            bool onePair = false;

            foreach (Rank rank in GetAllRanks())
            {
                if (NumberCardsOfRank(rank) == 2)
                {
                    onePair = true;
                    break;
                }
            }

            return onePair;
        }

        public bool IsHighCard()
        {
            if (IsHigherValueHand(PokerHandType.HighCard))
            {
                return false;
            }
            
            return true;
        }

        //----------------------------

        private static IEnumerable<Rank> GetAllRanks()
        {
            Rank[] ranks = (Rank[]) Enum.GetValues(typeof(Rank));
            return ranks;
        }
        
        private bool IsHandSameSuit()
        {
            Type suitType = typeof(Suit);
            Suit[] suits = (Suit[]) Enum.GetValues(suitType);
            bool sameSuit = false;

            foreach (Suit suit in suits)
            {
                sameSuit = Card1.Suit == suit &&
                           Card2.Suit == suit &&
                           Card3.Suit == suit &&
                           Card4.Suit == suit &&
                           Card5.Suit == suit;

                if (sameSuit)
                {
                    break;
                }
            }

            return sameSuit;
        }

        private bool ContainsCardOfRank(Rank rank)
        {
            bool containsCardOfRank = false;

            foreach (Card card in _cardList)
            {
                if (card.Rank == rank)
                {
                    containsCardOfRank = true;
                    break;
                }
            }

            return containsCardOfRank;
        }

        public int NumberCardsOfRank(Rank rank)
        {
            int numberCardsOfRank = 0;

            foreach (Card card in _cardList)
            {
                if (card.Rank == rank)
                {
                    numberCardsOfRank++;
                }
            }

            return numberCardsOfRank;
        }

        private bool ContainsCardOfRankAndSuit(Rank rank, Suit suit)
        {
            bool contiansCardOfRankAndSuit = false;

            foreach (Card card in _cardList)
            {
                if (card.Rank == rank && card.Suit == suit){
                    contiansCardOfRankAndSuit = true;
                    break;
                }
            }

            return contiansCardOfRankAndSuit;
        }

        private Rank GetHighestRank()
        {
            Rank highestRank = Rank.C2;

            foreach (Card card in _cardList)
            {
                if ((int) card.Rank > (int) highestRank)
                {
                    highestRank = card.Rank;
                }
            }

            return highestRank;
        }

        private static Rank GetNextLowerRank(Rank rank)
        {
            int rankValue = (int) rank;
            int nextLowestRankValue = rankValue - 1;
            Rank nextLowestRank = (Rank) nextLowestRankValue;
            return nextLowestRank;
        }
 
        private bool IsHigherValueHand(PokerHandType pokerHandType)
        {
            if (IsRoyalFlush())
            {
                return true;
            }

            if (pokerHandType == PokerHandType.StraightFlush)
            {
                return false;
            }
            
            ///////////////////////////

            if (IsStraightFlush())
            {
                return true;
            }

            if (pokerHandType == PokerHandType.FourOfKind)
            {
                return false;
            }
            
            ///////////////////////////

            if (IsFourOfKind())
            {
                return true;
            }

            if (pokerHandType == PokerHandType.FullHouse)
            {
                return false;
            }
            
            ///////////////////////////

            if (IsFullHouse())
            {
                return true;
            }

            if (pokerHandType == PokerHandType.Flush)
            {
                return false;
            }
            
            ///////////////////////////

            if (IsFlush())
            {
                return true;
            }

            if (pokerHandType == PokerHandType.Straight)
            {
                return false;
            }
            
            ///////////////////////////

            if (IsStraight())
            {
                return true;
            }

            if (pokerHandType == PokerHandType.ThreeOfKind)
            {
                return false;
            }
            
            ///////////////////////////

            if (IsThreeOfKind())
            {
                return true;
            }

            if (pokerHandType == PokerHandType.TwoPair)
            {
                return false;
            }
            
            ///////////////////////////

            if (IsTwoPairs())
            {
                return true;
            }

            if (pokerHandType == PokerHandType.OnePair)
            {
                return false;
            }
            
            ///////////////////////////

            if (IsOnePair())
            {
                return true;
            }

            return false;
        }
        
        public List<Rank> GetSortedCardRanks()
        {
            List<Rank> sortedCardRankList = _cardList.Select(card => card.Rank)
                                                    .OrderByDescending(rank => (int)rank).ToList();

            return sortedCardRankList;
        }
    }
}