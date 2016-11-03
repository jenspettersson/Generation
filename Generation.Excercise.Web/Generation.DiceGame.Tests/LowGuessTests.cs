using NUnit.Framework;

namespace Generation.DiceGame.Tests
{
    [TestFixture]
    public class LowGuessTests
    {
        [Test]
        public void If_new_roll_is_lower_than_previous_roll_it_should_be_correct()
        {
            int previousRoll = 6;
            int newRoll = 1;
            var lowGuess = new LowGuess(previousRoll, newRoll);
            Assert.True(lowGuess.Correct);
        }

        [Test]
        public void If_new_roll_is_higher_than_previous_roll_it_should_not_be_correct()
        {
            int previousRoll = 1;
            int newRoll = 6;
            var guess = new LowGuess(previousRoll, newRoll);
            Assert.False(guess.Correct);
        }
    }
}