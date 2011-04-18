using System;
using System.Text;

namespace Any
{
    public class Any
    {
        private const char DefaultMaxCharacter = 'z';
        private const char DefaultMinCharacter = 'A';


        public static int Integer(int minInt, int maxInt)
        {
            var random = new Random();

            return random.Next(minInt, maxInt);
        }

        public static char Character(char minValue, char maxValue)
        {
            return (char) Integer((int) minValue, (int) maxValue);
        }

        public static char Character()
        {
            return Character(DefaultMinCharacter, DefaultMaxCharacter);
        }

        public static decimal Decimal(decimal minValue, decimal maxValue, int decimalPlaces)
        {
            decimal multiplier = ((decimal) decimalPlaces)*10;
            decimal result = ((decimal) Integer(((int)(minValue*multiplier)), ((int) (maxValue*multiplier))))/multiplier;
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

        
    }
}
