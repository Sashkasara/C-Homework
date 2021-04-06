using System;
using System.Collections.Generic;
using System.Text;

namespace FirstExerciseFromClass
{
    class Human
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }

        public string GetPersonStats()
        {
            string personStats = $"The full name of the human is {FirstName} {LastName} and he is {Age} years old";
            return personStats;
        }
    }
    
 }

