using AbstractClasses.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractClasses.Entities
{
    public class QAEngineer : Human, IDeveloper, ITester
    {
        public List<string> TestingFrameworks { get; set; }

        public QAEngineer(string fullname, int age, long phone, List<string> frameworks)
            :base(fullname, age, phone)
        {
            TestingFrameworks = frameworks;
        }
        public override string GetIinfo()
        {
            return $"{FullName} ({Age}) - Knows {(TestingFrameworks.Count != 0 ? TestingFrameworks[0] : "unknown")} frameworks";
        }

        public void Code()
        {
            Console.WriteLine("tak.. tak.. tak");
            Console.WriteLine("Opens stack and overflow...");
            Console.WriteLine("tak..tak..tak...");
        }
    }
}
