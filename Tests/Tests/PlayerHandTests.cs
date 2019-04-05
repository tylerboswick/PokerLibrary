using Poker.Data;
using Poker.Enums;
using Tests.TestParameterObjects;
using Xunit;

namespace Tests.Tests
{
    public class PlayerHandTests
    {
        [Theory]
        [ClassData(typeof(Test_PlayerCardEvalData))]
        public void EvaluatePlayerHand_SetsExpected(PlayerHand playerHand, HandValue expectedValue, CardValue highValue)
        {
            playerHand.HandValue = HandValue.Empty;
            playerHand.HighCard = CardValue.Empty;
            playerHand.EvaluatePlayerHand();
            Assert.True(playerHand.HandValue.Equals(expectedValue));
            Assert.True(playerHand.HighCard.Equals(highValue));
            Assert.Equal("Test", playerHand.Name);
        }
    }
}
