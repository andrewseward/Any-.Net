using NUnit.Framework;

namespace AnyData.Test
{
    [TestFixture]
    public class UrlHostnameWithNoSubdomainTests_GivenNoParameters
    {
        private string _returnedValue;
        [SetUp]
        public void WhenUrlHostnameWithNoSubdomainIsCalled()
        {
            _returnedValue = Any.UrlHostnameWithNoSubdomain();

        }

        [Test]
        public void ValidUrlIsReturned()
        {
            Assert.That(_returnedValue, Is.StringMatching(@"^(\w+)(\.com|\.co\.uk|\.org|\.org\.uk|\.net|\.us|\.com\.au|\.es|\.fr|\.de|\.ly|\.gov|\.gov\.uk|\.ac\.uk)(\/|)$"));

        }
    }

    [TestFixture]
    public class UrlHostnameWithNoProtocolTests_GivenNoParameters
    {
        private string _returnedValue;
        [SetUp]
        public void WhenUrlHostnameWithNoProtocolIsCalled()
        {
            _returnedValue = Any.UrlHostnameWithNoProtocol();

        }

        [Test]
        public void ValidValueIsReturned()
        {
            Assert.That(_returnedValue, Is.StringMatching(@"^(\w+\.|)(\w+)(\.com|\.co\.uk|\.org|\.org\.uk|\.net|\.us|\.com\.au|\.es|\.fr|\.de|\.ly|\.gov|\.gov\.uk|\.ac\.uk)(\/|)$"));

        }
    }

    [TestFixture]
    public class UrlHostnameTests_GivenNoParameters
    {
        private string _returnedValue;
        [SetUp]
        public void WhenUrlHostnameIsCalled()
        {
            _returnedValue = Any.UrlHostname();

        }

        [Test]
        public void ValidValueIsReturned()
        {
            Assert.That(_returnedValue, Is.StringMatching(@"^(http:\/\/)(\w+\.|)(\w+)(\.com|\.co\.uk|\.org|\.org\.uk|\.net|\.us|\.com\.au|\.es|\.fr|\.de|\.ly|\.gov|\.gov\.uk|\.ac\.uk)(\/|)$"));

        }
    }

    [TestFixture]
    public class UrlTests_GivenNoParameters
    {
        private string _returnedValue;
        [SetUp]
        public void WhenUrlIsCalled()
        {
            _returnedValue = Any.Url();

        }

        [Test]
        public void ValidValueIsReturned()
        {
            Assert.That(_returnedValue, Is.StringMatching(@"^(http:\/\/)(\w+\.|)(\w+)(\.com|\.co\.uk|\.org|\.org\.uk|\.net|\.us|\.com\.au|\.es|\.fr|\.de|\.ly|\.gov|\.gov\.uk|\.ac\.uk)(\/)(\w+\/)*(\w+|)$"));

        }
    }

    [TestFixture]
    public class UrlPartTests_GivenNoParameters
    {
        private string _returnedValue;
        [SetUp]
        public void WhenUrlPartIsCalled()
        {
            _returnedValue = Any.UrlPart();

        }

        [Test]
        public void ValidValueIsReturned()
        {
            Assert.That(_returnedValue, Is.StringMatching(@"^(\/\w+)$"));

        }
    }

    [TestFixture]
    public class RelativeUrlTests_GivenNoParameters
    {
        private string _returnedValue;
        [SetUp]
        public void WhenRelativeUrlIsCalled()
        {
            _returnedValue = Any.RelativeUrl();

        }

        [Test]
        public void ValidValueIsReturned()
        {
            Assert.That(_returnedValue, Is.StringMatching(@"^(\/)(\w+\/)*(\w+|)$"));

        }
    }
}