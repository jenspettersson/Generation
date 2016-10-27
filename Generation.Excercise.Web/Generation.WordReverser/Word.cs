using System.Collections.Generic;
using System.Linq;

namespace Generation.WordReverser
{
    public class Word
    {
        public string Original { get; }
        public string Reversed => GetReversedWord();

        public Word(string word)
        {
            Original = word;
        }

        public string GetReversedWord()
        {
            var upperCasePositions = new List<int>();
            for (int i = 0; i < Original.Length; i++)
            {
                if (char.IsUpper(Original[i]))
                    upperCasePositions.Add(i);
            }

            var reveresed = Original.Reverse().ToArray();
            string result = string.Empty;

            for (int i = 0; i < reveresed.Length; i++)
            {
                var current = char.ToLower(reveresed[i]);
                if (upperCasePositions.Contains(i))
                    result += char.ToUpper(current);
                else
                {
                    result += current;
                }
            }

            return result;
        }
    }
}
