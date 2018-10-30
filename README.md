# Snakes and ladders

Implementation of the Snakes and ladders [kata](http://agilekatas.co.uk/katas/SnakesAndLadders-Kata)

# Run the tests
Run the following commands:
`dotnet test`

# Comments
I haven't implemented the check that the dice returns a value between 1 and 6. The reason is that I didn't have any test that demands it, and that, at the end, is testing that the .Net framework is creating a random number correctly.

It's somehow difficult to differentiate between player and token. I've chosen token because that's the word that appears in the kata definition, so I assume is correct in our domain.