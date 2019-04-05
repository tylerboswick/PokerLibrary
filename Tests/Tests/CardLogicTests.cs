using Xunit;
using Poker.Logic;
using Poker.Data;
using Tests.TestParameterObjects;

namespace Tests.Tests
{
    public class CardLogicTests
    {
        [Theory]
        [ClassData(typeof(Test_CardCompareData))]
        public void GetHighCard_ExpectedIsReturned_WhenPassingTwoDifferentCardValues(Card cardOne, Card cardTwo, Card expectedValue)
        {
            var logic = new PokerLogic();
            Assert.True(logic.GetHighCard(cardOne, cardTwo).Equals(expectedValue));
        }

        [Theory]
        [ClassData(typeof(Test_HandCardData))]
        public void GetHighCardFromHand_HighCardIsReturned_WhenPassingHandWithUniqueCardValues(Hand hand, Card highCard)
        {
            var logic = new PokerLogic();
            var result = logic.GetHighCardFromHand(hand);
            Assert.True(result.Equals(highCard));
        }

        [Theory]
        [ClassData(typeof(Test_HandHandData))]
        public void HighCardHandIsReturned_WhenPassingTwoUniqueCardHands(Hand handOne, Hand handTwo)
        {
            var logic = new PokerLogic();
            var result = logic.GetHighHand(handOne, handTwo);
            Assert.True(result.Equals(handOne));
        }
    }
}
