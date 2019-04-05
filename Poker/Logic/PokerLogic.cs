using System.Collections.Generic;
using System.Linq;
using Poker.Data;
using Poker.Helpers;
using Poker.Interfaces;

namespace Poker.Logic
{
    public class PokerLogic : IPokerLogic
    {
        public PlayerHand GetWinnerFromHands(List<PlayerHand> playersWHands)
        {
            var highValuePlayers = playersWHands.GroupBy(x => x.HandValue).OrderByDescending(y => y.Key).ToList();
            
            //key in grouping is value of hand
            var highValue = highValuePlayers.First().Key;
            var highPlayers = highValuePlayers.First().Select(x => x).ToList();

            return highPlayers.Count() > 1 ? BreakTie(highPlayers) : highPlayers.First();;
        }

        //TODO: Need tests
        public PlayerHand BreakTie(List<PlayerHand> highPlayers)
        {
            var highestPlayer = highPlayers.First();

            foreach (var player in highPlayers)
            {
                highestPlayer = CardCompareHelpers.GetHighestHandFromPlayers(highestPlayer, player);
            }

            return highestPlayer;
        }
    }
}
