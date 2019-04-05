using System.Collections;
using System.Collections.Generic;
using Poker.Data;
using Poker.Enums;

namespace Tests.TestParameterObjects
{
    public class Test_WinnerData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[]
            {
                new List<PlayerHand>
                {
                    new PlayerHand("Doug",
                        new Hand(
                            new Card(Suit.Clubs, CardValue.Four),
                            new Card(Suit.Spades, CardValue.Jack),
                            new Card(Suit.Spades, CardValue.Nine),
                            new Card(Suit.Diamonds, CardValue.Jack),
                            new Card(Suit.Hearts, CardValue.Two)
                        )),
                    new PlayerHand("Bob",
                        new Hand(
                            new Card(Suit.Diamonds, CardValue.Eight),
                            new Card(Suit.Clubs, CardValue.Eight),
                            new Card(Suit.Hearts, CardValue.Eight),
                            new Card(Suit.Spades, CardValue.Two),
                            new Card(Suit.Diamonds, CardValue.Nine)))

                },
                new PlayerHand("Bob",
                    new Hand(
                        new Card(Suit.Diamonds, CardValue.Eight),
                        new Card(Suit.Clubs, CardValue.Eight),
                        new Card(Suit.Hearts, CardValue.Eight),
                        new Card(Suit.Spades, CardValue.Two),
                        new Card(Suit.Diamonds, CardValue.Nine)))
            };
        }
        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
