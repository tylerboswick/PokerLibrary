using Poker.Data;
using Xunit;
using System.Collections;
using System.Collections.Generic;

namespace Tests.Tests
{
    public class HandTests
    {
        [Theory]
        [ClassData(typeof(TestPositive_HandData))]
        public void HandHasCard_ReturnsTrue_IfCardInHand(Hand hand, Card card)
        {
            var result = hand.HandHasCard(card);
            Assert.True(result);
        }

        [Theory]
        [ClassData(typeof(TestNegative_HandData))]
        public void HandHasCard_ReturnsFalse_IfCardNotInHand(Hand hand, Card card)
        {
            var result = hand.HandHasCard(card);
            Assert.False(result);
        }
    }

    //Test Data Input for HandTests.HandHasCard_ReturnsTrue_IfCardInHand
    public class TestPositive_HandData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[] { new Hand(), new Card() };
            yield return new object[]
            {
                new Hand
                (
                    new Card(Suit.Spades, Value.Ace),
                    new Card(Suit.Clubs, Value.Ace),
                    new Card(Suit.Hearts, Value.Ace),
                    new Card(Suit.Hearts, Value.Eight),
                    new Card(Suit.Spades, Value.Jack)
                ),
                new Card(Suit.Spades, Value.Ace) };
            yield return new object[]
{
                new Hand
                (
                    new Card(Suit.Diamonds, Value.Ace),
                    new Card(Suit.Diamonds, Value.Five),
                    new Card(Suit.Diamonds, Value.Three),
                    new Card(Suit.Hearts, Value.Eight),
                    new Card(Suit.Spades, Value.Jack)
                ),
                new Card(Suit.Hearts, Value.Eight) };
        }
        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }

    //Test Data Input for HandTests.HandHasCard_ReturnsFalse_IfCardNotInHand
    public class TestNegative_HandData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[] { new Hand(), new Card(Suit.Spades, Value.Ace) };
            yield return new object[]
            {
                new Hand
                (
                    new Card(Suit.Clubs, Value.Ace),
                    new Card(Suit.Hearts, Value.Ace),
                    new Card(Suit.Diamonds, Value.Ace),
                    new Card(Suit.Empty, Value.Ace),
                    new Card(Suit.Diamonds, Value.King)
                ),
                new Card(Suit.Spades, Value.Ace) };
            yield return new object[]
            {
                new Hand
                (
                   new Card(Suit.Spades, Value.Two),
                   new Card(Suit.Spades, Value.Three),
                   new Card(Suit.Spades, Value.Four),
                   new Card(Suit.Spades, Value.Five),
                   new Card(Suit.Spades, Value.Six)
                ),
                new Card(Suit.Spades, Value.Ace) };
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
