using System;
using Poker.Enums;

namespace Poker.Data
{
    public class Card
    {
        public Suit CardSuit { get; set; }
        public CardValue CardValue { get; set; }

        public Card()
        {
            CardSuit = Suit.Empty;
            CardValue = CardValue.Empty;
        }
        public Card(Suit suit, CardValue cardValue)
        {
            CardSuit = suit;
            CardValue = cardValue;
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
