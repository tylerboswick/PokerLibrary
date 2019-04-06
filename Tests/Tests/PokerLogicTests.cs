using System.Collections.Generic;
using Xunit;
using Poker.Logic;
using Poker.Data;
using Tests.TestParameterObjects;

namespace Tests.Tests
{
    public class PokerLogicTests
    {
        [Theory]
        [ClassData(typeof(Test_WinnerData))]
        public void GetWinnerFromHands_ReturnsExpectedWinner_WhenPassingPlayersList(List<PlayerHand> playerHands, PlayerHand expectedWinner)
        {
            var logic = new PokerLogic();
            var result = logic.GetWinnerFromHands(playerHands);
            Assert.Equal(expectedWinner.Name, result.Name);
        }

        [Theory]
        [ClassData(typeof(Test_BreakTieData))]
        public void BreakTie_ReturnsExpectedWinner_WhenPassingPlayersList(List<PlayerHand> playerHands, PlayerHand expectedWinner)
        {
            var logic = new PokerLogic();
            var result = logic.BreakTie(playerHands);
            Assert.Equal(expectedWinner.Name, result.Name);
        }

        [Theory]
        [ClassData(typeof(Test_BreakTieStalemateData))]
        public void BreakTie_ReturnsNull_WhenTotalStalemate(List<PlayerHand> playerHands)
        {
            var logic = new PokerLogic();
            var result = logic.BreakTie(playerHands);
            Assert.Null(result);
        }
    }
}
