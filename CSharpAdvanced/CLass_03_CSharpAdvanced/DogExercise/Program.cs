using DogExercise.Classes;
using System;

namespace DogExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Dog firstDog = new Dog(1, "Coki", "white");
            Dog secondDog = new Dog(2, "Moki", "black");
            Dog thirdDog = new Dog(3, "Loki", "gold");

            Dog.Validate(firstDog);
            Console.WriteLine("==================");

            Dog.Validate(secondDog);
            Console.WriteLine("==================");

            Dog.Validate(thirdDog);
            Console.WriteLine("==================");

            DogShelter.AddDogs(firstDog);
            DogShelter.AddDogs(secondDog);
            DogShelter.AddDogs(thirdDog);

            Console.WriteLine("=================");

            DogShelter.PrintAll();

            Console.ReadLine();

        }
    }
}
