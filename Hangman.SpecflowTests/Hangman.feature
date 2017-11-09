Feature: Hangman

Scenario: The initial word is masked
Given a game with the word hangman
When starting the game
Then the mask is _______

Scenario: Guessing a letter that appears once reveals that letter
Given a game with the word hangman
And the mask is currently _______
When guessing m
Then the mask is ____m__