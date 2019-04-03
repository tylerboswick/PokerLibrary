using Xunit;
using Poker.Logic;
using Poker.Data;
using System.Collections;
using System.Collections.Generic;

namespace Tests.Tests
{
    public class CardLogicTests_GetHighCard
    {
        [Theory]
        [ClassData(typeof(TestPositive_CardCompareData))]
        public void GetHighCard_HighCardIsReturned_WhenPassingTwoDifferentCardValues(Card cardOne, Card cardTwo)
        {
            var logic = new PokerLogic();
            var result = logic.GetHighCard(cardOne, cardTwo);
            Assert.True(result.Equals(cardOne));
        }

        //Test Data Input for CardLogicTests.GetHighCard_HighCardIsReturned_WhenPassingTwoDifferentCardValues
        public class TestPositive_CardCompareData : IEnumerable<object[]>
        {
            public IEnumerator<object[]> GetEnumerator()
            {
                yield return new Card[] { new Card(Suit.Empty, Value.Ace), new Card(Suit.Empty, Value.Empty) };
                yield return new Card[] { new Card(Suit.Empty, Value.Ace), new Card(Suit.Empty, Value.Two) };
                yield return new Card[] { new Card(Suit.Empty, Value.Ace), new Card(Suit.Empty, Value.Three) };
                yield return new Card[] { new Card(Suit.Empty, Value.Ace), new Card(Suit.Empty, Value.Four) };
                yield return new Card[] { new Card(Suit.Empty, Value.Ace), new Card(Suit.Empty, Value.Five) };
                yield return new Card[] { new Card(Suit.Empty, Value.Ace), new Card(Suit.Empty, Value.Six) };
                yield return new Card[] { new Card(Suit.Empty, Value.Ace), new Card(Suit.Empty, Value.Seven) };
                yield return new Card[] { new Card(Suit.Empty, Value.Ace), new Card(Suit.Empty, Value.Eight) };
                yield return new Card[] { new Card(Suit.Empty, Value.Ace), new Card(Suit.Empty, Value.Nine) };
                yield return new Card[] { new Card(Suit.Empty, Value.Ace), new Card(Suit.Empty, Value.Ten) };
                yield return new Card[] { new Card(Suit.Empty, Value.Ace), new Card(Suit.Empty, Value.Jack) };
                yield return new Card[] { new Card(Suit.Empty, Value.Ace), new Card(Suit.Empty, Value.Queen) };
                yield return new Card[] { new Card(Suit.Empty, Value.Ace), new Card(Suit.Empty, Value.King) };
            }

            IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
        }
    }
}
