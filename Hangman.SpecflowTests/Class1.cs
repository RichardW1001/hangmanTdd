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

        [Given( @"a hangman game with the word ""(.*)""" )]
        public void GivenAHangmanGameWithTheWord( string word )
        {
            _word = word;
        }

        [When( @"starting the game" )]
        public void WhenStartingTheGame()
        {
            var target = new HangmanGameService();

            _game = target.NewGame(_word);
        }

        [Then( @"the mask is ""(.*)""" )]
        public void ThenTheMaskIs( string mask )
        {
            Assert.AreEqual(mask, _game.Mask);
        }
    }
}
