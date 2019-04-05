using System.Collections;
using System.Collections.Generic;
using Poker.Data;
using Poker.Enums;

namespace Tests.TestParameterObjects
{
    public class Test_PlayerCardEvalData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[]
            {
                new PlayerHand("Test", 
                    new Hand(new Card(Suit.Clubs, CardValue.Ace), 
                            new Card(Suit.Clubs, CardValue.Eight), 
                            new Card(Suit.Clubs, CardValue.Five), 
                            new Card(Suit.Clubs, CardValue.Nine), 
                            new Card(Suit.Clubs, CardValue.King))),
                HandValue.Flush, CardValue.Ace
            };
            yield return new object[]
            {
                new PlayerHand("Test",
                    new Hand(new Card(Suit.Clubs, CardValue.Three),
                        new Card(Suit.Clubs, CardValue.Eight),
                        new Card(Suit.Clubs, CardValue.Five),
                        new Card(Suit.Clubs, CardValue.Nine),
                        new Card(Suit.Clubs, CardValue.Two))),
                HandValue.Flush, CardValue.Nine
            };
            yield return new object[]
            {
                new PlayerHand("Test",
                    new Hand(new Card(Suit.Clubs, CardValue.Three),
                        new Card(Suit.Clubs, CardValue.Seven),
                        new Card(Suit.Diamonds, CardValue.Seven),
                        new Card(Suit.Hearts, CardValue.Seven),
                        new Card(Suit.Hearts, CardValue.Two))),
                HandValue.ThreeOfKind, CardValue.Seven
            };
            yield return new object[]
            {
                new PlayerHand("Test",
                    new Hand(new Card(Suit.Clubs, CardValue.Four),
                        new Card(Suit.Clubs, CardValue.Seven),
                        new Card(Suit.Diamonds, CardValue.Four),
                        new Card(Suit.Hearts, CardValue.Seven),
                        new Card(Suit.Hearts, CardValue.Four))),
                HandValue.ThreeOfKind, CardValue.Four
            };
            yield return new object[]
            {
                new PlayerHand("Test",
                    new Hand(new Card(Suit.Clubs, CardValue.Four),
                        new Card(Suit.Clubs, CardValue.Seven),
                        new Card(Suit.Diamonds, CardValue.Jack),
                        new Card(Suit.Hearts, CardValue.Jack),
                        new Card(Suit.Hearts, CardValue.Six))),
                HandValue.OnePair, CardValue.Jack
            };
            yield return new object[]
            {
                new PlayerHand("Test",
                    new Hand(new Card(Suit.Clubs, CardValue.Four),
                        new Card(Suit.Clubs, CardValue.Seven),
                        new Card(Suit.Diamonds, CardValue.Jack),
                        new Card(Suit.Hearts, CardValue.Jack),
                        new Card(Suit.Hearts, CardValue.Seven))),
                HandValue.OnePair, CardValue.Jack
            };
            yield return new object[]
            {
                new PlayerHand("Test",
                    new Hand(new Card(Suit.Clubs, CardValue.Four),
                        new Card(Suit.Clubs, CardValue.Seven),
                        new Card(Suit.Diamonds, CardValue.Jack),
                        new Card(Suit.Hearts, CardValue.Queen),
                        new Card(Suit.Hearts, CardValue.Six))),
                HandValue.HighCard, CardValue.Queen
            };
            yield return new object[]
            {
                new PlayerHand("Test",
                    new Hand(new Card(Suit.Clubs, CardValue.Four),
                        new Card(Suit.Clubs, CardValue.Ace),
                        new Card(Suit.Diamonds, CardValue.Jack),
                        new Card(Suit.Hearts, CardValue.Queen),
                        new Card(Suit.Hearts, CardValue.Six))),
                HandValue.HighCard, CardValue.Ace
            };
        }
        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
