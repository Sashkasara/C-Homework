using AbstractClasses.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractClasses.Entities
{
    public class Operations : Human, IOperations
    {
        public List<string> Projects { get; set; }

        public Operations (string fullname, int age, long phone, List<string> projects)
            :base (fullname, age, phone)
        {
            Projects = projects;
        }
        public override string GetIinfo()
        {
            return $"{FullName}";
        }

        public bool ChechInfrastructure(int status)
        {
            if (status.ToString().Contains)
        }
    }
}
