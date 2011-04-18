using NUnit.Framework;

namespace Any.Test
{
    [TestFixture]
    public class DomainExtensionTests
    {
        private string _returnedValue;
        [SetUp]
        public void WhenUrlHostnameWithNoSubdomainIsCalled()
        {
            _returnedValue = Any.DomainExtension();

        }

        [Test]
        public void ValidDomainExtensionIsReturned()
        {
            Assert.That(_returnedValue, Is.StringMatching(@"^(\.com|\.co\.uk|\.org|\.org\.uk|\.net|\.us|\.com\.au|\.es|\.fr|\.de|\.ly|\.gov|\.gov\.uk|\.ac\.uk)$"));

        }
    }
}