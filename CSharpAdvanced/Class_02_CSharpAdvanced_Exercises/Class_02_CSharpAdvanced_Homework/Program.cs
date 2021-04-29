using Class_02_CSharpAdvanced_Homework.Models;
using System;

namespace Class_02_CSharpAdvanced_Homework
{
    class Program
    {
        static void Main(string[] args)
        {
            Student firstStudent = new Student(1, "Jana", "jana123", "zzz222", 7);
            Student secondStudent = new Student(2, "Trajan", "trajan123", "zzz333", 4);
            Teacher firstTeacher = new Teacher(3, "Nikola", "nikola123", "ccc444", "C#");
            Teacher secondTeacher = new Teacher(4, "Nikolina", "nikolina123", "vvv555", "Phyton");
            firstStudent.PrintUser();
            secondStudent.PrintUser();
            firstTeacher.PrintUser();
            secondTeacher.PrintUser();

            Console.ReadLine();
        }
    }
}
