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

        [Theory]
        [ClassData(typeof(Test_HandHighCardData))]
        public void GetHighCardFromHand_HighCardIsReturned_WhenPassingHandWithUniqueCardValues(Hand hand, Card highCard)
        {
            Assert.True(hand.GetHighCardFromHand().Equals(highCard));
        }

        [Theory]
        [ClassData(typeof(Test_HandMultipleValueData))]
        public void GetValuableDuplicateCardsByValue_HighMultipleValueIsReturned_FromHand(Hand hand, int typeOfMultiple, Value expectedValue)
        {
            Assert.True(hand.GetValuableDuplicateCardsByValue(typeOfMultiple).Equals(expectedValue));
        }


    }
}
