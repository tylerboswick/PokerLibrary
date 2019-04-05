using System.Collections;
using System.Collections.Generic;
using Poker.Data;
using Poker.Enums;

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
                    new Card(Suit.Hearts, CardValue.Empty),
                    new Card(Suit.Hearts, CardValue.Empty),
                    new Card(Suit.Hearts, CardValue.Empty),
                    new Card(Suit.Hearts, CardValue.Empty),
                    new Card(Suit.Hearts, CardValue.Empty)
                ),
                true
            };
            yield return new object[]
            {
                new Hand(
                    new Card(Suit.Spades, CardValue.Empty),
                    new Card(Suit.Spades, CardValue.Empty),
                    new Card(Suit.Spades, CardValue.Empty),
                    new Card(Suit.Spades, CardValue.Empty),
                    new Card(Suit.Spades, CardValue.Empty)
                ),
                true
            };
            yield return new object[]
            {
                new Hand(
                    new Card(Suit.Clubs, CardValue.Empty),
                    new Card(Suit.Clubs, CardValue.Empty),
                    new Card(Suit.Clubs, CardValue.Empty),
                    new Card(Suit.Clubs, CardValue.Empty),
                    new Card(Suit.Clubs, CardValue.Empty)
                ),
                true
            };
            yield return new object[]
            {
                new Hand(
                    new Card(Suit.Diamonds, CardValue.Empty),
                    new Card(Suit.Diamonds, CardValue.Empty),
                    new Card(Suit.Diamonds, CardValue.Empty),
                    new Card(Suit.Diamonds, CardValue.Empty),
                    new Card(Suit.Diamonds, CardValue.Empty)
                ),
                true
            };
            yield return new object[]
            {
                new Hand(
                    new Card(Suit.Diamonds, CardValue.Empty),
                    new Card(Suit.Hearts, CardValue.Empty),
                    new Card(Suit.Hearts, CardValue.Empty),
                    new Card(Suit.Hearts, CardValue.Empty),
                    new Card(Suit.Hearts, CardValue.Empty)
                ),
                false
            };
            yield return new object[]
            {
                new Hand(
                    new Card(Suit.Hearts, CardValue.Empty),
                    new Card(Suit.Diamonds, CardValue.Empty),
                    new Card(Suit.Hearts, CardValue.Empty),
                    new Card(Suit.Hearts, CardValue.Empty),
                    new Card(Suit.Hearts, CardValue.Empty)
                ),
                false
            };
            yield return new object[]
            {
                new Hand(
                    new Card(Suit.Hearts, CardValue.Empty),
                    new Card(Suit.Hearts, CardValue.Empty),
                    new Card(Suit.Diamonds, CardValue.Empty),
                    new Card(Suit.Hearts, CardValue.Empty),
                    new Card(Suit.Hearts, CardValue.Empty)
                ),
                false
            };
            yield return new object[]
            {
                new Hand(
                    new Card(Suit.Hearts, CardValue.Empty),
                    new Card(Suit.Hearts, CardValue.Empty),
                    new Card(Suit.Hearts, CardValue.Empty),
                    new Card(Suit.Diamonds, CardValue.Empty),
                    new Card(Suit.Hearts, CardValue.Empty)
                ),
                false
            };
            yield return new object[]
            {
                new Hand(
                    new Card(Suit.Hearts, CardValue.Empty),
                    new Card(Suit.Hearts, CardValue.Empty),
                    new Card(Suit.Hearts, CardValue.Empty),
                    new Card(Suit.Hearts, CardValue.Empty),
                    new Card(Suit.Diamonds, CardValue.Empty)
                ),
                false
            };
            yield return new object[]
            {
                new Hand(
                    new Card(Suit.Spades, CardValue.Empty),
                    new Card(Suit.Hearts, CardValue.Empty),
                    new Card(Suit.Clubs, CardValue.Empty),
                    new Card(Suit.Diamonds, CardValue.Empty),
                    new Card(Suit.Spades, CardValue.Empty)
                ),
                false
            };
            yield return new object[]
            {
                new Hand(
                    new Card(Suit.Hearts, CardValue.Two),
                    new Card(Suit.Hearts, CardValue.Three),
                    new Card(Suit.Hearts, CardValue.Ten),
                    new Card(Suit.Hearts, CardValue.Jack),
                    new Card(Suit.Hearts, CardValue.Ace)
                ),
                true
            };
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}