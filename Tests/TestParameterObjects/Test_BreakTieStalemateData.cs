using System.Collections;
using System.Collections.Generic;
using Poker.Data;
using Poker.Enums;

namespace Tests.TestParameterObjects
{
    public class Test_BreakTieStalemateData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[]
            {
                new List<PlayerHand>
                {
                    new PlayerHand("Doug",
                        new Hand(
                            new Card(Suit.Diamonds, CardValue.Two),
                            new Card(Suit.Hearts, CardValue.Three),
                            new Card(Suit.Diamonds, CardValue.Four),
                            new Card(Suit.Hearts, CardValue.Five),
                            new Card(Suit.Diamonds, CardValue.Jack)
                        )),
                    new PlayerHand("Bob",
                        new Hand(
                            new Card(Suit.Clubs, CardValue.Two),
                            new Card(Suit.Spades, CardValue.Three),
                            new Card(Suit.Clubs, CardValue.Four),
                            new Card(Suit.Spades, CardValue.Five),
                            new Card(Suit.Clubs, CardValue.Jack)))

                }
            };
            yield return new object[]
            {
                new List<PlayerHand>
                {
                    new PlayerHand("Doug",
                        new Hand(
                            new Card(Suit.Diamonds, CardValue.Two),
                            new Card(Suit.Hearts, CardValue.Three),
                            new Card(Suit.Diamonds, CardValue.Four),
                            new Card(Suit.Hearts, CardValue.Five),
                            new Card(Suit.Diamonds, CardValue.Jack)
                        )),
                    new PlayerHand("Bob",
                        new Hand(
                            new Card(Suit.Clubs, CardValue.Two),
                            new Card(Suit.Spades, CardValue.Three),
                            new Card(Suit.Clubs, CardValue.Four),
                            new Card(Suit.Spades, CardValue.Five),
                            new Card(Suit.Clubs, CardValue.Jack))),
                    new PlayerHand("Steve",
                    new Hand(
                        new Card(Suit.Hearts, CardValue.Two),
                        new Card(Suit.Diamonds, CardValue.Three),
                        new Card(Suit.Hearts, CardValue.Four),
                        new Card(Suit.Diamonds, CardValue.Five),
                        new Card(Suit.Hearts, CardValue.Jack)
                    ))

                }
            };
            yield return new object[]
            {
                new List<PlayerHand>
                {
                    new PlayerHand("Doug",
                        new Hand(
                            new Card(Suit.Diamonds, CardValue.Two),
                            new Card(Suit.Hearts, CardValue.Three),
                            new Card(Suit.Diamonds, CardValue.Four),
                            new Card(Suit.Hearts, CardValue.Five),
                            new Card(Suit.Diamonds, CardValue.Jack)
                        )),
                    new PlayerHand("Bob",
                        new Hand(
                            new Card(Suit.Clubs, CardValue.Two),
                            new Card(Suit.Spades, CardValue.Three),
                            new Card(Suit.Clubs, CardValue.Four),
                            new Card(Suit.Spades, CardValue.Five),
                            new Card(Suit.Clubs, CardValue.Jack))),
                    new PlayerHand("Steve",
                        new Hand(
                            new Card(Suit.Hearts, CardValue.Two),
                            new Card(Suit.Diamonds, CardValue.Three),
                            new Card(Suit.Hearts, CardValue.Four),
                            new Card(Suit.Diamonds, CardValue.Five),
                            new Card(Suit.Hearts, CardValue.Jack)
                        )),
                    new PlayerHand("Jim",
                        new Hand(
                            new Card(Suit.Spades, CardValue.Two),
                            new Card(Suit.Clubs, CardValue.Three),
                            new Card(Suit.Spades, CardValue.Four),
                            new Card(Suit.Clubs, CardValue.Five),
                            new Card(Suit.Spades, CardValue.Jack)))
                }
            };
        }
        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
