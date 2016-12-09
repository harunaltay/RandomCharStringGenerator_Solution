using System;
using System.IO;

namespace CharAndStringGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            //CharGenSampleRun();
            CharGenCheckUp();
            //StringGenSmapleRun();
            //FromFileSampleRun();
        }

        private static void FromFileSampleRun()
        {
            Console.WriteLine("Hello Input from Files");

            string[] AnAlphabetStringArray = File.ReadAllLines("..\\..\\files\\SomeAlphabet.txt");
            string AnAlphabetAString = "";

            foreach (var item in AnAlphabetStringArray)
            {
                Console.WriteLine(item);
                AnAlphabetAString += item + " ";
            }

            AnAlphabetAString = AnAlphabetAString.Trim();
            Console.WriteLine("The String: '{0}'", AnAlphabetAString);
            //--------------------------------------------------------

            RandomStringGenerator StringGenerator = new RandomStringGenerator();

            StringGenerator.CharGen.AddAStringOfCharsDelimitedByBlanks(AnAlphabetAString);

            string s = StringGenerator.GenerateAString(50);
            Console.WriteLine("String Generated: {0}", s);
        }

        private static void StringGenSmapleRun()
        {
            RandomStringGenerator StringGenerator = new RandomStringGenerator();

            StringGenerator.CharGen.AddTurkishExtraCharsUpper();

            string s = StringGenerator.GenerateAString(50);
            Console.WriteLine("String Generated: {0}", s);
        }

        private static void CharGenCheckUp()
        {
            Random random = new Random();

            RandomCharGenerator CharGenerator = new RandomCharGenerator();
            CharGenerator.AddTurkishExtraCharsUpper();
            CharGenerator.AddTurkishExtraCharsLower();
            CharGenerator.AddEnglishAlphabetCharsUpper();
            CharGenerator.AddEnglishAlphabetCharsLower();
            CharGenerator.AddDigits();

            int count = CharGenerator.ListChar.Count;

            Console.WriteLine("count: {0}", count);

            //foreach (var item in CharGenerator.ListChar)
            //{
            //    Console.WriteLine("item: {0}", item);
            //}

            char[] ArrChar = new char[count];
            char c;
            int j;

            for (int i = 0; i < 100000; i++)
            {
                j = random.Next(count);
                c = CharGenerator.ListChar[j];
                ArrChar[j]++;

                //Console.WriteLine("ii: {0}, c: {1}", ii, c);
            }

            j = 0;
            foreach (var item in ArrChar)
            {
                Console.WriteLine("{0}. {1} --> {2}", j + 1, CharGenerator.ListChar[j], (int)item);
                j++;
            }
        }

        private static void CharGenSampleRun()
        {
            RandomCharGenerator CharGenerator = new RandomCharGenerator();
            //CharGenerator.AddTurkishExtraCharsUpper();
            //CharGenerator.AddTurkishExtraCharsLower();
            //CharGenerator.AddEnglishAlphabetCharsUpper();
            //CharGenerator.AddEnglishAlphabetCharsLower();
            CharGenerator.AddDigits();
            //CharGenerator.AddSpecialChars();

            string MoreSpecialChars = "é ^ | € ¨ ~ ´ `";
            CharGenerator.AddAStringOfCharsDelimitedByBlanks(MoreSpecialChars);

            string SwedishAlphabet = "A B C";
            CharGenerator.AddAStringOfCharsDelimitedByBlanks(SwedishAlphabet);

            for (int i = 0; i < 50; i++)
            {
                Console.WriteLine("Generated Random Char: " + CharGenerator.GenerateAChar());
            }
        }
    }
}