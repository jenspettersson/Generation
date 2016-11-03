namespace Generation.DiceGame
{
    public class HighGuess : IGuess
    {
        public int Roll { get; }
        private readonly int _previousRoll;

        public HighGuess(int previousRoll, int roll)
        {
            Roll = roll;
            _previousRoll = previousRoll;
        }

        public bool Correct => Roll > _previousRoll;
    }
}