using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace DogExercise.Classes
{
    public class Dog
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Color { get; set; }

        public Dog(int id, string name, string color)
        {
            Id = id;
            Name = name;
            Color = color;
        }
        public void Bark()
        {
            Console.WriteLine("Bark bark");
        }

        public static void Validate(Dog dog)
        {
            Type d = typeof(Dog);
            if (d.GetProperties().Count() == 3)
            {
                Console.WriteLine("Has all 3 properties");
            }
            else
            {
                Console.WriteLine("Number of properties not valid");
            }

            if (dog.Id < 0)
            {
                Console.WriteLine($"Id: {dog.Id}, is not valid");
            }
            else
            {
                Console.WriteLine($"Id: {dog.Id} is valid");
            }

            if (dog.Name.Trim().Length > 2)
            {
                Console.WriteLine($"The name {dog.Name} is longer than 2 characters");
            }
            else
            {
                Console.WriteLine($"The name {dog.Name} is not valid");
            }

        }
    }
}
