using System;
using System.Collections.Generic;
using System.Text;

namespace PetStore.Classes
{
    public class Cat : Pet
    {
        public override string Name { get; set; }
        public override string Type { get; set; }
        public override int Age { get; set; }
        public bool IsLazy { get; set; }
        public int LivesLeft { get; set; }

        public override void PrintInfo()
        {
            Console.WriteLine($"Me is cat and my name is {Name} and I'm of type {Type} and I am {Age} years old and I have {LivesLeft} lives left");
        }
    }
}
