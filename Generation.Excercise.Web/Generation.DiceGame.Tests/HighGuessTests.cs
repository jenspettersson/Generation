using System;
using System.Globalization;
using NUnit.Framework;

namespace Generation.DiceGame.Tests
{
    [TestFixture]
    public class HighGuessTests
    {
        [Test]
        public void If_new_roll_is_higher_than_previous_roll_it_should_be_correct()
        {
            int previousRoll = 1;
            int newRoll = 6;
            var guess = new HighGuess(previousRoll, newRoll);
            Assert.True(guess.Correct);
        }

        [Test]
        public void If_new_roll_is_lower_than_previous_roll_it_should_not_be_correct()
        {
            int previousRoll = 6;
            int newRoll = 1;
            var guess = new HighGuess(previousRoll, newRoll);
            Assert.False(guess.Correct);
        }
    }
}