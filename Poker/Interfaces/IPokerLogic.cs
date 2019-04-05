using System.Collections.Generic;
using Poker.Data;

namespace Poker.Interfaces
{
    public interface IPokerLogic
    {
        Hand GetHighHand(Hand firstHand, Hand secondHand);
        PlayerHand GetWinnerFromHands(List<PlayerHand> players);
    }
}
