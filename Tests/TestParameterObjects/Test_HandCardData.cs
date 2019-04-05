using System.Collections;
using System.Collections.Generic;
using Poker.Data;

namespace Tests.TestParameterObjects
{
    //Test Data Input for CardLogicTests.GetHighCardFromHand_HighCardIsReturned_WhenPassingHandWithUniqueCardValues
    public class Test_HandCardData : IEnumerable<object[]>
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
                            new Card(Suit.Empty, Value.Two)
                        ),
                new Card(Suit.Empty, Value.Two)
            };
            yield return new object[] {
                new Hand(
                            new Card(),
                            new Card(),
                            new Card(),
                            new Card(Suit.Empty, Value.Three),
                            new Card(Suit.Empty, Value.Two)
                        ),
                new Card(Suit.Empty, Value.Three)
            };
            yield return new object[] {
                new Hand(
                            new Card(),
                            new Card(),
                            new Card(Suit.Empty, Value.Four),
                            new Card(Suit.Empty, Value.Three),
                            new Card(Suit.Empty, Value.Two)
                        ),
                new Card(Suit.Empty, Value.Four)
            };
            yield return new object[] {
                new Hand(
                            new Card(),
                            new Card(Suit.Empty, Value.Five),
                            new Card(Suit.Empty, Value.Four),
                            new Card(Suit.Empty, Value.Three),
                            new Card(Suit.Empty, Value.Two)
                        ),
                new Card(Suit.Empty, Value.Five)
            };
            yield return new object[] {
                new Hand(
                            new Card(Suit.Empty, Value.Six),
                            new Card(Suit.Empty, Value.Five),
                            new Card(Suit.Empty, Value.Four),
                            new Card(Suit.Empty, Value.Three),
                            new Card(Suit.Empty, Value.Two)
                        ),
                new Card(Suit.Empty, Value.Six)
            };
            yield return new object[] {
                new Hand(
                            new Card(Suit.Empty, Value.Six),
                            new Card(Suit.Empty, Value.Five),
                            new Card(Suit.Empty, Value.Four),
                            new Card(Suit.Empty, Value.Three),
                            new Card(Suit.Empty, Value.Queen)
                        ),
                new Card(Suit.Empty, Value.Queen)
            };
            yield return new object[] {
                new Hand(
                            new Card(Suit.Empty, Value.Six),
                            new Card(Suit.Empty, Value.Five),
                            new Card(Suit.Empty, Value.Four),
                            new Card(Suit.Empty, Value.Queen),
                            new Card(Suit.Empty, Value.Two)
                        ),
                new Card(Suit.Empty, Value.Queen)
            };
            yield return new object[] {
                new Hand(
                            new Card(Suit.Empty, Value.Six),
                            new Card(Suit.Empty, Value.Five),
                            new Card(Suit.Empty, Value.Queen),
                            new Card(Suit.Empty, Value.Three),
                            new Card(Suit.Empty, Value.Two)
                        ),
                new Card(Suit.Empty, Value.Queen)
            };
            yield return new object[] {
                new Hand(
                            new Card(Suit.Empty, Value.Six),
                            new Card(Suit.Empty, Value.Queen),
                            new Card(Suit.Empty, Value.Four),
                            new Card(Suit.Empty, Value.Three),
                            new Card(Suit.Empty, Value.Two)
                        ),
                new Card(Suit.Empty, Value.Queen)
            };
            yield return new object[] {
                new Hand(
                            new Card(Suit.Empty, Value.Queen),
                            new Card(Suit.Empty, Value.Five),
                            new Card(Suit.Empty, Value.Four),
                            new Card(Suit.Empty, Value.Three),
                            new Card(Suit.Empty, Value.Two)
                        ),
                new Card(Suit.Empty, Value.Queen)
            };
        }
        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
