using NUnit.Framework;

namespace Generation.DiceGame.Tests
{
    [TestFixture]
    public class When_guessing_higher_and_guess_is_incorrect
    {
        private DiceGame _diceGame;

        [SetUp]
        public void SetUp()
        {
            _diceGame = new DiceGame(new FakeDice(6, 1));
            _diceGame.StartGame();
            _diceGame.GuessHigher();
        }

        [Test]
        public void Game_should_not_be_running()
        {
            Assert.False(_diceGame.IsRunning);
        }

        [Test]
        public void Should_set_CurrentRoll_to_new_roll()
        {
            Assert.AreEqual(1, _diceGame.CurrentRoll);
        }

        [Test]
        public void Should_not_increase_Score()
        {
            Assert.AreEqual(0, _diceGame.Score);
        }
    }
}