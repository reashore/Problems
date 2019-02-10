namespace Problem54
{
    public class Hand
    {
        public Hand(Card card1, Card card2, Card card3, Card card4, Card card5)
        {
            Card1 = card1;
            Card2 = card2;
            Card3 = card3;
            Card4 = card4;
            Card5 = card5;
        }

        public Card Card1 { get; set; }
        public Card Card2 { get; set; }
        public Card Card3 { get; set; }
        public Card Card4 { get; set; }
        public Card Card5 { get; set; }
    }
}