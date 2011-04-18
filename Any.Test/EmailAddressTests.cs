using NUnit.Framework;

namespace Any.Test
{
    [TestFixture]
    public class EmailAddressTests_GivenNoParameters
    {
         private string _returnedValue;
        [SetUp]
        public void WhenEmailAddressIsCalled()
        {
            _returnedValue = Any.EmailAddress();
        }

        [Test]
        public void ThenReturnedValueIsValid()
        {
            Assert.That(_returnedValue, Is.StringMatching(@"^(\w+\.|)*(\w+)(@)(\w+\.|)*(\w+)(\.com|\.co\.uk|\.org|\.org\.uk|\.net|\.us|\.com\.au|\.es|\.fr|\.de|\.ly|\.gov|\.gov\.uk|\.ac\.uk)$"));

        }

    }
}