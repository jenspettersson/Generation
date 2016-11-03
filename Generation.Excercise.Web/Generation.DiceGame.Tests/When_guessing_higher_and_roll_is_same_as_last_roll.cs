using NUnit.Framework;

namespace Generation.DiceGame.Tests
{
    [TestFixture]
    public class When_guessing_higher_and_roll_is_same_as_last_roll
    {
        private DiceGame _diceGame;

        [SetUp]
        public void SetUp()
        {
            _diceGame = new DiceGame(new FakeDice(4, 4));
            _diceGame.StartGame();
            _diceGame.GuessHigher();
        }

        [Test]
        public void Game_should_still_be_running()
        {
            Assert.True(_diceGame.IsRunning);
        }

        [Test]
        public void Should_set_CurrentRoll_to_new_roll()
        {
            Assert.AreEqual(4, _diceGame.CurrentRoll);
        }

        [Test]
        public void Should_not_increase_Score()
        {
            Assert.AreEqual(0, _diceGame.Score);
        }
    }
}