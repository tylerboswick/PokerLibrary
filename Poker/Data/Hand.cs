using System;
using System.Linq;

namespace Poker.Data
{
    public class Hand
    {
        public Card[] Cards;
        
        public Hand()
        {
            Cards = new[]
            {
                new Card(),
                new Card(),
                new Card(),
                new Card(),
                new Card()
            };
        }
        public Hand(Card one, Card two, Card three, Card four, Card five)
        {
            Cards = new[]
            {
                one?? new Card(),
                two?? new Card(),
                three?? new Card(),
                four?? new Card(),
                five?? new Card()
            };
        }

        public override bool Equals(object obj)
        {
            var result = true;
            try
            {
                var hand = (Hand)obj;
                if (hand.Cards.Any(card => !HandHasCard(card)))
                {
                    result = false;
                }
            }
            catch(Exception)
            {
                result = false;
            }
            return result;
        }

        public bool HandHasCard(Card checkCard)
        {
            return Cards.Contains(checkCard);
        }

        public bool IsFlush()
        {
            var result = true;
            try
            {
                var suit = Cards.First().CardSuit;
                if (Cards.Any(card => card.CardSuit != suit))
                {
                    return false;
                }
            }
            catch (Exception)
            {
                result = false;
            }

            return result;
        }
    }
}
