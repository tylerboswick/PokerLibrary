using System.Collections;
using System.Collections.Generic;
using Poker.Data;
using Poker.Enums;

namespace Tests.TestParameterObjects
{
    //Test Data Input for HandTests.GetHighestHandFromPlayers_ExpectedIsReturned_WhenPassingTwoDifferentHands
    public class Test_HandCompareHighData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[]
            {
                new PlayerHand("Bob", 
                new Hand
                (
                    new Card(Suit.Hearts, CardValue.Ace),
                    new Card(Suit.Diamonds, CardValue.Five),
                    new Card(Suit.Hearts, CardValue.Ten),
                    new Card(Suit.Hearts, CardValue.Eight),
                    new Card(Suit.Spades, CardValue.Jack)
                )),
                new PlayerHand("Jim",
                new Hand
                (
                    new Card(Suit.Spades, CardValue.Ace),
                    new Card(Suit.Clubs, CardValue.Ace),
                    new Card(Suit.Diamonds, CardValue.Ten),
                    new Card(Suit.Diamonds, CardValue.Eight),
                    new Card(Suit.Clubs, CardValue.Jack)
                )),
                "Jim"
            };
            yield return new object[]
            {
                new PlayerHand("Bob",
                    new Hand
                    (
                        new Card(Suit.Hearts, CardValue.Ace),
                        new Card(Suit.Diamonds, CardValue.Ace),
                        new Card(Suit.Hearts, CardValue.Ten),
                        new Card(Suit.Hearts, CardValue.Eight),
                        new Card(Suit.Spades, CardValue.Jack)
                    )),
                new PlayerHand("Jim",
                    new Hand
                    (
                        new Card(Suit.Spades, CardValue.Ace),
                        new Card(Suit.Clubs, CardValue.Queen),
                        new Card(Suit.Diamonds, CardValue.Ten),
                        new Card(Suit.Diamonds, CardValue.Eight),
                        new Card(Suit.Clubs, CardValue.Jack)
                    )),
                "Bob"
            };
            yield return new object[]
            {
                new PlayerHand("Bob",
                    new Hand
                    (
                        new Card(Suit.Hearts, CardValue.Two),
                        new Card(Suit.Diamonds, CardValue.Four),
                        new Card(Suit.Hearts, CardValue.Ten),
                        new Card(Suit.Hearts, CardValue.Eight),
                        new Card(Suit.Spades, CardValue.Jack)
                    )),
                new PlayerHand("Jim",
                    new Hand
                    (
                        new Card(Suit.Spades, CardValue.Two),
                        new Card(Suit.Clubs, CardValue.Ace),
                        new Card(Suit.Diamonds, CardValue.Ten),
                        new Card(Suit.Diamonds, CardValue.Eight),
                        new Card(Suit.Clubs, CardValue.Jack)
                    )),
                "Jim"
            };

        }
        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }

}
