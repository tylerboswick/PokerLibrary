# PokerLibrary

## Assumptions
- Three of a kind IS NOT a pair.  You wouldn't say you only have a pair, when you actually have 3 of a kind.
- Shared microsoft LINQ libraries are already unit test covered.
- Input textfile contains one game per file.
- Input is formatted with playername on first line, player hand on next line.
- Playerhand input is in the form of cardvalue+cardsuit, comma and space delimited. ex. 8D, 10H, AS, 2C, 4H
