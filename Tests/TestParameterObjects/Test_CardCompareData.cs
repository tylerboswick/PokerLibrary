using System.Collections;
using System.Collections.Generic;
using Poker.Data;

namespace Tests.TestParameterObjects
{
    //Test Data Input for CardLogicTests.GetHighCard_HighCardIsReturned_WhenPassingTwoDifferentCardValues
    public class Test_CardCompareData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[] { new Card(Suit.Empty, Value.Ace), new Card(Suit.Empty, Value.Empty), new Card(Suit.Empty, Value.Ace) };
            yield return new object[] { new Card(Suit.Empty, Value.Ace), new Card(Suit.Empty, Value.Two), new Card(Suit.Empty, Value.Ace) };
            yield return new object[] { new Card(Suit.Empty, Value.Ace), new Card(Suit.Empty, Value.Three), new Card(Suit.Empty, Value.Ace) };
            yield return new object[] { new Card(Suit.Empty, Value.Ace), new Card(Suit.Empty, Value.Four), new Card(Suit.Empty, Value.Ace) };
            yield return new object[] { new Card(Suit.Empty, Value.Ace), new Card(Suit.Empty, Value.Five), new Card(Suit.Empty, Value.Ace) };
            yield return new object[] { new Card(Suit.Empty, Value.Ace), new Card(Suit.Empty, Value.Six), new Card(Suit.Empty, Value.Ace) };
            yield return new object[] { new Card(Suit.Empty, Value.Ace), new Card(Suit.Empty, Value.Seven), new Card(Suit.Empty, Value.Ace) };
            yield return new object[] { new Card(Suit.Empty, Value.Ace), new Card(Suit.Empty, Value.Eight), new Card(Suit.Empty, Value.Ace) };
            yield return new object[] { new Card(Suit.Empty, Value.Ace), new Card(Suit.Empty, Value.Nine), new Card(Suit.Empty, Value.Ace) };
            yield return new object[] { new Card(Suit.Empty, Value.Ace), new Card(Suit.Empty, Value.Ten), new Card(Suit.Empty, Value.Ace) };
            yield return new object[] { new Card(Suit.Empty, Value.Ace), new Card(Suit.Empty, Value.Jack), new Card(Suit.Empty, Value.Ace) };
            yield return new object[] { new Card(Suit.Empty, Value.Ace), new Card(Suit.Empty, Value.Queen), new Card(Suit.Empty, Value.Ace) };
            yield return new object[] { new Card(Suit.Empty, Value.Ace), new Card(Suit.Empty, Value.King), new Card(Suit.Empty, Value.Ace) };

            yield return new object[] { new Card(Suit.Empty, Value.Empty), new Card(Suit.Empty, Value.Ace), new Card(Suit.Empty, Value.Ace) };
            yield return new object[] { new Card(Suit.Empty, Value.Two),   new Card(Suit.Empty, Value.Ace), new Card(Suit.Empty, Value.Ace) };
            yield return new object[] { new Card(Suit.Empty, Value.Three), new Card(Suit.Empty, Value.Ace), new Card(Suit.Empty, Value.Ace) };
            yield return new object[] { new Card(Suit.Empty, Value.Four),  new Card(Suit.Empty, Value.Ace), new Card(Suit.Empty, Value.Ace) };
            yield return new object[] { new Card(Suit.Empty, Value.Five),  new Card(Suit.Empty, Value.Ace), new Card(Suit.Empty, Value.Ace) };
            yield return new object[] { new Card(Suit.Empty, Value.Six),   new Card(Suit.Empty, Value.Ace), new Card(Suit.Empty, Value.Ace) };
            yield return new object[] { new Card(Suit.Empty, Value.Seven), new Card(Suit.Empty, Value.Ace), new Card(Suit.Empty, Value.Ace) };
            yield return new object[] { new Card(Suit.Empty, Value.Eight), new Card(Suit.Empty, Value.Ace), new Card(Suit.Empty, Value.Ace) };
            yield return new object[] { new Card(Suit.Empty, Value.Nine),  new Card(Suit.Empty, Value.Ace), new Card(Suit.Empty, Value.Ace) };
            yield return new object[] { new Card(Suit.Empty, Value.Ten),   new Card(Suit.Empty, Value.Ace), new Card(Suit.Empty, Value.Ace) };
            yield return new object[] { new Card(Suit.Empty, Value.Jack),  new Card(Suit.Empty, Value.Ace), new Card(Suit.Empty, Value.Ace) };
            yield return new object[] { new Card(Suit.Empty, Value.Queen), new Card(Suit.Empty, Value.Ace), new Card(Suit.Empty, Value.Ace) };
            yield return new object[] { new Card(Suit.Empty, Value.King),  new Card(Suit.Empty, Value.Ace), new Card(Suit.Empty, Value.Ace) };
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
