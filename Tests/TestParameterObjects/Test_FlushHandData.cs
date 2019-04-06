using System.Collections;
using System.Collections.Generic;
using Poker.Data;
using Poker.Enums;

namespace Tests.TestParameterObjects
{
    //Test Data Input for HandTests.HighValueFlush_ReturnsExpected
    public class Test_FlushHandData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[] {new Hand(), CardValue.Empty};
            yield return new object[]
            {
                new Hand(
                    new Card(Suit.Hearts, CardValue.Ace),
                    new Card(Suit.Hearts, CardValue.Ace),
                    new Card(Suit.Hearts, CardValue.Ace),
                    new Card(Suit.Hearts, CardValue.Ace),
                    new Card(Suit.Hearts, CardValue.Ace)
                ),
                CardValue.Ace
            };
            yield return new object[]
            {
                new Hand(
                    new Card(Suit.Spades, CardValue.Ace),
                    new Card(Suit.Spades, CardValue.Ace),
                    new Card(Suit.Spades, CardValue.Ace),
                    new Card(Suit.Spades, CardValue.Ace),
                    new Card(Suit.Spades, CardValue.Ace)
                ),
                CardValue.Ace
            };
            yield return new object[]
            {
                new Hand(
                    new Card(Suit.Clubs, CardValue.Ace),
                    new Card(Suit.Clubs, CardValue.Ace),
                    new Card(Suit.Clubs, CardValue.Ace),
                    new Card(Suit.Clubs, CardValue.Ace),
                    new Card(Suit.Clubs, CardValue.Ace)
                ),
                CardValue.Ace
            };
            yield return new object[]
            {
                new Hand(
                    new Card(Suit.Diamonds, CardValue.Ace),
                    new Card(Suit.Diamonds, CardValue.Ace),
                    new Card(Suit.Diamonds, CardValue.Ace),
                    new Card(Suit.Diamonds, CardValue.Ace),
                    new Card(Suit.Diamonds, CardValue.Ace)
                ),
                CardValue.Ace
            };
            yield return new object[]
            {
                new Hand(
                    new Card(Suit.Diamonds, CardValue.Empty),
                    new Card(Suit.Hearts, CardValue.Empty),
                    new Card(Suit.Hearts, CardValue.Empty),
                    new Card(Suit.Hearts, CardValue.Empty),
                    new Card(Suit.Hearts, CardValue.Empty)
                ),
                CardValue.Empty
            };
            yield return new object[]
            {
                new Hand(
                    new Card(Suit.Hearts, CardValue.Empty),
                    new Card(Suit.Diamonds, CardValue.Empty),
                    new Card(Suit.Hearts, CardValue.Empty),
                    new Card(Suit.Hearts, CardValue.Empty),
                    new Card(Suit.Hearts, CardValue.Empty)
                ),
                CardValue.Empty
            };
            yield return new object[]
            {
                new Hand(
                    new Card(Suit.Hearts, CardValue.Empty),
                    new Card(Suit.Hearts, CardValue.Empty),
                    new Card(Suit.Diamonds, CardValue.Empty),
                    new Card(Suit.Hearts, CardValue.Empty),
                    new Card(Suit.Hearts, CardValue.Empty)
                ),
                CardValue.Empty
            };
            yield return new object[]
            {
                new Hand(
                    new Card(Suit.Hearts, CardValue.Empty),
                    new Card(Suit.Hearts, CardValue.Empty),
                    new Card(Suit.Hearts, CardValue.Empty),
                    new Card(Suit.Diamonds, CardValue.Empty),
                    new Card(Suit.Hearts, CardValue.Empty)
                ),
                CardValue.Empty
            };
            yield return new object[]
            {
                new Hand(
                    new Card(Suit.Hearts, CardValue.Empty),
                    new Card(Suit.Hearts, CardValue.Empty),
                    new Card(Suit.Hearts, CardValue.Empty),
                    new Card(Suit.Hearts, CardValue.Empty),
                    new Card(Suit.Diamonds, CardValue.Empty)
                ),
                CardValue.Empty
            };
            yield return new object[]
            {
                new Hand(
                    new Card(Suit.Spades, CardValue.Empty),
                    new Card(Suit.Hearts, CardValue.Empty),
                    new Card(Suit.Clubs, CardValue.Empty),
                    new Card(Suit.Diamonds, CardValue.Empty),
                    new Card(Suit.Spades, CardValue.Empty)
                ),
                CardValue.Empty
            };
            yield return new object[]
            {
                new Hand(
                    new Card(Suit.Hearts, CardValue.Two),
                    new Card(Suit.Hearts, CardValue.Three),
                    new Card(Suit.Hearts, CardValue.Ten),
                    new Card(Suit.Hearts, CardValue.Jack),
                    new Card(Suit.Hearts, CardValue.Ace)
                ),
                CardValue.Ace
            };
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}