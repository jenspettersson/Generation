using System.Linq;

namespace Generation.WordReverser
{
    public class Reverser
    {
        public string Reverse(string text)
        {
            var originalWords = text.Split(' ').Select(w => new Word(w));
            var reversedWords = originalWords.Select(x => x.Reversed);
            return string.Join(" ", reversedWords);
        }
    }
}