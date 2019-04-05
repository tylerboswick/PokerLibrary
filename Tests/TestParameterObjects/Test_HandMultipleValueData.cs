using System.Collections;
using System.Collections.Generic;
using Poker.Data;

namespace Tests.TestParameterObjects
{
    public class Test_HandMultipleValueData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[]
            {
                new Hand
                (
                    new Card(Suit.Spades, Value.Ace),
                    new Card(Suit.Clubs, Value.Ace),
                    new Card(Suit.Diamonds, Value.Queen),
                    new Card(Suit.Diamonds, Value.Two),
                    new Card(Suit.Hearts, Value.Five)
                ),
                2,
                Value.Ace
            };
            yield return new object[]
            {
                new Hand
                (
                    new Card(Suit.Spades, Value.Ace),
                    new Card(Suit.Clubs, Value.Two),
                    new Card(Suit.Diamonds, Value.Ace),
                    new Card(Suit.Diamonds, Value.Two),
                    new Card(Suit.Hearts, Value.Two)
                ),
                2,
                Value.Ace
            };
            yield return new object[]
            {
                new Hand
                (
                    new Card(Suit.Spades, Value.Ace),
                    new Card(Suit.Clubs, Value.Two),
                    new Card(Suit.Diamonds, Value.Two),
                    new Card(Suit.Diamonds, Value.Ace),
                    new Card(Suit.Hearts, Value.Two)
                ),
                2,
                Value.Ace
            };
            yield return new object[]
            {
                new Hand
                (
                    new Card(Suit.Spades, Value.Ace),
                    new Card(Suit.Clubs, Value.Two),
                    new Card(Suit.Diamonds, Value.Two),
                    new Card(Suit.Diamonds, Value.Three),
                    new Card(Suit.Hearts, Value.Ace)
                ),
                2,
                Value.Ace
            };
            yield return new object[]
            {
                new Hand
                (
                    new Card(Suit.Spades, Value.Two),
                    new Card(Suit.Clubs, Value.Ace),
                    new Card(Suit.Diamonds, Value.Ace),
                    new Card(Suit.Diamonds, Value.Two),
                    new Card(Suit.Hearts, Value.Five)
                ),
                2,
                Value.Ace
            };
            yield return new object[]
            {
                new Hand
                (
                    new Card(Suit.Spades, Value.Two),
                    new Card(Suit.Clubs, Value.Ace),
                    new Card(Suit.Diamonds, Value.Queen),
                    new Card(Suit.Diamonds, Value.Ace),
                    new Card(Suit.Hearts, Value.Five)
                ),
                2,
                Value.Ace
            };
            yield return new object[]
            {
                new Hand
                (
                    new Card(Suit.Spades, Value.Two),
                    new Card(Suit.Clubs, Value.Ace),
                    new Card(Suit.Diamonds, Value.Queen),
                    new Card(Suit.Diamonds, Value.Two),
                    new Card(Suit.Hearts, Value.Ace)
                ),
                2,
                Value.Ace
            };
            yield return new object[]
            {
                new Hand
                (
                    new Card(Suit.Spades, Value.Two),
                    new Card(Suit.Clubs, Value.Two),
                    new Card(Suit.Diamonds, Value.Ace),
                    new Card(Suit.Diamonds, Value.Two),
                    new Card(Suit.Hearts, Value.Ace)
                ),
                2,
                Value.Ace
            };
            yield return new object[]
            {
                new Hand
                (
                    new Card(Suit.Spades, Value.Three),
                    new Card(Suit.Clubs, Value.Two),
                    new Card(Suit.Diamonds, Value.Four),
                    new Card(Suit.Diamonds, Value.Ace),
                    new Card(Suit.Hearts, Value.Ace)
                ),
                2,
                Value.Ace
            };
            yield return new object[]
            {
                new Hand
                (
                    new Card(Suit.Spades, Value.Three),
                    new Card(Suit.Clubs, Value.Ten),
                    new Card(Suit.Diamonds, Value.Four),
                    new Card(Suit.Diamonds, Value.Ten),
                    new Card(Suit.Hearts, Value.Ace)
                ),
                2,
                Value.Ten
            };
            yield return new object[]
            {
                new Hand
                (
                    new Card(Suit.Empty, Value.Ten),
                    new Card(Suit.Empty, Value.Six),
                    new Card(Suit.Empty, Value.Four),
                    new Card(Suit.Empty, Value.Seven),
                    new Card(Suit.Empty, Value.Ten)
                ),
                2,
                Value.Ten
            };

            /*
             *
             *  3 Of a Kind Cases
             *
             */

            yield return new object[]
            {
                new Hand
                (
                    new Card(Suit.Empty, Value.Ten),
                    new Card(Suit.Empty, Value.Ten),
                    new Card(Suit.Empty, Value.Ten),
                    new Card(Suit.Empty, Value.Seven),
                    new Card(Suit.Empty, Value.Six)
                ),
                3,
                Value.Ten
            };
            yield return new object[]
            {
                new Hand
                (
                    new Card(Suit.Empty, Value.Ten),
                    new Card(Suit.Empty, Value.Ten),
                    new Card(Suit.Empty, Value.Five),
                    new Card(Suit.Empty, Value.Ten),
                    new Card(Suit.Empty, Value.Six)
                ),
                3,
                Value.Ten
            };
            yield return new object[]
            {
                new Hand
                (
                    new Card(Suit.Empty, Value.Ten),
                    new Card(Suit.Empty, Value.Ten),
                    new Card(Suit.Empty, Value.Five),
                    new Card(Suit.Empty, Value.Four),
                    new Card(Suit.Empty, Value.Ten)
                ),
                3,
                Value.Ten
            };
            yield return new object[]
            {
                new Hand
                (
                    new Card(Suit.Empty, Value.Seven),
                    new Card(Suit.Empty, Value.Ten),
                    new Card(Suit.Empty, Value.Ten),
                    new Card(Suit.Empty, Value.Ten),
                    new Card(Suit.Empty, Value.Six)
                ),
                3,
                Value.Ten
            };
            yield return new object[]
            {
                new Hand
                (
                    new Card(Suit.Empty, Value.Seven),
                    new Card(Suit.Empty, Value.Five),
                    new Card(Suit.Empty, Value.Ten),
                    new Card(Suit.Empty, Value.Ten),
                    new Card(Suit.Empty, Value.Ten)
                ),
                3,
                Value.Ten
            };
            yield return new object[]
            {
                new Hand
                (
                    new Card(Suit.Empty, Value.Seven),
                    new Card(Suit.Empty, Value.Ten),
                    new Card(Suit.Empty, Value.Ten),
                    new Card(Suit.Empty, Value.Ten),
                    new Card(Suit.Empty, Value.Ten)
                ),
                3,
                Value.Ten
            };
            yield return new object[]
            {
                new Hand
                (
                    new Card(Suit.Empty, Value.Ten),
                    new Card(Suit.Empty, Value.Ten),
                    new Card(Suit.Empty, Value.Ten),
                    new Card(Suit.Empty, Value.Ten),
                    new Card(Suit.Empty, Value.Four)
                ),
                3,
                Value.Ten
            };
        }
        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
