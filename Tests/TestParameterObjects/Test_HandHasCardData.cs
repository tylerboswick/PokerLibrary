using System.Collections;
using System.Collections.Generic;
using Poker.Data;
using Poker.Enums;

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
                    new Card(Suit.Spades, CardValue.Ace),
                    new Card(Suit.Clubs, CardValue.Ace),
                    new Card(Suit.Hearts, CardValue.Ace),
                    new Card(Suit.Hearts, CardValue.Eight),
                    new Card(Suit.Spades, CardValue.Jack)
                ),
                new Card(Suit.Spades, CardValue.Ace), true
            };
            yield return new object[]
            {
                new Hand
                (
                    new Card(Suit.Spades, CardValue.Ace),
                    new Card(Suit.Clubs, CardValue.Ace),
                    new Card(Suit.Hearts, CardValue.Ace),
                    new Card(Suit.Hearts, CardValue.Eight),
                    new Card(Suit.Spades, CardValue.Jack)
                ),
                new Card(Suit.Clubs, CardValue.Ace), true
            };
            yield return new object[]
            {
                new Hand
                (
                    new Card(Suit.Spades, CardValue.Ace),
                    new Card(Suit.Clubs, CardValue.Ace),
                    new Card(Suit.Hearts, CardValue.Ace),
                    new Card(Suit.Hearts, CardValue.Eight),
                    new Card(Suit.Spades, CardValue.Jack)
                ),
                new Card(Suit.Hearts, CardValue.Ace), true
            };
            yield return new object[]
            {
                new Hand
                (
                    new Card(Suit.Spades, CardValue.Ace),
                    new Card(Suit.Clubs, CardValue.Ace),
                    new Card(Suit.Hearts, CardValue.Ace),
                    new Card(Suit.Hearts, CardValue.Eight),
                    new Card(Suit.Spades, CardValue.Jack)
                ),
                new Card(Suit.Hearts, CardValue.Eight), true
            };
            yield return new object[]
            {
                new Hand
                (
                    new Card(Suit.Spades, CardValue.Ace),
                    new Card(Suit.Clubs, CardValue.Ace),
                    new Card(Suit.Hearts, CardValue.Ace),
                    new Card(Suit.Hearts, CardValue.Eight),
                    new Card(Suit.Spades, CardValue.Jack)
                ),
                new Card(Suit.Spades, CardValue.Jack), true
            };
            yield return new object[] { new Hand(), new Card(Suit.Spades, CardValue.Ace), false };
            yield return new object[]
            {
                new Hand
                (
                    new Card(Suit.Clubs, CardValue.Ace),
                    new Card(Suit.Hearts, CardValue.Ace),
                    new Card(Suit.Diamonds, CardValue.Ace),
                    new Card(Suit.Empty, CardValue.Ace),
                    new Card(Suit.Diamonds, CardValue.King)
                ),
                new Card(Suit.Spades, CardValue.Ace), false
            };
            yield return new object[]
            {
                new Hand
                (
                    new Card(Suit.Spades, CardValue.Two),
                    new Card(Suit.Spades, CardValue.Three),
                    new Card(Suit.Spades, CardValue.Four),
                    new Card(Suit.Spades, CardValue.Five),
                    new Card(Suit.Spades, CardValue.Six)
                ),
                new Card(Suit.Spades, CardValue.Ace), false
            };
        }
        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }

}
