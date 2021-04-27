using AbstractClasses.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractClasses.Entities
{
    public class Tester : Human, ITester
    {
        public int BugsFound { get; set; }
        public Tester (string fullname, int age, long phone, int bugs)
            :base (fullname, age, phone)
        {
            BugsFound = bugs;
        }
        public override string GetIinfo()
        {
            throw new NotImplementedException();
        }

        public void TestFeature(string feature)
        {
            throw new NotImplementedException();
        }
    }
}
