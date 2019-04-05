using System;
using System.Linq;
using Poker.Enums;
using Poker.Helpers;

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

        public Card(string cardInfo)
        {
            //0-9 and royals input length two (ie. 8H, AD)
            if (cardInfo.Length == 2)
            {
                CardSuit = EnumHelpers.GetSuitFromChar(cardInfo.Last());
                CardValue = EnumHelpers.GetValueFromChar(cardInfo.First());
            }
            //Else, input is 10 (ie. 10S)
            else
            {
                CardSuit = EnumHelpers.GetSuitFromChar(cardInfo.Last());
                CardValue = CardValue.Ten;
            }
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
