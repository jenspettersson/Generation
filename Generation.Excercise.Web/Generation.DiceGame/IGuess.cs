namespace Generation.DiceGame
{
    public interface IGuess
    {
        int Roll { get; }
        bool Correct { get; }
    }
}