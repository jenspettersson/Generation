using NUnit.Framework;

namespace Generation.DiceGame.Tests
{
    [TestFixture]
    public class When_guessing_lower_and_guess_is_correct
    {
        private DiceGame _diceGame;

        [SetUp]
        public void SetUp()
        {
            _diceGame = new DiceGame(new FakeDice(6, 1));
            _diceGame.StartGame();
            _diceGame.GuessLower();
        }

        [Test]
        public void Game_should_still_be_running()
        {
            Assert.True(_diceGame.IsRunning);
        }

        [Test]
        public void Should_set_CurrentRoll_to_new_roll()
        {
            Assert.AreEqual(1, _diceGame.CurrentRoll);
        }

        [Test]
        public void Should_increase_Score()
        {
            Assert.AreEqual(1, _diceGame.Score);
        }
    }
}