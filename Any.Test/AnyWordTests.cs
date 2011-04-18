using System;
using NUnit.Framework;
using System.Linq;
namespace Any.Test
{

    public class AnyWordTests_GivenValidCharRangeFixedLength
    {
        private char _minChar;
        private char _maxChar;
        private int _length;
        private string _returnedValue;

        [SetUp]
        public void WhenAnyWordCalled()
        {
            _minChar = 'a';
            _maxChar = 't';
            _length = 6;

            _returnedValue = Any.Word(_length, _minChar, _maxChar);
        }

        [Test]
        public void ThenReturnedCharactersAreWithinBounds()
        {
            Assert.That(_returnedValue.ToCharArray().All(c => c >= _minChar && c <= _maxChar), Is.True);
        }

        [Test]
        public void ThenLengthIsCorrect()
        {
            Assert.That(_returnedValue.Length, Is.EqualTo(_length));
        }
    }

    [TestFixture]
    public class AnyWordTests_GivenCharRangeFixedLengthAndMinValueGreaterThanMaxValue
    {
        private char _minChar;
        private char _maxChar;
        private int _length;

        [SetUp]
        public void WhenAnyWordCalled()
        {
            _minChar = 'u';
            _maxChar = 'b';
            _length = 5;
        }

        [Test]
        public void ThenArgumentOutOfRangeExceptionIsThrown()
        {
            try
            {
                Any.Word(_length, _minChar, _maxChar);

            }
            catch (ArgumentOutOfRangeException argumentOutOfRangeException)
            {
                Assert.Pass();
            }

            Assert.Fail("Expected exception not thrown");
        }
    }

    public class AnyWordTests_GivenValidCharRangeLengthWithinRange
    {
        private char _minChar;
        private char _maxChar;
        private int _minLength;
        private int _maxLength;
        private string _returnedValue;

        [SetUp]
        public void WhenAnyWordCalled()
        {
            _minChar = 'a';
            _maxChar = 't';
            _minLength = 6;
            _maxLength = 12;

            _returnedValue = Any.Word(_minLength, _maxLength, _minChar, _maxChar);
        }

        [Test]
        public void ThenReturnedCharactersAreWithinBounds()
        {
            Assert.That(_returnedValue.ToCharArray().All(c => c >= _minChar && c <= _maxChar), Is.True);
        }

        [Test]
        public void ThenReturnedWordLengthIsWithinBounds()
        {
            Assert.That(_returnedValue.Length, Is.InRange(_minLength, _maxLength));
        }
    }

    public class AnyWordTests_GivenFixedLength
    {
        private char _minChar;
        private char _maxChar;
        private int _length;
        private string _returnedValue;

        [SetUp]
        public void WhenAnyWordCalled()
        {
            _minChar = 'A';
            _maxChar = 'z';
            _length = 12;

            _returnedValue = Any.Word(_length);
        }

        [Test]
        public void ThenReturnedCharactersAreWithinBounds()
        {
            Assert.That(_returnedValue.ToCharArray().All(c => c >= _minChar && c <= _maxChar), Is.True);
        }

        [Test]
        public void ThenLengthIsCorrect()
        {
            Assert.That(_returnedValue.Length, Is.EqualTo(_length));
        }
    }

    public class AnyWordTests_GivenLengthRange
    {
        private char _minChar;
        private char _maxChar;
        private int _minLength;
        private int _maxLength;
        private string _returnedValue;

        [SetUp]
        public void WhenAnyWordCalled()
        {
            _minChar = 'A';
            _maxChar = 'z';
            _minLength = 6;
            _maxLength = 12;

            _returnedValue = Any.Word(_minLength, _maxLength);
        }

        [Test]
        public void ThenReturnedCharactersAreWithinBounds()
        {
            Assert.That(_returnedValue.ToCharArray().All(c => c >= _minChar && c <= _maxChar), Is.True);
        }

        [Test]
        public void ThenReturnedWordLengthIsWithinBounds()
        {
            Assert.That(_returnedValue.Length, Is.InRange(_minLength, _maxLength));
        }
    }
}