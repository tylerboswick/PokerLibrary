using System.Collections.Generic;
using Poker.Data;

namespace Poker.Interfaces
{
    public interface IPokerLogic
    {
        PlayerHand GetWinnerFromHands(List<PlayerHand> players);
    }
}
