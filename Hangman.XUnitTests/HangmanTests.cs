using Xunit;

namespace Hangman.XUnitTests
{
    
    public class HangmanTests
    {
        [Fact]
        public void TheInitialWordIsMasked()
        {
            var target = new HangmanGameService();

            var game = target.NewGame("Hangman");

            Assert.Equal("_______", game.Mask);
        }
    }
}