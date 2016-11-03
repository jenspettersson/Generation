namespace Generation.DiceGame
{
    public class LowGuess : IGuess
    {
        private readonly int _guess;
        public int Roll { get; }

        public LowGuess(int guess, int roll)
        {
            Roll = roll;
            _guess = guess;
        }

        public bool Correct => Roll < _guess;
    }
}