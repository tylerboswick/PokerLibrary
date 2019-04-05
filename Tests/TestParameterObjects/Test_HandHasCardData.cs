using System.Collections;
using System.Collections.Generic;
using Poker.Data;

namespace Tests.TestParameterObjects
{
    //Test Data Input for HandTests.HandHasCard_ReturnsTrue_IfCardInHand
    public class Test_HandHasCardData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[] { new Hand(), new Card(), true };
            yield return new object[]
            {
                new Hand
                (
                    new Card(Suit.Spades, Value.Ace),
                    new Card(Suit.Clubs, Value.Ace),
                    new Card(Suit.Hearts, Value.Ace),
                    new Card(Suit.Hearts, Value.Eight),
                    new Card(Suit.Spades, Value.Jack)
                ),
                new Card(Suit.Spades, Value.Ace), true
            };
            yield return new object[]
            {
                new Hand
                (
                    new Card(Suit.Spades, Value.Ace),
                    new Card(Suit.Clubs, Value.Ace),
                    new Card(Suit.Hearts, Value.Ace),
                    new Card(Suit.Hearts, Value.Eight),
                    new Card(Suit.Spades, Value.Jack)
                ),
                new Card(Suit.Clubs, Value.Ace), true
            };
            yield return new object[]
            {
                new Hand
                (
                    new Card(Suit.Spades, Value.Ace),
                    new Card(Suit.Clubs, Value.Ace),
                    new Card(Suit.Hearts, Value.Ace),
                    new Card(Suit.Hearts, Value.Eight),
                    new Card(Suit.Spades, Value.Jack)
                ),
                new Card(Suit.Hearts, Value.Ace), true
            };
            yield return new object[]
            {
                new Hand
                (
                    new Card(Suit.Spades, Value.Ace),
                    new Card(Suit.Clubs, Value.Ace),
                    new Card(Suit.Hearts, Value.Ace),
                    new Card(Suit.Hearts, Value.Eight),
                    new Card(Suit.Spades, Value.Jack)
                ),
                new Card(Suit.Hearts, Value.Eight), true
            };
            yield return new object[]
            {
                new Hand
                (
                    new Card(Suit.Spades, Value.Ace),
                    new Card(Suit.Clubs, Value.Ace),
                    new Card(Suit.Hearts, Value.Ace),
                    new Card(Suit.Hearts, Value.Eight),
                    new Card(Suit.Spades, Value.Jack)
                ),
                new Card(Suit.Spades, Value.Jack), true
            };
            yield return new object[] { new Hand(), new Card(Suit.Spades, Value.Ace), false };
            yield return new object[]
            {
                new Hand
                (
                    new Card(Suit.Clubs, Value.Ace),
                    new Card(Suit.Hearts, Value.Ace),
                    new Card(Suit.Diamonds, Value.Ace),
                    new Card(Suit.Empty, Value.Ace),
                    new Card(Suit.Diamonds, Value.King)
                ),
                new Card(Suit.Spades, Value.Ace), false
            };
            yield return new object[]
            {
                new Hand
                (
                    new Card(Suit.Spades, Value.Two),
                    new Card(Suit.Spades, Value.Three),
                    new Card(Suit.Spades, Value.Four),
                    new Card(Suit.Spades, Value.Five),
                    new Card(Suit.Spades, Value.Six)
                ),
                new Card(Suit.Spades, Value.Ace), false
            };
        }
        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }

}
