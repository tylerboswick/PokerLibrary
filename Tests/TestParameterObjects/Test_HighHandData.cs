using System.Collections;
using System.Collections.Generic;
using Poker.Data;
using Poker.Enums;

namespace Tests.TestParameterObjects
{
    public class Test_HighHandData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[]
            {
                new Hand
                (
                    new Card(Suit.Spades, CardValue.Ace),
                    new Card(Suit.Clubs, CardValue.King),
                    new Card(Suit.Diamonds, CardValue.Queen),
                    new Card(Suit.Diamonds, CardValue.Two),
                    new Card(Suit.Hearts, CardValue.Five)
                ),
                new Hand
                (
                    new Card(Suit.Clubs, CardValue.Two),
                    new Card(Suit.Spades, CardValue.Three),
                    new Card(Suit.Diamonds, CardValue.Four),
                    new Card(Suit.Clubs, CardValue.Ten),
                    new Card(Suit.Hearts, CardValue.Ten)
                )
            };
            yield return new object[]
            {
                new Hand
                (
                    new Card(Suit.Spades, CardValue.Three),
                    new Card(Suit.Diamonds, CardValue.Five),
                    new Card(Suit.Clubs, CardValue.Three),
                    new Card(Suit.Clubs, CardValue.Two),
                    new Card(Suit.Hearts, CardValue.Two)
                ),
                new Hand
                (
                    new Card(Suit.Empty, CardValue.Two),
                    new Card(Suit.Hearts, CardValue.Three),
                    new Card(Suit.Diamonds, CardValue.Two),
                    new Card(Suit.Diamonds, CardValue.Three),
                    new Card(Suit.Diamonds, CardValue.Four)
                )
            };
        }
        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
