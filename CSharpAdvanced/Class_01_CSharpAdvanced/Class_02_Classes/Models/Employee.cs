using System;
using System.Collections.Generic;
using System.Text;

namespace Class_02_Classes.Models
{
    public class Employee
    {
        public string FullName { get; set; }
        private int Salary { get; set; }
        public Employee( string name, int salary)
        {
            FullName = name;
            Salary = salary;
        }
        public virtual int GetSalary()
        {
            return Salary;
        }
    }
}
