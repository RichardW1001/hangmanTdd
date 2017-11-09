using Machine.Specifications;

namespace Hangman.MSpecTests
{
    [Subject("Hangman")]
    public class When_starting_a_new_game
    {
        Establish context = () =>
        {
            Subject = new HangmanGameService();
        };

        Because of = () =>
        {
            Result = Subject.NewGame("hangman");
        };

        private It should_mask_the_word = () =>
        {
            Result.Mask.ShouldEqual("_______");
        };

        private static HangmanGameService Subject;
        private static HangmanGame Result;
    }
}
