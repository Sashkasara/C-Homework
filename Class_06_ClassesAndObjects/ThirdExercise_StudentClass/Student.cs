using System;
using System.Collections.Generic;
using System.Text;

namespace ThirdExercise_StudentClass
{
   public class Student
    {
        public string Name { get; set; }
        public string Academy { get; set; }
        public string Group { get; set; }

        public Student() //ne mora ova
        {

        }

        public Student (string name, string academy, string group)
        {
            Name = name;
            Academy = academy;
            Group = group;

        }
    }
}
