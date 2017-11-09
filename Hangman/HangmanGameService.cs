using System;
using System.Linq;

namespace Hangman
{
    public class HangmanGameService
    {
        public HangmanGame NewGame(string word)
        {
            var mask = string.Join("", Enumerable.Range(0, word.Length).Select(_ => "_"));

            return new HangmanGame
            {
                Mask = mask,
                Word = word
            };
        }
    }
}
