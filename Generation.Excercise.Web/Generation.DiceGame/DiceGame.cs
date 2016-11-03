using System.Collections.Generic;
using System.Linq;

namespace Generation.DiceGame
{
    public class DiceGame
    {
        private readonly IDice _dice;

        public DiceGame(IDice dice)
        {
            _dice = dice;
            _guesses = new List<IGuess>();
        }

        public void StartGame()
        {
            _guesses.Clear();
            CurrentRoll = _dice.Roll();
        }

        public int CurrentRoll { get; private set; }
        public bool IsRunning => _guesses.All(x => x.Correct);
        public int Score => _guesses.Where(x => x.Correct).Sum(x => 1);

        private readonly List<IGuess> _guesses;

        public bool GuessHigher()
        {
            return Guess(new HighGuess(CurrentRoll, _dice.Roll()));
        }

        public bool GuessLower()
        {
            return Guess(new LowGuess(CurrentRoll, _dice.Roll()));
        }

        private bool Guess(IGuess guess)
        {
            if (guess.Roll == CurrentRoll)
                return false;

            _guesses.Add(guess);
            CurrentRoll = guess.Roll;

            return guess.Correct;
        }
    }
}