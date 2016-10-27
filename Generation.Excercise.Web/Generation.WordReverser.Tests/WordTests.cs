using NUnit.Framework;

namespace Generation.WordReverser.Tests
{
    [TestFixture]
    public class WordTests
    {
        [Test]
        public void Should_reverse_given_word()
        {
            var reversed = new Word("hello").Reversed;
            Assert.AreEqual("olleh", reversed);
        }

        [Test]
        public void Should_keep_uppercase_positions()
        {
            var reversed = new Word("Hello").Reversed;
            Assert.AreEqual("Olleh", reversed);
        }

        [Test]
        public void All_upper_case_should_return_all_uppercase()
        {
            var reversed = new Word("HELLO").Reversed;
            Assert.AreEqual("OLLEH", reversed);
        }
    }
}