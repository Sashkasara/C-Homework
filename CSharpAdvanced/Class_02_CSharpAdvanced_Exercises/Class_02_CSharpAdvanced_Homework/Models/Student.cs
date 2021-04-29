using Class_02_CSharpAdvanced_Homework.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Class_02_CSharpAdvanced_Homework.Models
{
    class Student : User, IStudent
    {
        public int Grade { get; set; }
        public override int Id { get; set; }
        public override string Name { get; set; }
        public override string Username { get; set; }
        public override string Password { get; set; }

        public Student(int id, string name, string username, string password, int grade) : base(id, name, username, password)
        {
            Grade = grade;
            Id = id;
            Name = name;
            Username = username;
            Password = password;
        }


        public override void PrintUser()
        {
            Console.WriteLine($"Id: {Id} Name: {Name} Username: {Username} Grade: {Grade}");
        }
    }
}
