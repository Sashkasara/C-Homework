using System;

namespace Tasl_4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create two functions that calculates the amount of numeric digits and vowels(samoglaski) that a text string contains.
            // It will accept one parameter parameter: the string that we want to search,
            //Function 1 should return the number of digits, function 2 should return the number of vowels.Do not name them function1 and 2 :)


            string sentence = "Hello2 there34";
            Console.WriteLine($"The sentance {sentence} has {numberOfDigits(sentence)} numbers and {numberOfVowels(sentence)} vowels");
        }
        static int numberOfDigits(string str)
        {
            int digits = 0;
            foreach (char character in str)
            {
                string characterr = character.ToString();
                bool isValidDigit = int.TryParse(characterr, out int n);
                if (isValidDigit)
                {
                    digits++;
                }
            }
            return digits;
        }
        static int numberOfVowels(string str)
        {
            int i = 0;
            foreach (char character in str)
            {
                if (character == 'a' || character == 'e' || character == 'i' || character == 'o' || character == 'u')
                {
                    i++;
                }
            }

            return i;
        }
    }
}
