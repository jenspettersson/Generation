using System.Collections.Generic;
using System.Linq;

namespace Generation.DiceGame.Tests
{
    public class FakeDice : IDice
    {
        private readonly Stack<int> _stack;

        public FakeDice(params int[] rolls)
        {
            _stack = new Stack<int>(rolls.Reverse());
        }

        public int Roll()
        {
            return _stack.Pop();
        }
    }
}