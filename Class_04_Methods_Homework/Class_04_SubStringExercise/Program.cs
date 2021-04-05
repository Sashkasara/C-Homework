using System;

namespace Class_04_SubStringExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //In the existing Console Application create  a new method called Substrings
            //●In that method enter the following string :"Hello from SEDC Codecademy 2021"
            //●Ask the user to enter a number n.
            //●Print the first n characters from that string and print the length of the new string.
            //●Try to handle all the scenarios.

            Console.WriteLine("Please enter a number");
            string userInput = Console.ReadLine();
            bool isValidNumber = int.TryParse(userInput, out int number);
            if (isValidNumber)
            {
                string result = Substring("Hello from SEDC Code Academy", number);
                Console.WriteLine(result);
                Console.WriteLine($"The number of characters of the new string is {result.Length}");
            }

        }
        static string Substring(string input, int numberOfWords)
        {
            return input.Substring(0, numberOfWords);
        }
    }
    
}
  