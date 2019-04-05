using Poker.Data;

namespace Poker.Helpers
{
    public static class CardCompareHelpers
    {
        public static Card GetHighCard(Card firstCard, Card secondCard)
        {
            return firstCard.CardValue > secondCard.CardValue ? firstCard : secondCard;          
        }
    }
}