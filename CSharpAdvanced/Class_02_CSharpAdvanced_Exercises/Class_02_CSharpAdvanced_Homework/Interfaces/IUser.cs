using System;
using System.Collections.Generic;
using System.Text;

namespace Class_02_CSharpAdvanced_Homework.Interfaces
{
    public interface IUser
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }

        void PrintUser();
    }
}
