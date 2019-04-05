using Poker.Enums;

namespace Poker.Helpers
{
    public static class EnumHelpers
    {
        public static CardValue GetValueFromChar(char value)
        {
            switch (value)
            {
                case '2':
                    return CardValue.Two;
                case '3':
                    return CardValue.Three;
                case '4':
                    return CardValue.Four;
                case '5':
                    return CardValue.Five;
                case '6':
                    return CardValue.Six;
                case '7':
                    return CardValue.Seven;
                case '8':
                    return CardValue.Eight;
                case '9':
                    return CardValue.Nine;
                case 'J':
                    return CardValue.Jack;
                case 'Q':
                    return CardValue.Queen;
                case 'K':
                    return CardValue.King;
                case 'A':
                    return CardValue.Ace;
                default:
                    return CardValue.Empty;
            }
        }

        public static Suit GetSuitFromChar(char suit)
        {
            switch (suit)
            {
                case 'C':
                    return Suit.Clubs;
                case 'D':
                    return Suit.Diamonds;
                case 'H':
                    return Suit.Hearts;
                case 'S':
                    return Suit.Spades;
                default:
                    return Suit.Empty;
            }
        }
    }
}
