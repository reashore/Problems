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
        
        // todo: use constructor?
        public static Hand GetHand(string card0String, string card1String, string card2String, string card3String, string card4String)
        {
            Card card0 = new Card(card0String);
            Card card1 = new Card(card1String);
            Card card2 = new Card(card2String);
            Card card3 = new Card(card3String);
            Card card4 = new Card(card4String);

            Hand hand = new Hand(card0, card1, card2, card3, card4);
            
            return hand;
        }
    }
}