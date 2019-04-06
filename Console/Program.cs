using System;
using System.Collections.Generic;
using System.Linq;
using Poker.Data;
using Poker.Interfaces;
using Poker.Logic;

namespace Console
{
    public class Program
    {
        //put filename/path here
        private const string filePath = ".\\input.txt";
        public static void Main(string[] args)
        {
            try
            {
                IPokerLogic poker = new PokerLogic();
                var input = System.IO.File.ReadAllLines(filePath);
                var winner = poker.GetWinnerFromHands(ParsePlayersFromInput(input));

                if (winner != null)
                {
                    System.Console.WriteLine($"{winner.Name} is the winner with a {winner.HandValue} ({winner.HighCard}).");
                }
                else
                {
                    System.Console.WriteLine("Total stalemate of all 5 cards between two or more players.");
                }

                System.Console.ReadKey();
            }
            catch (Exception e)
            {
                System.Console.WriteLine($"Exception [{e.GetType()}] caught.");
                System.Console.WriteLine(e.Message);
            }
        }

        private static List<PlayerHand> ParsePlayersFromInput(IReadOnlyList<string> input)
        {
            var result = new List<PlayerHand>();
            for (var iterator = 0; iterator < input.Count; iterator+=2)
            {
                result.Add(ParsePlayerHandFromInput(input[iterator], input[iterator+1]));
            }

            return result;
        }

        private static PlayerHand ParsePlayerHandFromInput(string player, string cards)
        {
            var handCards = cards.Split(", ");
            return new PlayerHand(player, new Hand(handCards.Select(cardData => new Card(cardData)).ToArray()));
        }
    }
}
