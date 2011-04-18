using System;
using System.Text;
using System.Threading;

namespace Any
{
    public class Any
    {
        private const char DefaultMaxCharacter = 'z';
        private const char DefaultMinCharacter = 'A';
        private static readonly string[] DomainExtensions = new string[] { ".com", ".co.uk", ".org", ".org.uk", ".net", ".us", ".com.au", ".es", ".fr", ".de", ".ly", ".gov", ".gov.uk", ".ac.uk"};
        private static readonly Random Random = new Random();
        private static readonly object SyncLock = new object();

        public static int Integer(int minInt, int maxInt)
        {
            lock (SyncLock)
            {
                return Random.Next(minInt, maxInt);
            }
        }

        public static char Character(char minValue, char maxValue)
        {
            return (char) Integer(minValue, maxValue);
        }

        public static char Character()
        {
            return Character(DefaultMinCharacter, DefaultMaxCharacter);
        }

        public static decimal Decimal(decimal minValue, decimal maxValue, int decimalPlaces)
        {
            decimal multiplier = ((decimal) decimalPlaces)*10;
            decimal result = Integer(((int)(minValue*multiplier)), ((int) (maxValue*multiplier)))/multiplier;
            return result;
        }

        public static string Word(int length, char minCharacter, char maxCharacter)
        {
            var word = new StringBuilder(length);
            for(int i= 0; i<length; i++)
            {
                word.Append(Character(minCharacter, maxCharacter));
            }
            return word.ToString();
        }

        public static string Word(int minLength, int maxLength, char minCharacter, char maxCharacter)
        {
            return Word(Integer(minLength, maxLength), minCharacter, maxCharacter);
        }

        public static string Word(int length)
        {
            return Word(length, DefaultMinCharacter, DefaultMaxCharacter);
        }

        public static string Word(int minLength, int maxLength)
        {
            return Word(minLength, maxLength, DefaultMinCharacter, DefaultMaxCharacter);
        }


        public static string Of(params string[] words)
        {
            return words[Integer(0, words.Length - 1)];
        }

        public static string UrlHostnameWithNoSubdomain()
        {
            var url = new StringBuilder();
            url.Append(Word(3, 25, 'a', 'z'));
            url.Append(DomainExtension());
            return url.ToString();
        }

        public static string DomainExtension()
        {
            return Of(DomainExtensions);
        }

        public static string UrlHostnameWithNoProtocol()
        {
            var url = new StringBuilder();
            url.Append(Of("www.", Word(1, 25, 'a', 'z') + ".", ""));
            url.Append(UrlHostnameWithNoSubdomain());
            return url.ToString();
        }

        public static string UrlHostname()
        {
            var url = new StringBuilder();
            url.Append("http://");
            url.Append(UrlHostnameWithNoProtocol());
            return url.ToString();
        }

        public static string Url()
        {
            var url = new StringBuilder();
            url.Append(UrlHostname());
            url.Append(RelativeUrl());
            return url.ToString();
        }

        public static string UrlPart()
        {
            var url = new StringBuilder();
            url.Append("/");
            url.Append(Word(1, 25, 'a', 'z'));
            return url.ToString();
        }

        public static string RelativeUrl()
        {
            var url = new StringBuilder();
            for (int i = 0; i < Integer(1, 10); i++)
            {
                url.Append(UrlPart());
            }
            url.Append("/");
            return url.ToString();
        }

        public static string EmailAddress()
        {
            var emailAddress = new StringBuilder();
            emailAddress.Append(Word(1, 25, 'a', 'z'));
            emailAddress.Append("@");
            emailAddress.Append(Word(1, 25, 'a', 'z'));
            emailAddress.Append(DomainExtension());
            return emailAddress.ToString();
        }
    }
}
