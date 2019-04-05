using System.Collections;
using System.Collections.Generic;
using Poker.Data;
using Poker.Enums;

namespace Tests.TestParameterObjects
{
    //Test Data Input for CardLogicTests.GetHighCardFromHand_HighCardIsReturned_WhenPassingHandWithUniqueCardValues
    public class Test_HandHighCardData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[] { new Hand(), new Card() };
            yield return new object[] {
                new Hand(
                            new Card(),
                            new Card(),
                            new Card(),
                            new Card(),
                            new Card(Suit.Empty, CardValue.Two)
                        ),
                new Card(Suit.Empty, CardValue.Two)
            };
            yield return new object[] {
                new Hand(
                            new Card(),
                            new Card(),
                            new Card(),
                            new Card(Suit.Empty, CardValue.Three),
                            new Card(Suit.Empty, CardValue.Two)
                        ),
                new Card(Suit.Empty, CardValue.Three)
            };
            yield return new object[] {
                new Hand(
                            new Card(),
                            new Card(),
                            new Card(Suit.Empty, CardValue.Four),
                            new Card(Suit.Empty, CardValue.Three),
                            new Card(Suit.Empty, CardValue.Two)
                        ),
                new Card(Suit.Empty, CardValue.Four)
            };
            yield return new object[] {
                new Hand(
                            new Card(),
                            new Card(Suit.Empty, CardValue.Five),
                            new Card(Suit.Empty, CardValue.Four),
                            new Card(Suit.Empty, CardValue.Three),
                            new Card(Suit.Empty, CardValue.Two)
                        ),
                new Card(Suit.Empty, CardValue.Five)
            };
            yield return new object[] {
                new Hand(
                            new Card(Suit.Empty, CardValue.Six),
                            new Card(Suit.Empty, CardValue.Five),
                            new Card(Suit.Empty, CardValue.Four),
                            new Card(Suit.Empty, CardValue.Three),
                            new Card(Suit.Empty, CardValue.Two)
                        ),
                new Card(Suit.Empty, CardValue.Six)
            };
            yield return new object[] {
                new Hand(
                            new Card(Suit.Empty, CardValue.Six),
                            new Card(Suit.Empty, CardValue.Five),
                            new Card(Suit.Empty, CardValue.Four),
                            new Card(Suit.Empty, CardValue.Three),
                            new Card(Suit.Empty, CardValue.Queen)
                        ),
                new Card(Suit.Empty, CardValue.Queen)
            };
            yield return new object[] {
                new Hand(
                            new Card(Suit.Empty, CardValue.Six),
                            new Card(Suit.Empty, CardValue.Five),
                            new Card(Suit.Empty, CardValue.Four),
                            new Card(Suit.Empty, CardValue.Queen),
                            new Card(Suit.Empty, CardValue.Two)
                        ),
                new Card(Suit.Empty, CardValue.Queen)
            };
            yield return new object[] {
                new Hand(
                            new Card(Suit.Empty, CardValue.Six),
                            new Card(Suit.Empty, CardValue.Five),
                            new Card(Suit.Empty, CardValue.Queen),
                            new Card(Suit.Empty, CardValue.Three),
                            new Card(Suit.Empty, CardValue.Two)
                        ),
                new Card(Suit.Empty, CardValue.Queen)
            };
            yield return new object[] {
                new Hand(
                            new Card(Suit.Empty, CardValue.Six),
                            new Card(Suit.Empty, CardValue.Queen),
                            new Card(Suit.Empty, CardValue.Four),
                            new Card(Suit.Empty, CardValue.Three),
                            new Card(Suit.Empty, CardValue.Two)
                        ),
                new Card(Suit.Empty, CardValue.Queen)
            };
            yield return new object[] {
                new Hand(
                            new Card(Suit.Empty, CardValue.Queen),
                            new Card(Suit.Empty, CardValue.Five),
                            new Card(Suit.Empty, CardValue.Four),
                            new Card(Suit.Empty, CardValue.Three),
                            new Card(Suit.Empty, CardValue.Two)
                        ),
                new Card(Suit.Empty, CardValue.Queen)
            };
        }
        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
