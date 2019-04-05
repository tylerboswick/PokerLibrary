using Poker.Enums;

namespace Poker.Data
{
    public class PlayerHand
    {
        public string Name { get; }
        public Hand Cards { get; }

        public CardValue HighCard { get; set; }
        public HandValue HandValue { get; set; }
        public PlayerHand(string name, Hand cards)
        {
            Name = name;
            Cards = cards;
            EvaluatePlayerHand();
        }

        public void EvaluatePlayerHand()
        {
            //put in order for kickers
            Cards.OrderHand();

            //check if flush has value -> therefore flush
            var flushValue = Cards.IsFlush();
            if (flushValue != CardValue.Empty)
            {
                HandValue = HandValue.Flush;
                HighCard = flushValue;
                return;
            }

            //check if 3 of kind has value -> therefore 3 of kind
            var threeOfAKindValue = Cards.IsThreeOfAKind();
            if (threeOfAKindValue != CardValue.Empty)
            {
                HandValue = HandValue.ThreeOfKind;
                HighCard = threeOfAKindValue;
                return;
            }

            //check if pair has value -> therefore pair
            var pairValue = Cards.IsPair();
            if (pairValue != CardValue.Empty)
            {
                HandValue = HandValue.OnePair;
                HighCard = pairValue;
                return;
            }

            //otherwise, set high card
            var highCardValue = Cards.GetHighCardFromHand();
            HandValue = HandValue.HighCard;
            HighCard = highCardValue.CardValue;
        }
    }
}
