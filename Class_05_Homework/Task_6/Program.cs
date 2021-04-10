using System;

namespace Task_6
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create a function to check whether a character is an alphabet or not and if so, go to check for the case (upper or lower).

            CheckAplhabet('S');
            CheckAplhabet('s');
            CheckAplhabet('@');
        }
        static void CheckAplhabet(char character)
        {
            if (Char.IsLetter(character))
            {
                if (Char.IsLower(character))
                {
                    Console.WriteLine($"The character {character} is a letter in the alphabet and it's lower case");
                }
                else
                {
                    Console.WriteLine($"The character {character} is letter in the alphabet and it's upper case");
                }
            }
            else
            {
                Console.WriteLine("This character is not an alphabet letter");
            }
            Console.ReadLine();
        }
    }
}
