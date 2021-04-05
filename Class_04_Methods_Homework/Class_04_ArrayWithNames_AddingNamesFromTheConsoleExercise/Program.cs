using System;

namespace Class_04_ArrayWithNames_AddingNamesFromTheConsoleExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create an array with names
            //●Give an option to the user to enter a name from the keyboard
            //●After entering the name put it in the array●Ask the user if they want to enter another name(Y / N)
            //●Do the same process over and over until the user enters N
            //●Print all the names after user enters N

            string[] names = new string[2];
            names[0] = "Damjan";
            names[1] = "Trajan";
            string newName;
            string userInput;
            do
            {
                Console.WriteLine("Please enter a name");
                newName = Console.ReadLine();
                Array.Resize(ref names, names.Length + 1);
                names[names.Length - 1] = newName;
                Console.WriteLine("You have entered the name " + newName + " in the array");
                Console.WriteLine("Would you like to enter an other name?");
                userInput = Console.ReadLine();
                if (userInput != "y" && userInput != "Y")
                {
                    Console.WriteLine("The names in the array are ");
                    foreach (var name in names)
                    {
                        Console.WriteLine(name);
                    }
                }
            } while (userInput == "y" || userInput == "Y");
            Console.Read();
        }
    }
}
