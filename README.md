# PokerLibrary

## Assumptions
- There is only one standard deck with 52 cards (4 of each kind).  Therefore there will not be 2 3-of-a-kinds with the same value.
- Three of a kind IS NOT a pair.  You wouldn't say you only have a pair, when you actually have 3 of a kind.
- Shared microsoft LINQ libraries are already unit test covered.
- Input textfile contains one game per file.
- Input is formatted with playername on first line, player hand on next line.
- Playerhand input is in the form of cardvalue+cardsuit, comma and space delimited. ex. 8D, 10H, AS, 2C, 4H
- All players have unique names for win reporting scenarios
