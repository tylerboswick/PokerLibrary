using System;

namespace Poker.Data
{
    public class Card
    {
        public Suit CardSuit { get; set; }
        public Value CardValue { get; set; }

        public Card()
        {
            CardSuit = Suit.Empty;
            CardValue = Value.Empty;
        }
        public Card(Suit suit, Value value)
        {
            CardSuit = suit;
            CardValue = value;
        }

        public override bool Equals(object c)
        {
            bool result;
            try
            {
                result = CardValue == ((Card)c).CardValue && CardSuit == ((Card)c).CardSuit;
            }
            catch(Exception)
            {
                result = false;
            }
            return result;
        }
    }
}
