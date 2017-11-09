using NUnit.Framework;
using TechTalk.SpecFlow;

namespace Hangman.SpecflowTests
{
    [Binding]
    [Scope(Feature = "Hangman" )]
    public class HangmanSteps
    {
        private string _word;
        private HangmanGame _game;
        private string _currentMask;

        //[Given( @"a hangman game with the word ""(.*)""" )]
        //public void GivenAHangmanGameWithTheWord( string word )
        //{
        //    _word = word;
        //}

        [Given( @"a game with the word (.*)" )]
        public void GivenAGameWithTheWord( string word )
        {
            _word = word;
        }

        [Given( @"the mask is currently (.*)" )]
        public void GivenTheMaskIsCurrently(string mask)
        {
            _currentMask = mask;
        }

        [When( @"starting the game" )]
        public void WhenStartingTheGame()
        {
            var target = new HangmanGameService();

            _game = target.NewGame(_word);
        }

        [When( @"guessing (.*)" )]
        public void WhenGuessing(char guess)
        {
            var previousGame = new HangmanGame
            {
                Word = _word,
                Mask = _currentMask
            };

            var target = new HangmanGameService();

            _game = target.Guess(guess, previousGame);
        }

        [Then( @"the mask is (.*)" )]
        public void ThenTheMaskIs( string mask )
        {
            Assert.AreEqual(mask, _game.Mask);
        }
    }
}
