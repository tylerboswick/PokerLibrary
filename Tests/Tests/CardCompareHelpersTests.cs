using Poker.Data;
using Poker.Helpers;
using Tests.TestParameterObjects;
using Xunit;

namespace Tests.Tests
{
    public class CardCompareHelpersTests
    {
        [Theory]
        [ClassData(typeof(Test_CardCompareData))]
        public void GetHighCard_ExpectedIsReturned_WhenPassingTwoDifferentCardValues(Card cardOne, Card cardTwo, Card expectedValue)
        {
            Assert.True(CardCompareHelpers.GetHighCard(cardOne, cardTwo).Equals(expectedValue));
        }
    }
}
