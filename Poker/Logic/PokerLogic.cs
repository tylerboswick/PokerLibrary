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
            //group all players with the same type (ie. all flushes or all pairs) - key in grouping is value of hand.
            var highValuePlayers = playersWHands.GroupBy(x => x.HandValue).OrderByDescending(y => y.Key).ToList();
            //group all players of the same type by value of type (ie. Flush Ace high,  pair of nines).
            var highPlayers = highValuePlayers.First().Select(x => x).GroupBy(x=>x.HighCard).OrderByDescending(y => y.Key).First().ToList();
            return highPlayers.Count() > 1 ? BreakTie(highPlayers) : highPlayers.First();;
        }

        public PlayerHand BreakTie(List<PlayerHand> tiedPlayers)
        {
            var stalematePlayers = new List<PlayerHand>();
            var currentHighestPlayer = tiedPlayers.First();
            //take the first player out as the "current highest player" to beat
            tiedPlayers.RemoveAt(0);

            foreach (var player in tiedPlayers)
            {
                var compareWinner = CardCompareHelpers.GetHighestHandFromPlayers(currentHighestPlayer, player);
                if (compareWinner == null)
                {
                    stalematePlayers.Add(player);
                    //don't duplicate high player in 3 way tie
                    if (!stalematePlayers.Contains(currentHighestPlayer)) stalematePlayers.Add(currentHighestPlayer);
                }
                else
                {
                    currentHighestPlayer = compareWinner;
                }
            }

            return stalematePlayers.Contains(currentHighestPlayer)? null : currentHighestPlayer;
        }
    }
}
