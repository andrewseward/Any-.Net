using System;
using NUnit.Framework;

namespace AnyData.Test
{
    [TestFixture]
    public class AnyDecimalTests_GivenValidParameters
    {
        private decimal _minValue;
        private decimal _maxValue;
        private int _decimalPlaces;
        private decimal _returnedValue;

        [SetUp]
        public void WhenAnyDecimalCalled()
        {
            _minValue = 0.5m;
            _maxValue = 2.6m;
            _decimalPlaces = 2;

            _returnedValue = Any.Decimal(_minValue, _maxValue, _decimalPlaces);
        }

        [Test]
        public void ThenReturnedValueIsWithinBounds()
        {
            Assert.That(_returnedValue, Is.InRange(_minValue, _maxValue));
        }
    }

    [TestFixture]
    public class AnyDecimalTests_GivenMinValueGreaterThanMaxValue
    {
        private decimal _minValue;
        private decimal _maxValue;
        private int _decimalPlaces;

        [SetUp]
        public void WhenAnyDecimalCalled()
        {
            _minValue = 34.33m;
            _maxValue = 5.6m;
            _decimalPlaces = 2;
        }

        [Test]
        public void ThenArgumentOutOfRangeExceptionIsThrown()
        {
            try
            {
                Any.Decimal(_minValue, _maxValue, _decimalPlaces);

            }
            catch (ArgumentOutOfRangeException argumentOutOfRangeException)
            {
                Assert.Pass();
            }

            Assert.Fail("Expected exception not thrown");
        }
    }
}