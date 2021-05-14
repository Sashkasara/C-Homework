using System;
using System.Collections.Generic;
using System.Text;

namespace PetStore.Classes
{
    public class Fish : Pet
    {
        public override string Name { get; set; }
        public override string Type { get; set; }
        public override int Age { get; set; }
        public string Color { get; set; }
        public int Size { get; set; }

        public override void PrintInfo()
        {
            Console.WriteLine($"Me is fish and my name is {Name} and I'm of type {Type} and I'm {Age} years old and my color is {Color}");
        }
    }
}
