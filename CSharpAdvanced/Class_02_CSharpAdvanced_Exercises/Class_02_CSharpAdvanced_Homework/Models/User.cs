using Class_02_CSharpAdvanced_Homework.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Class_02_CSharpAdvanced_Homework.Models
{
    public abstract class User : IUser
    {
        public abstract int Id { get; set; }
        public abstract string Name { get; set; }
        public abstract string Username { get; set; }
        public abstract string Password { get; set; }

        public User(int id, string name, string username, string password)
        {
            Id = id;
            Name = name;
            Username = username;
            Password = password;
        }

        public abstract void PrintUser();
    }
}
