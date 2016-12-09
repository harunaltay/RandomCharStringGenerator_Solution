using System;
using System.Collections.Generic;
using System.Linq;

namespace CharAndStringGenerator
{
    class RandomCharGenerator
    {
        private static Random random = new Random();
        public List<char> ListChar;

        public RandomCharGenerator()
        {
            ListChar = new List<char> { };
        }

        public char GenerateAChar()
        {
            if (this.ListChar.Count == 0)
            {
                throw new Exception("Empty List! First, add at least one character!");
            }

            char c;
            int count;

            count = ListChar.Count;
            c = ListChar[random.Next(count)];

            return c;

            //return ListChar[random.Next(ListChar.Count)];
        }

        public void AddSpecialChars()
        {
            string s = "\" ! ' # + $ % & / { ( [ ) ] = } ? * \\ _ - @ ; , . : < >";
            this.AddAStringOfCharsDelimitedByBlanks(s);
        }

        public void AddAStringOfCharsDelimitedByBlanks(string s)
        {
            Console.WriteLine("s: {0}", s);

            string[] chars = s.Split(' ');

            Console.WriteLine("chars: {0}", chars);

            List<char> ListSpecialChars = new List<char>();

            char c;

            foreach (var item in chars)
            {

                char.TryParse(item, out c);
                Console.WriteLine("item: {0}, c: {1}", item, c);
                ListSpecialChars.Add(c);
            }

            this.ListChar.AddRange(ListSpecialChars);

            int i = 0;
            foreach (var item in ListSpecialChars)
            {
                Console.WriteLine("--> {0}. {1}", ++i, item);
            }
        }

        public void AddTurkishExtraCharsUpper()
        {
            char[] ArrTurkishUpperChars = { 'Ğ', 'Ü', 'Ş', 'İ', 'Ö', 'Ç' };
            List<char> ListTurkishUpperChars = ArrTurkishUpperChars.ToList<char>();
            ListChar.AddRange(ListTurkishUpperChars);
        }

        public void AddTurkishExtraCharsLower()
        {
            char[] ArrTurkishLowerChars = { 'ğ', 'ü', 'ş', 'ı', 'ö', 'ç' };
            List<char> ListTurkishLowerChars = ArrTurkishLowerChars.ToList<char>();
            ListChar.AddRange(ListTurkishLowerChars);
        }

        public void AddEnglishAlphabetCharsUpper()
        {
            this.AddARangeOfChars('A', 'Z');
        }

        public void AddEnglishAlphabetCharsLower()
        {
            this.AddARangeOfChars('a', 'z');
        }

        public void AddDigits()
        {
            this.AddARangeOfChars('0', '9');
        }

        public void AddARangeOfChars(char BeginningChar, char EndingChar)
        {
            char[] ArrOfChars = new char[EndingChar - BeginningChar + 1];

            for (int i = BeginningChar; i <= EndingChar; i++)
            {
                ArrOfChars[i - BeginningChar] = (char)i;
            }

            List<char> ListOfCharsToAdd = ArrOfChars.ToList<char>();

            ListChar.AddRange(ListOfCharsToAdd);
        }

        public static char StaticGenerateACharInARange(char BChar, char EChar)
        {
            return (char)random.Next(BChar, EChar);
        }

        public static char StaticGenerateEnglishUpperCase()
        {
            return StaticGenerateACharInARange('A', 'Z');
        }
        public static char StaticGenerateEnglishLowerCase()
        {
            return StaticGenerateACharInARange('a', 'z');
        }
    }
}