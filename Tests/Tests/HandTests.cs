using Poker.Data;
using Xunit;
using Tests.TestParameterObjects;

namespace Tests.Tests
{
    public class HandTests
    {
        [Theory]
        [ClassData(typeof(Test_HandHasCardData))]
        public void HandHasCard_ReturnsExpected(Hand hand, Card card, bool expectedResult)
        {
            Assert.True(hand.HandHasCard(card).Equals(expectedResult));
        }

        [Theory]
        [ClassData(typeof(Test_FlushHandData))]
        public void HandIsFlush_ReturnsExpected(Hand hand, bool expectedResult)
        {
            Assert.True(hand.IsFlush().Equals(expectedResult));
        }   
    }
}
