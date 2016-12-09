using System;

namespace CharAndStringGenerator
{
    class RandomStringGenerator
    {
        public RandomCharGenerator CharGen;

        public RandomStringGenerator()
        {
            CharGen = new RandomCharGenerator();
            Console.WriteLine("Hello from StringGen!");
        }

        public string GenerateAString(int v)
        {
            string s = "";

            for (int i = 0; i < v; i++)
            {
                s += CharGen.GenerateAChar();
            }

            return s;
        }
    }
}