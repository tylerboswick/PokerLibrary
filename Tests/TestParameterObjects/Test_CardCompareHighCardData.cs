using System.Collections;
using System.Collections.Generic;
using Poker.Data;
using Poker.Enums;

namespace Tests.TestParameterObjects
{
    //Test Data Input for CardCompareHelpers.GetHighCard_ExpectedIsReturned_WhenPassingTwoDifferentCardValues
    public class Test_CardCompareHighCardData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[] { new Card(Suit.Empty, CardValue.Ace), new Card(Suit.Empty, CardValue.Empty), new Card(Suit.Empty, CardValue.Ace) };
            yield return new object[] { new Card(Suit.Empty, CardValue.Ace), new Card(Suit.Empty, CardValue.Two), new Card(Suit.Empty, CardValue.Ace) };
            yield return new object[] { new Card(Suit.Empty, CardValue.Ace), new Card(Suit.Empty, CardValue.Three), new Card(Suit.Empty, CardValue.Ace) };
            yield return new object[] { new Card(Suit.Empty, CardValue.Ace), new Card(Suit.Empty, CardValue.Four), new Card(Suit.Empty, CardValue.Ace) };
            yield return new object[] { new Card(Suit.Empty, CardValue.Ace), new Card(Suit.Empty, CardValue.Five), new Card(Suit.Empty, CardValue.Ace) };
            yield return new object[] { new Card(Suit.Empty, CardValue.Ace), new Card(Suit.Empty, CardValue.Six), new Card(Suit.Empty, CardValue.Ace) };
            yield return new object[] { new Card(Suit.Empty, CardValue.Ace), new Card(Suit.Empty, CardValue.Seven), new Card(Suit.Empty, CardValue.Ace) };
            yield return new object[] { new Card(Suit.Empty, CardValue.Ace), new Card(Suit.Empty, CardValue.Eight), new Card(Suit.Empty, CardValue.Ace) };
            yield return new object[] { new Card(Suit.Empty, CardValue.Ace), new Card(Suit.Empty, CardValue.Nine), new Card(Suit.Empty, CardValue.Ace) };
            yield return new object[] { new Card(Suit.Empty, CardValue.Ace), new Card(Suit.Empty, CardValue.Ten), new Card(Suit.Empty, CardValue.Ace) };
            yield return new object[] { new Card(Suit.Empty, CardValue.Ace), new Card(Suit.Empty, CardValue.Jack), new Card(Suit.Empty, CardValue.Ace) };
            yield return new object[] { new Card(Suit.Empty, CardValue.Ace), new Card(Suit.Empty, CardValue.Queen), new Card(Suit.Empty, CardValue.Ace) };
            yield return new object[] { new Card(Suit.Empty, CardValue.Ace), new Card(Suit.Empty, CardValue.King), new Card(Suit.Empty, CardValue.Ace) };

            yield return new object[] { new Card(Suit.Empty, CardValue.Empty), new Card(Suit.Empty, CardValue.Ace), new Card(Suit.Empty, CardValue.Ace) };
            yield return new object[] { new Card(Suit.Empty, CardValue.Two),   new Card(Suit.Empty, CardValue.Ace), new Card(Suit.Empty, CardValue.Ace) };
            yield return new object[] { new Card(Suit.Empty, CardValue.Three), new Card(Suit.Empty, CardValue.Ace), new Card(Suit.Empty, CardValue.Ace) };
            yield return new object[] { new Card(Suit.Empty, CardValue.Four),  new Card(Suit.Empty, CardValue.Ace), new Card(Suit.Empty, CardValue.Ace) };
            yield return new object[] { new Card(Suit.Empty, CardValue.Five),  new Card(Suit.Empty, CardValue.Ace), new Card(Suit.Empty, CardValue.Ace) };
            yield return new object[] { new Card(Suit.Empty, CardValue.Six),   new Card(Suit.Empty, CardValue.Ace), new Card(Suit.Empty, CardValue.Ace) };
            yield return new object[] { new Card(Suit.Empty, CardValue.Seven), new Card(Suit.Empty, CardValue.Ace), new Card(Suit.Empty, CardValue.Ace) };
            yield return new object[] { new Card(Suit.Empty, CardValue.Eight), new Card(Suit.Empty, CardValue.Ace), new Card(Suit.Empty, CardValue.Ace) };
            yield return new object[] { new Card(Suit.Empty, CardValue.Nine),  new Card(Suit.Empty, CardValue.Ace), new Card(Suit.Empty, CardValue.Ace) };
            yield return new object[] { new Card(Suit.Empty, CardValue.Ten),   new Card(Suit.Empty, CardValue.Ace), new Card(Suit.Empty, CardValue.Ace) };
            yield return new object[] { new Card(Suit.Empty, CardValue.Jack),  new Card(Suit.Empty, CardValue.Ace), new Card(Suit.Empty, CardValue.Ace) };
            yield return new object[] { new Card(Suit.Empty, CardValue.Queen), new Card(Suit.Empty, CardValue.Ace), new Card(Suit.Empty, CardValue.Ace) };
            yield return new object[] { new Card(Suit.Empty, CardValue.King),  new Card(Suit.Empty, CardValue.Ace), new Card(Suit.Empty, CardValue.Ace) };
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
