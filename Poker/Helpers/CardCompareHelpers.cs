using Poker.Data;

namespace Poker.Helpers
{
    public static class CardCompareHelpers
    {
        private const int CardsInAHand = 5;
        public static Card GetHighCard(Card firstCard, Card secondCard)
        {
            return firstCard.CardValue > secondCard.CardValue ? firstCard : secondCard;          
        }

        public static bool IsTie(Card firstCard, Card secondCard, out Card highCard)
        {
            var isTie = firstCard.CardValue.Equals(secondCard.CardValue);
            highCard = isTie ? null : GetHighCard(firstCard, secondCard);
            return isTie;
        }

        public static PlayerHand GetHighestHandFromPlayers(PlayerHand firstPlayer, PlayerHand secondPlayer)
        {
            var firstPlayersCards = firstPlayer.Hand.Cards;
            var secondPlayersCards = secondPlayer.Hand.Cards;

            for(var i=0; i< CardsInAHand; i++)
            {
                //compare card lists in parallel sorted positions
                var tie = IsTie(firstPlayersCards[i], secondPlayersCards[i], out var winner);
                if (!tie)
                {
                    return winner.Equals(firstPlayer.Hand.Cards[i]) ? firstPlayer : secondPlayer;
                }
            }
            //if we get here means hands are stalemate, return null
            return null;
        }
    }
}