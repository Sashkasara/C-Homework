using System;
using System.Collections.Generic;
using System.Text;

namespace DogExercise.Classes
{
    public static class DogShelter
    {
        public static List<Dog> Dogs { get; set; }

        static DogShelter()
        {
            Dogs = new List<Dog> { };
        }

        public static void PrintAll()
        {
            Console.WriteLine("Names of all 3 dogs: ");
            foreach (Dog dog in Dogs)
            {
                Console.WriteLine($"{dog.Name} and has {dog.Color} color");
            }
        }

        public static void AddDogs(Dog dog)
        {
            Dogs.Add(dog);
        }
    }
}
