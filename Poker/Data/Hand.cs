using System;

namespace Poker.Data
{
    public class Hand
    {
        public Card[] Cards;
        
        public Hand()
        {
            Cards = new Card[]
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
            Cards = new Card[]
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
                foreach(var card in hand.Cards)
                {
                    if (!HandHasCard(card))
                    {
                        result = false;
                        break;
                    }

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
            var result = false;
            foreach(var card in Cards)
            {
                if (card.Equals(checkCard))
                {
                    result = true;
                    break;
                }
            }
            return result;
        }
    }
}
