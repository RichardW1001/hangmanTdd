using NUnit.Framework;

namespace Hangman.NUnitTests
{
    [TestFixture]
    public class HangmanTests
    {
        [Test]
        public void TheInitialWordIsMasked()
        {
            var target = new HangmanGameService();

            var game = target.NewGame("Hangman");

            Assert.AreEqual("_______", game.Mask);
        }
    }
}