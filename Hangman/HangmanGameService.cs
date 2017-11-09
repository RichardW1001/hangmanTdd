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

        public HangmanGame Guess(char guess, HangmanGame game)
        {
            if (game.Word.Contains(guess))
            {
                
            }

            var newMask = "";
            for ( var i = 0; i < game.Word.Length; i++ )
            {
                if ( game.Word[ i ] == guess )
                {
                    newMask += guess;
                }
                else
                {
                    newMask += game.Mask[ i ];
                }
            }

            return new HangmanGame
            {
                Word = game.Word,
                Mask = newMask
            };
        }
    }
}
