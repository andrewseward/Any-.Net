using System;
using NUnit.Framework;

namespace Any.Test
{

    [TestFixture]
    public class AnyCharacterTests_GivenNoParameters
    {
        private char _minValue;
        private char _maxValue;
        private char _returnedValue;

        [SetUp]
        public void WhenAnyCharacterCalled()
        {
            _minValue = 'A';
            _maxValue = 'z';

            _returnedValue = Any.Character();
        }

        [Test]
        public void ThenReturnedValueIsWithinBounds()
        {
            Assert.That(_returnedValue, Is.InRange(_minValue, _maxValue));
        }
    }

    [TestFixture]
    public class AnyCharacterTests_GivenValidParameters
    {
        private char _minValue;
        private char _maxValue;
        private char _returnedValue;

        [SetUp]
        public void WhenAnyCharacterCalled()
        {
            _minValue = 'd';
            _maxValue = 'x';

            _returnedValue = Any.Character(_minValue, _maxValue);
        }

        [Test]
        public void ThenReturnedValueIsWithinBounds()
        {
            Assert.That(_returnedValue, Is.InRange(_minValue, _maxValue));
        }
    }

    [TestFixture]
    public class AnyCharacterTests_GivenMinValueGreaterThanMaxValue
    {
        private char _minValue;
        private char _maxValue;

        [SetUp]
        public void WhenAnyCharacterCalled()
        {
            _minValue = 'z';
            _maxValue = 'h';
        }

        [Test]
        public void ThenArgumentOutOfRangeExceptionIsThrown()
        {
            try
            {
                Any.Character(_minValue, _maxValue);

            }
            catch (ArgumentOutOfRangeException argumentOutOfRangeException)
            {
                Assert.Pass();
            }

            Assert.Fail("Expected exception not thrown");
        }
    }
}

