using Xunit;
using Poker.Logic;
using Poker.Data;
using Tests.TestParameterObjects;

namespace Tests.Tests
{
    public class CardLogicTests
    {
        [Theory]
        [ClassData(typeof(Test_HighHandData))]
        public void HighCardHandIsReturned_WhenPassingTwoUniqueCardHands(Hand handOne, Hand handTwo)
        {
            var logic = new PokerLogic();
            var result = logic.GetHighHand(handOne, handTwo);
            Assert.True(result.Equals(handOne));
        }
    }
}
