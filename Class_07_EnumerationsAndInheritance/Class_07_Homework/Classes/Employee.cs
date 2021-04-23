using System;
using System.Collections.Generic;
using System.Text;

namespace Class_07_Homework.Classes
{
    public class Employee
    {
        //# Exercise 01
        //●Create a class library project and in it create all classes
        //●Create a class called Employee with the following properties:
        //▹FirstName
        //▹LastName
        //▹Role - Enum(Sales, Manager, Other)
        //▹Salary -protected, double
        //●Create two methods:
        //▹PrintInfo - Prints FirstName, LastName and Salary
        //▹GetSalary -returns the salary

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Role Role { get; set; }
        protected double Salary { get; set; }

        public Employee()
        {
        }

        public Employee(string firstName, string lastName, Role role, double salary)
        {
            FirstName = firstName;
            LastName = lastName;
            Role = role;
            Salary = salary;
        }

        public void PrintInfo()
        {
            Console.WriteLine($"The {FirstName} {LastName} with role \"{Role}\" has salary of {GetSalary()} dollars");
        }

        public virtual double GetSalary()
        {
            return Salary;
        }
    }
}
