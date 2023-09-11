namespace Opgave4._5
{
    internal class CardGame
    {
        private List<Card> cards = new List<Card>();

        public void AddCard(Suit suit, CardNumber number)
        {
            cards.Add(new Card(suit, number));
        }
        public List<Card> filterCardGame(FilterCardDelegate filter)
        {
            List<Card> result = new List<Card>();
            foreach (Card card in cards)
            {
                if (filter(card))
                {
                    result.Add(card);
                }
            }
            return result;
        }
    }
}
