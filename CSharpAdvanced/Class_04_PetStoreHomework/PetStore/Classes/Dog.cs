using System;
using System.Collections.Generic;
using System.Text;

namespace PetStore.Classes
{
    public class Dog : Pet
    {
        public override string Name { get; set; }
        public override string Type { get; set; }
        public override int Age { get; set; }
        public bool GoodBoi { get; set; }
        public string FavouriteFood { get; set; }


        public override void PrintInfo()
        {
            Console.WriteLine($"My name is {Name} amd I'm of type {Type} and I'm {Age} years old, my favourite food is {FavouriteFood} and I'm a good boi {GoodBoi}");
        }
    }
}
