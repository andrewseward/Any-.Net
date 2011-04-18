using NUnit.Framework;
using System.Linq;

namespace Any.Test
{
    public class OfTests_GivenListOfWords
    {
        private string[] _words;
        private string _returnedValue;

        [SetUp]
        public void WhenOfIsCalled()
        {
            _words = new string[] {"dog", "cat", "chicken", "baboon", "trifle"};

            _returnedValue = Any.Of(_words);
        }

        [Test]
        public void ThenReturnedValueIsInListOfWords()
        {
            Assert.That(_words.Contains(_returnedValue), Is.True);
        }
    }
}