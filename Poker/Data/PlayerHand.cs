using Poker.Enums;

namespace Poker.Data
{
    public class PlayerHand
    {
        public string Name { get; }
        public Hand Hand { get; }

        public CardValue HighCard { get; set; }
        public HandValue HandValue { get; set; }
        public PlayerHand(string name, Hand hand)
        {
            Name = name;
            Hand = hand;
            EvaluatePlayerHand();
        }

        public void EvaluatePlayerHand()
        {
            //put in order for kickers
            Hand.OrderHand();

            //check if flush has value -> therefore flush
            var flushValue = Hand.HighValueFlush();
            if (flushValue != CardValue.Empty)
            {
                HandValue = HandValue.Flush;
                HighCard = flushValue;
                return;
            }

            //check if 3 of kind has value -> therefore 3 of kind
            var threeOfAKindValue = Hand.HighValueThreeOfAKind();
            if (threeOfAKindValue != CardValue.Empty)
            {
                HandValue = HandValue.ThreeOfKind;
                HighCard = threeOfAKindValue;
                return;
            }

            //check if pair has value -> therefore pair
            var pairValue = Hand.HighValuePair();
            if (pairValue != CardValue.Empty)
            {
                HandValue = HandValue.OnePair;
                HighCard = pairValue;
                return;
            }

            //otherwise, set high card
            var highCardValue = Hand.GetHighCardFromHand();
            HandValue = HandValue.HighCard;
            HighCard = highCardValue.CardValue;
        }
    }
}
