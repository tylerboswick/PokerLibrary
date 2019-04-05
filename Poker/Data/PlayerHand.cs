namespace Poker.Data
{
    public class PlayerHand
    {
        private string Name { get; }
        private Hand Cards { get; }
        public PlayerHand(string name, Hand cards)
        {
            Name = name;
            Cards = cards;
        }
    }
}
