using Poker.Data;

namespace Poker.Interfaces
{
    public interface IPokerLogic
    {
        Card GetHighCard(Card firstCard, Card secondCard);
        Card GetHighCardFromHand(Hand hand);
        Hand GetHighHand(Hand firstHand, Hand secondHand);
    }
}
