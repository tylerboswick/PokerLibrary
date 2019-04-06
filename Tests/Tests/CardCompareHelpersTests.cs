using Poker.Data;
using Poker.Helpers;
using Tests.TestParameterObjects;
using Xunit;

namespace Tests.Tests
{
    public class CardCompareHelpersTests
    {
        [Theory]
        [ClassData(typeof(Test_CardCompareHighCardData))]
        public void GetHighCard_ExpectedIsReturned_WhenPassingTwoDifferentCardValues(Card cardOne, Card cardTwo, Card expectedValue)
        {
            Assert.True(CardCompareHelpers.GetHighCard(cardOne, cardTwo).Equals(expectedValue));
        }

        [Theory]
        [ClassData(typeof(Test_CardCompareTieData))]
        public void IsTie_ExpectedIsReturned_WhenPassingTwoDifferentCards(Card cardOne, Card cardTwo, Card highCard, bool expectedValue)
        {
            var tieResult = CardCompareHelpers.IsTie(cardOne, cardTwo, out var resultHighCard);
            Assert.Equal(expectedValue, tieResult);
            Assert.Equal(highCard, resultHighCard);
        }

        [Theory]
        [ClassData(typeof(Test_HandCompareHighData))]
        public void GetHighestHandFromPlayers_ExpectedIsReturned_WhenPassingTwoDifferentHands(PlayerHand handOne, PlayerHand handTwo, string expectedPlayer)
        {
            Assert.Equal(expectedPlayer, CardCompareHelpers.GetHighestHandFromPlayers(handOne, handTwo).Name);
        }
    }
}
