using System.Collections;
using System.Collections.Generic;
using Poker.Data;
using Poker.Enums;

namespace Tests.TestParameterObjects
{
    //Test Data Input for CardCompareHelpers.IsTie_ExpectedIsReturned_WhenPassingTwoDifferentCards
    public class Test_CardCompareTieData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[] { new Card(Suit.Empty, CardValue.Ace), new Card(Suit.Empty, CardValue.Empty), new Card(Suit.Empty, CardValue.Ace), false };
            yield return new object[] { new Card(Suit.Empty, CardValue.Ace), new Card(Suit.Empty, CardValue.Two), new Card(Suit.Empty, CardValue.Ace),false };
            yield return new object[] { new Card(Suit.Empty, CardValue.Ace), new Card(Suit.Empty, CardValue.Three), new Card(Suit.Empty, CardValue.Ace), false };
            yield return new object[] { new Card(Suit.Empty, CardValue.Ace), new Card(Suit.Empty, CardValue.Four), new Card(Suit.Empty, CardValue.Ace), false };
            yield return new object[] { new Card(Suit.Empty, CardValue.Ace), new Card(Suit.Empty, CardValue.Five), new Card(Suit.Empty, CardValue.Ace), false };
            yield return new object[] { new Card(Suit.Empty, CardValue.Ace), new Card(Suit.Empty, CardValue.Six), new Card(Suit.Empty, CardValue.Ace), false };
            yield return new object[] { new Card(Suit.Empty, CardValue.Ace), new Card(Suit.Empty, CardValue.Seven), new Card(Suit.Empty, CardValue.Ace), false };
            yield return new object[] { new Card(Suit.Empty, CardValue.Ace), new Card(Suit.Empty, CardValue.Eight), new Card(Suit.Empty, CardValue.Ace), false };
            yield return new object[] { new Card(Suit.Empty, CardValue.Ace), new Card(Suit.Empty, CardValue.Nine), new Card(Suit.Empty, CardValue.Ace), false };
            yield return new object[] { new Card(Suit.Empty, CardValue.Ace), new Card(Suit.Empty, CardValue.Ten), new Card(Suit.Empty, CardValue.Ace), false };
            yield return new object[] { new Card(Suit.Empty, CardValue.Ace), new Card(Suit.Empty, CardValue.Jack), new Card(Suit.Empty, CardValue.Ace), false };
            yield return new object[] { new Card(Suit.Empty, CardValue.Ace), new Card(Suit.Empty, CardValue.Queen), new Card(Suit.Empty, CardValue.Ace), false };
            yield return new object[] { new Card(Suit.Empty, CardValue.Ace), new Card(Suit.Empty, CardValue.King), new Card(Suit.Empty, CardValue.Ace), false };

            yield return new object[] { new Card(Suit.Empty, CardValue.Empty), new Card(Suit.Empty, CardValue.Ace), new Card(Suit.Empty, CardValue.Ace), false };
            yield return new object[] { new Card(Suit.Empty, CardValue.Two),   new Card(Suit.Empty, CardValue.Ace), new Card(Suit.Empty, CardValue.Ace), false };
            yield return new object[] { new Card(Suit.Empty, CardValue.Three), new Card(Suit.Empty, CardValue.Ace), new Card(Suit.Empty, CardValue.Ace), false };
            yield return new object[] { new Card(Suit.Empty, CardValue.Four),  new Card(Suit.Empty, CardValue.Ace), new Card(Suit.Empty, CardValue.Ace), false };
            yield return new object[] { new Card(Suit.Empty, CardValue.Five),  new Card(Suit.Empty, CardValue.Ace), new Card(Suit.Empty, CardValue.Ace), false };
            yield return new object[] { new Card(Suit.Empty, CardValue.Six),   new Card(Suit.Empty, CardValue.Ace), new Card(Suit.Empty, CardValue.Ace), false };
            yield return new object[] { new Card(Suit.Empty, CardValue.Seven), new Card(Suit.Empty, CardValue.Ace), new Card(Suit.Empty, CardValue.Ace), false };
            yield return new object[] { new Card(Suit.Empty, CardValue.Eight), new Card(Suit.Empty, CardValue.Ace), new Card(Suit.Empty, CardValue.Ace), false };
            yield return new object[] { new Card(Suit.Empty, CardValue.Nine),  new Card(Suit.Empty, CardValue.Ace), new Card(Suit.Empty, CardValue.Ace), false };
            yield return new object[] { new Card(Suit.Empty, CardValue.Ten),   new Card(Suit.Empty, CardValue.Ace), new Card(Suit.Empty, CardValue.Ace), false };
            yield return new object[] { new Card(Suit.Empty, CardValue.Jack),  new Card(Suit.Empty, CardValue.Ace), new Card(Suit.Empty, CardValue.Ace), false };
            yield return new object[] { new Card(Suit.Empty, CardValue.Queen), new Card(Suit.Empty, CardValue.Ace), new Card(Suit.Empty, CardValue.Ace), false };
            yield return new object[] { new Card(Suit.Empty, CardValue.King),  new Card(Suit.Empty, CardValue.Ace), new Card(Suit.Empty, CardValue.Ace), false };

            yield return new object[] { new Card(Suit.Empty, CardValue.Empty), new Card(Suit.Empty, CardValue.Empty), null, true };
            yield return new object[] { new Card(Suit.Empty, CardValue.Two), new Card(Suit.Empty, CardValue.Two), null, true };
            yield return new object[] { new Card(Suit.Empty, CardValue.Three), new Card(Suit.Empty, CardValue.Three), null, true };
            yield return new object[] { new Card(Suit.Empty, CardValue.Four), new Card(Suit.Empty, CardValue.Four), null, true };
            yield return new object[] { new Card(Suit.Empty, CardValue.Five), new Card(Suit.Empty, CardValue.Five), null, true };
            yield return new object[] { new Card(Suit.Empty, CardValue.Six), new Card(Suit.Empty, CardValue.Six), null, true };
            yield return new object[] { new Card(Suit.Empty, CardValue.Seven), new Card(Suit.Empty, CardValue.Seven), null, true };
            yield return new object[] { new Card(Suit.Empty, CardValue.Eight), new Card(Suit.Empty, CardValue.Eight), null, true };
            yield return new object[] { new Card(Suit.Empty, CardValue.Nine), new Card(Suit.Empty, CardValue.Nine), null, true };
            yield return new object[] { new Card(Suit.Empty, CardValue.Ten), new Card(Suit.Empty, CardValue.Ten), null, true };
            yield return new object[] { new Card(Suit.Empty, CardValue.Jack), new Card(Suit.Empty, CardValue.Jack), null, true };
            yield return new object[] { new Card(Suit.Empty, CardValue.Queen), new Card(Suit.Empty, CardValue.Queen), null, true };
            yield return new object[] { new Card(Suit.Empty, CardValue.King), new Card(Suit.Empty, CardValue.King), null, true };
            yield return new object[] { new Card(Suit.Empty, CardValue.Ace), new Card(Suit.Empty, CardValue.Ace), null, true };
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
