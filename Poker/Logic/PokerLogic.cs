using System.Linq;
using Poker.Data;
using Poker.Interfaces;

namespace Poker.Logic
{
    public class PokerLogic : IPokerLogic
    {
        public Card GetHighCard(Card firstCard, Card secondCard)
        {
            return firstCard.CardValue > secondCard.CardValue ? firstCard : secondCard;          
        }

        public Card GetHighCardFromHand(Hand hand)
        {
            var highest = new Card();
            return hand.Cards.Aggregate(highest, GetHighCard);
        }
        
        public Hand GetHighHand(Hand firstHand, Hand secondHand)
        {
            var firstHandHigh = GetHighCardFromHand(firstHand);
            var secondHandHigh = GetHighCardFromHand(secondHand);
            var highCard = GetHighCard(firstHandHigh, secondHandHigh);

            return highCard.Equals(firstHandHigh) ? firstHand : secondHand;
        }
    }
}
