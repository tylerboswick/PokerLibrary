using System.Collections;
using System.Collections.Generic;
using Poker.Data;
using Poker.Enums;

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
                    new Card(Suit.Spades, CardValue.Ace),
                    new Card(Suit.Clubs, CardValue.Ace),
                    new Card(Suit.Diamonds, CardValue.Queen),
                    new Card(Suit.Diamonds, CardValue.Two),
                    new Card(Suit.Hearts, CardValue.Five)
                ),
                2,
                CardValue.Ace
            };
            yield return new object[]
            {
                new Hand
                (
                    new Card(Suit.Spades, CardValue.Ace),
                    new Card(Suit.Clubs, CardValue.Two),
                    new Card(Suit.Diamonds, CardValue.Ace),
                    new Card(Suit.Diamonds, CardValue.Two),
                    new Card(Suit.Hearts, CardValue.Two)
                ),
                2,
                CardValue.Ace
            };
            yield return new object[]
            {
                new Hand
                (
                    new Card(Suit.Spades, CardValue.Ace),
                    new Card(Suit.Clubs, CardValue.Two),
                    new Card(Suit.Diamonds, CardValue.Two),
                    new Card(Suit.Diamonds, CardValue.Ace),
                    new Card(Suit.Hearts, CardValue.Two)
                ),
                2,
                CardValue.Ace
            };
            yield return new object[]
            {
                new Hand
                (
                    new Card(Suit.Spades, CardValue.Ace),
                    new Card(Suit.Clubs, CardValue.Two),
                    new Card(Suit.Diamonds, CardValue.Two),
                    new Card(Suit.Diamonds, CardValue.Three),
                    new Card(Suit.Hearts, CardValue.Ace)
                ),
                2,
                CardValue.Ace
            };
            yield return new object[]
            {
                new Hand
                (
                    new Card(Suit.Spades, CardValue.Two),
                    new Card(Suit.Clubs, CardValue.Ace),
                    new Card(Suit.Diamonds, CardValue.Ace),
                    new Card(Suit.Diamonds, CardValue.Two),
                    new Card(Suit.Hearts, CardValue.Five)
                ),
                2,
                CardValue.Ace
            };
            yield return new object[]
            {
                new Hand
                (
                    new Card(Suit.Spades, CardValue.Two),
                    new Card(Suit.Clubs, CardValue.Ace),
                    new Card(Suit.Diamonds, CardValue.Queen),
                    new Card(Suit.Diamonds, CardValue.Ace),
                    new Card(Suit.Hearts, CardValue.Five)
                ),
                2,
                CardValue.Ace
            };
            yield return new object[]
            {
                new Hand
                (
                    new Card(Suit.Spades, CardValue.Two),
                    new Card(Suit.Clubs, CardValue.Ace),
                    new Card(Suit.Diamonds, CardValue.Queen),
                    new Card(Suit.Diamonds, CardValue.Two),
                    new Card(Suit.Hearts, CardValue.Ace)
                ),
                2,
                CardValue.Ace
            };
            yield return new object[]
            {
                new Hand
                (
                    new Card(Suit.Spades, CardValue.Two),
                    new Card(Suit.Clubs, CardValue.Two),
                    new Card(Suit.Diamonds, CardValue.Ace),
                    new Card(Suit.Diamonds, CardValue.Two),
                    new Card(Suit.Hearts, CardValue.Ace)
                ),
                2,
                CardValue.Ace
            };
            yield return new object[]
            {
                new Hand
                (
                    new Card(Suit.Spades, CardValue.Three),
                    new Card(Suit.Clubs, CardValue.Two),
                    new Card(Suit.Diamonds, CardValue.Four),
                    new Card(Suit.Diamonds, CardValue.Ace),
                    new Card(Suit.Hearts, CardValue.Ace)
                ),
                2,
                CardValue.Ace
            };
            yield return new object[]
            {
                new Hand
                (
                    new Card(Suit.Spades, CardValue.Three),
                    new Card(Suit.Clubs, CardValue.Ten),
                    new Card(Suit.Diamonds, CardValue.Four),
                    new Card(Suit.Diamonds, CardValue.Ten),
                    new Card(Suit.Hearts, CardValue.Ace)
                ),
                2,
                CardValue.Ten
            };
            yield return new object[]
            {
                new Hand
                (
                    new Card(Suit.Empty, CardValue.Ten),
                    new Card(Suit.Empty, CardValue.Six),
                    new Card(Suit.Empty, CardValue.Four),
                    new Card(Suit.Empty, CardValue.Seven),
                    new Card(Suit.Empty, CardValue.Ten)
                ),
                2,
                CardValue.Ten
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
                    new Card(Suit.Empty, CardValue.Ten),
                    new Card(Suit.Empty, CardValue.Ten),
                    new Card(Suit.Empty, CardValue.Ten),
                    new Card(Suit.Empty, CardValue.Seven),
                    new Card(Suit.Empty, CardValue.Six)
                ),
                3,
                CardValue.Ten
            };
            yield return new object[]
            {
                new Hand
                (
                    new Card(Suit.Empty, CardValue.Ten),
                    new Card(Suit.Empty, CardValue.Ten),
                    new Card(Suit.Empty, CardValue.Five),
                    new Card(Suit.Empty, CardValue.Ten),
                    new Card(Suit.Empty, CardValue.Six)
                ),
                3,
                CardValue.Ten
            };
            yield return new object[]
            {
                new Hand
                (
                    new Card(Suit.Empty, CardValue.Ten),
                    new Card(Suit.Empty, CardValue.Ten),
                    new Card(Suit.Empty, CardValue.Five),
                    new Card(Suit.Empty, CardValue.Four),
                    new Card(Suit.Empty, CardValue.Ten)
                ),
                3,
                CardValue.Ten
            };
            yield return new object[]
            {
                new Hand
                (
                    new Card(Suit.Empty, CardValue.Seven),
                    new Card(Suit.Empty, CardValue.Ten),
                    new Card(Suit.Empty, CardValue.Ten),
                    new Card(Suit.Empty, CardValue.Ten),
                    new Card(Suit.Empty, CardValue.Six)
                ),
                3,
                CardValue.Ten
            };
            yield return new object[]
            {
                new Hand
                (
                    new Card(Suit.Empty, CardValue.Seven),
                    new Card(Suit.Empty, CardValue.Five),
                    new Card(Suit.Empty, CardValue.Ten),
                    new Card(Suit.Empty, CardValue.Ten),
                    new Card(Suit.Empty, CardValue.Ten)
                ),
                3,
                CardValue.Ten
            };
            yield return new object[]
            {
                new Hand
                (
                    new Card(Suit.Empty, CardValue.Seven),
                    new Card(Suit.Empty, CardValue.Ten),
                    new Card(Suit.Empty, CardValue.Ten),
                    new Card(Suit.Empty, CardValue.Ten),
                    new Card(Suit.Empty, CardValue.Ten)
                ),
                3,
                CardValue.Ten
            };
            yield return new object[]
            {
                new Hand
                (
                    new Card(Suit.Empty, CardValue.Ten),
                    new Card(Suit.Empty, CardValue.Ten),
                    new Card(Suit.Empty, CardValue.Ten),
                    new Card(Suit.Empty, CardValue.Ten),
                    new Card(Suit.Empty, CardValue.Four)
                ),
                3,
                CardValue.Ten
            };
        }
        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
