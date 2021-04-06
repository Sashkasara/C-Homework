using System;
using System.Collections.Generic;
using System.Text;

namespace SecondExercise_DogExercise
{
    class Dog
    {
        public string Name { get; set; }
        public string Race { get; set; }
        public string Color { get; set; }

        public Dog()
        {

        }

        public string Eat()
        {
            return "The dog  is now eating";
        }
        public string Play()
        {
            return "The dog is now playing";
        }
        public string ChaseTail()
        {
            return "The dog is chasing it's tail";
        }

        
    }
}
