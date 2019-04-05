using System.Collections.Generic;
using Poker.Data;
using Poker.Helpers;
using Poker.Interfaces;

namespace Poker.Logic
{
    public class PokerLogic : IPokerLogic
    {
        public Hand GetHighHand(Hand firstHand, Hand secondHand)
        {
            var firstHandHigh = firstHand.GetHighCardFromHand();
            var secondHandHigh = secondHand.GetHighCardFromHand();
            var highCard = CardCompareHelpers.GetHighCard(firstHandHigh, secondHandHigh);

            return highCard.Equals(firstHandHigh) ? firstHand : secondHand;
        }
        public PlayerHand GetWinnerFromHands(List<PlayerHand> playersWHands)
        {
            PlayerHand winner = null;



            return winner;
        }
    }
}
