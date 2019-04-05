using System;
using System.Linq;
using Poker.Helpers;

namespace Poker.Data
{
    public class Hand
    {
        private const int Pair = 2;
        private const int ThreeOfAKind = 3;
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

        public Value IsPair()
        {
            return GetValuableDuplicateCardsByValue(Pair);
        }

        public Value IsThreeOfAKind()
        {
            return GetValuableDuplicateCardsByValue(ThreeOfAKind);
        }

        public Value GetValuableDuplicateCardsByValue(int numRequired)
        {
            var result = Value.Empty;
            try
            {
                //group common value cards and only take groups with the desired count (2 for pair, 3 for 3-of-kind)
                var duplicates = Cards.GroupBy(card => card.CardValue).Where(cards => cards.Count() == numRequired).ToList();

                if (duplicates.Any())
                {
                    //take the highest duplicate group (for pairs only)
                    if (numRequired == Pair)
                    {
                        duplicates = duplicates.OrderByDescending(x => x.Key).ToList();
                    }

                    result = duplicates.First().Key;
                }
            }
            catch (Exception)
            {
                result = Value.Empty;
            }
            return result;
        }

        public Value IsFlush()
        {
            Value result;
            try
            {
                var suit = Cards.First().CardSuit;
                if (Cards.Any(card => card.CardSuit != suit))
                {
                    return Value.Empty;
                }
                else
                {
                    return GetHighCardFromHand().CardValue;
                }
            }
            catch (Exception)
            {
                result = Value.Empty;
            }

            return result;
        }
        public Card GetHighCardFromHand()
        {
            var highest = new Card();
            return Cards.Aggregate(highest, CardCompareHelpers.GetHighCard);
        }
    }
}
