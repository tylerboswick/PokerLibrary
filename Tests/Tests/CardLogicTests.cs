using System.Collections.Generic;
using Xunit;
using Poker.Logic;
using Poker.Data;
using Tests.TestParameterObjects;

namespace Tests.Tests
{
    public class CardLogicTests
    {
        [Theory]
        [ClassData(typeof(Test_WinnerData))]
        public void GetWinnerFromHands_ReturnsExpectedWinner_WhenPassingPlayersList(List<PlayerHand> playerHands, PlayerHand expectedWinner)
        {
            var logic = new PokerLogic();
            var result = logic.GetWinnerFromHands(playerHands);
            Assert.True(result.Equals(expectedWinner));
        }
    }
}
