using AbstractClasses.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractClasses.Entities
{
    public class Developer : Human, IDeveloper
    {
        public string Gender { get; set; }
        public List<string> ProgrammingLanguages { get; set; }
        public int YearsOfExperience { get; set; }

        public Developer(string fullname, int age, long phone, List<string> lagnuages, int exp)
            :base(fullname, age,phone)
        {
            ProgrammingLanguages = lagnuages;
            YearsOfExperience = exp;
        }

        public override string GetIinfo()
        {
            //mrs. or mr. or dr.
            if (Gender == "male")
            {
                return $"MR.{FullName} ({Age}) - {YearsOfExperience} years of experience! Has a knowledge of {ProgrammingLanguages.Count} languages";

            }
            return $"MRS. {FullName} ({Age}) - {YearsOfExperience} years of experience! Has a knowledge of {ProgrammingLanguages.Count} languages";
        }

        public void Code()
        {
            Console.WriteLine("tak.. tak.. tak");
            Console.WriteLine("Opens stack and overflow...");
            Console.WriteLine("tak..tak..tak...");
        }
    }
}
