Feature: Hangman

@newGame @hangman
Scenario: The initial word is masked
Given a hangman game with the word "hangman"
When starting the game
Then the mask is "_______"
