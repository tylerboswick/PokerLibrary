using System.Collections;
using System.Collections.Generic;
using Poker.Data;

namespace Tests.TestParameterObjects
{
    //Test Data Input for CardLogicTests.GetHighCardFromHand_HighCardIsReturned_WhenPassingHandWithUniqueCardValues
    public class Test_FlushHandData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[] {new Hand(), true};
            yield return new object[]
            {
                new Hand(
                    new Card(Suit.Hearts, Value.Empty),
                    new Card(Suit.Hearts, Value.Empty),
                    new Card(Suit.Hearts, Value.Empty),
                    new Card(Suit.Hearts, Value.Empty),
                    new Card(Suit.Hearts, Value.Empty)
                ),
                true
            };
            yield return new object[]
            {
                new Hand(
                    new Card(Suit.Spades, Value.Empty),
                    new Card(Suit.Spades, Value.Empty),
                    new Card(Suit.Spades, Value.Empty),
                    new Card(Suit.Spades, Value.Empty),
                    new Card(Suit.Spades, Value.Empty)
                ),
                true
            };
            yield return new object[]
            {
                new Hand(
                    new Card(Suit.Clubs, Value.Empty),
                    new Card(Suit.Clubs, Value.Empty),
                    new Card(Suit.Clubs, Value.Empty),
                    new Card(Suit.Clubs, Value.Empty),
                    new Card(Suit.Clubs, Value.Empty)
                ),
                true
            };
            yield return new object[]
            {
                new Hand(
                    new Card(Suit.Diamonds, Value.Empty),
                    new Card(Suit.Diamonds, Value.Empty),
                    new Card(Suit.Diamonds, Value.Empty),
                    new Card(Suit.Diamonds, Value.Empty),
                    new Card(Suit.Diamonds, Value.Empty)
                ),
                true
            };
            yield return new object[]
            {
                new Hand(
                    new Card(Suit.Diamonds, Value.Empty),
                    new Card(Suit.Hearts, Value.Empty),
                    new Card(Suit.Hearts, Value.Empty),
                    new Card(Suit.Hearts, Value.Empty),
                    new Card(Suit.Hearts, Value.Empty)
                ),
                false
            };
            yield return new object[]
            {
                new Hand(
                    new Card(Suit.Hearts, Value.Empty),
                    new Card(Suit.Diamonds, Value.Empty),
                    new Card(Suit.Hearts, Value.Empty),
                    new Card(Suit.Hearts, Value.Empty),
                    new Card(Suit.Hearts, Value.Empty)
                ),
                false
            };
            yield return new object[]
            {
                new Hand(
                    new Card(Suit.Hearts, Value.Empty),
                    new Card(Suit.Hearts, Value.Empty),
                    new Card(Suit.Diamonds, Value.Empty),
                    new Card(Suit.Hearts, Value.Empty),
                    new Card(Suit.Hearts, Value.Empty)
                ),
                false
            };
            yield return new object[]
            {
                new Hand(
                    new Card(Suit.Hearts, Value.Empty),
                    new Card(Suit.Hearts, Value.Empty),
                    new Card(Suit.Hearts, Value.Empty),
                    new Card(Suit.Diamonds, Value.Empty),
                    new Card(Suit.Hearts, Value.Empty)
                ),
                false
            };
            yield return new object[]
            {
                new Hand(
                    new Card(Suit.Hearts, Value.Empty),
                    new Card(Suit.Hearts, Value.Empty),
                    new Card(Suit.Hearts, Value.Empty),
                    new Card(Suit.Hearts, Value.Empty),
                    new Card(Suit.Diamonds, Value.Empty)
                ),
                false
            };
            yield return new object[]
            {
                new Hand(
                    new Card(Suit.Spades, Value.Empty),
                    new Card(Suit.Hearts, Value.Empty),
                    new Card(Suit.Clubs, Value.Empty),
                    new Card(Suit.Diamonds, Value.Empty),
                    new Card(Suit.Spades, Value.Empty)
                ),
                false
            };
            yield return new object[]
            {
                new Hand(
                    new Card(Suit.Hearts, Value.Two),
                    new Card(Suit.Hearts, Value.Three),
                    new Card(Suit.Hearts, Value.Ten),
                    new Card(Suit.Hearts, Value.Jack),
                    new Card(Suit.Hearts, Value.Ace)
                ),
                true
            };
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}