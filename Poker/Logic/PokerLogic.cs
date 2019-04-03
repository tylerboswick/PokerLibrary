using Poker.Data;
using Poker.Interfaces;

namespace Poker.Logic
{
    public class PokerLogic : IPokerLogic
    {
        public PokerLogic()
        {

        }
        public Card GetHighCard(Card firstCard, Card secondCard)
        {
            return firstCard.CardValue > secondCard.CardValue ? firstCard : secondCard;          
        }

        public Card GetHighCardFromHand(Hand hand)
        {
            var highest = new Card();
            foreach(var card in hand.Cards)
            {
                highest = GetHighCard(highest, card);
            }
            return highest;
        }
        
        public Hand GetHighHand(Hand firstHand, Hand secondHand)
        {
            var firstHandHigh = GetHighCardFromHand(firstHand);
            var secondHandHigh = GetHighCardFromHand(secondHand);
            var highCard = GetHighCard(firstHandHigh, secondHandHigh);

            if (highCard.Equals(firstHandHigh))
            {
                return firstHand;
            }
            else
            {
                return secondHand;
            }
        }
    }
}
