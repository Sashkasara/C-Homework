using System;

namespace Task_5
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create a function to read a sentence and replace lowercase characters by uppercase and vice-versa.

            string randomSentence = "I wish I was 1km away from Kilimanjaro's peak, out of breath";
            Sentence(randomSentence);
        }
        static void Sentence(string str)
        {
            char[] character = str.ToCharArray();
            for (int i = 0; i < str.Length; i++)
            {
                if (Char.IsLower(character[i]))
                {
                    character[i] = char.ToUpper(character[i]);
                    Console.Write(character[i]);
                }
                else
                {
                    character[i] = char.ToLower(character[i]);
                    Console.Write(character[i]);
                }
            }
        }
    }
}
