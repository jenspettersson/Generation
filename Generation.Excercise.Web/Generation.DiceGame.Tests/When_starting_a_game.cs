using NUnit.Framework;

namespace Generation.DiceGame.Tests
{
    [TestFixture]
    public class When_starting_a_game
    {
        private DiceGame _game;

        [SetUp]
        public void SetUp()
        {
            _game = new DiceGame(new FakeDice(1));
            _game.StartGame();
        }

        [Test]
        public void Should_roll_first_dice_and_set_CurrentRoll()
        {
            Assert.AreEqual(1, _game.CurrentRoll);
        }

        [Test]
        public void Should_set_IsRunning()
        {
            Assert.True(_game.IsRunning);
        }

        [Test]
        public void Should_reset_Score()
        {
            Assert.AreEqual(0, _game.Score);
        }
    }
}
