using System;

namespace SecondExercise_DogExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ENter a number to selec a method: 1 for Eat, 2 for Play, 3 for ChaseTail");
            int userInput = int.Parse(Console.ReadLine());

            Dog bruno = new Dog();

            if(userInput == 1)
            {
                Console.WriteLine(bruno.Eat());
            }
            else if (userInput == 2)
            {
                Console.WriteLine(bruno.Play());
            }
            else if (userInput == 3)
            {
                Console.WriteLine(bruno.ChaseTail());
            }
            Console.ReadLine();
        }
    }
}
