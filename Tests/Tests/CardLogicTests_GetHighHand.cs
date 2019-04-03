using Xunit;
using Poker.Logic;
using Poker.Data;
using System.Collections.Generic;
using System.Collections;

namespace Tests.Tests
{
    public class CardLogicTests_GetHighHand
    {
        [Theory]
        [ClassData(typeof(TestHandHandData))]
        public void HighCardHandIsReturned_WhenPassingTwoUniqueCardHands(Hand handOne, Hand handTwo)
        {
            var logic = new PokerLogic();
            var result = logic.GetHighHand(handOne, handTwo);
            Assert.True(result.Equals(handOne));
        }

        public class TestHandHandData : IEnumerable<object[]>
        {
            public IEnumerator<object[]> GetEnumerator()
            {
                yield return new object[] 
                {
                    new Hand
                    (
                        new Card(Suit.Spades, Value.Ace),
                        new Card(Suit.Clubs, Value.King),
                        new Card(Suit.Diamonds, Value.Queen),
                        new Card(Suit.Diamonds, Value.Two),
                        new Card(Suit.Hearts, Value.Five)
                    ),
                    new Hand
                    (
                        new Card(Suit.Clubs, Value.Two),
                        new Card(Suit.Spades, Value.Three),
                        new Card(Suit.Diamonds, Value.Four),
                        new Card(Suit.Clubs, Value.Ten),
                        new Card(Suit.Hearts, Value.Ten)
                    )
                };
                yield return new object[]
                {
                     new Hand
                     (
                         new Card(Suit.Spades, Value.Three),
                         new Card(Suit.Diamonds, Value.Five),
                         new Card(Suit.Clubs, Value.Three),
                         new Card(Suit.Clubs, Value.Two),
                         new Card(Suit.Hearts, Value.Two)
                     ),
                     new Hand
                     (
                         new Card(Suit.Empty, Value.Two),
                         new Card(Suit.Hearts, Value.Three),
                         new Card(Suit.Diamonds, Value.Two),
                         new Card(Suit.Diamonds, Value.Three),
                         new Card(Suit.Diamonds, Value.Four)
                     )
                };           
            }
            IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
        }
    }
}
