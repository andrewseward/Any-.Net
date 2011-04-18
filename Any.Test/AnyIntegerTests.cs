using System;
using NUnit.Framework;

namespace Any.Test
{
    [TestFixture]
    public class AnyIntegerTests_GivenValidParameters
    {
        private int _minInt;
        private int _maxInt;
        private int _returnedValue;

        [SetUp]
        public void WhenAnyIntegerCalled()
        {
            _minInt = 3;
            _maxInt = 9;

            _returnedValue = Any.Integer(_minInt, _maxInt);
        }
        
        [Test]
        public void ThenReturnedValueIsWithinBounds()
        {
            Assert.That(_returnedValue, Is.InRange(_minInt, _maxInt));
        }
    }

    [TestFixture]
    public class AnyIntegerTests_GivenMinValueGreaterThanMaxValue
    {
        private int _minInt;
        private int _maxInt;

        [SetUp]
        public void WhenAnyIntegerCalled()
        {
            _minInt = 33;
            _maxInt = 5;
        }

        [Test]
        public void ThenArgumentOutOfRangeExceptionIsThrown()
        {
            try
            {
                Any.Integer(_minInt, _maxInt);
                
            }
            catch (ArgumentOutOfRangeException argumentOutOfRangeException)
            {
                Assert.Pass();
            }

            Assert.Fail("Expected exception not thrown");
        }
    }
}
