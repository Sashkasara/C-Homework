
using Class_07_Homework.Classes;
using System;

namespace Class_07_Homework
{
    class Program
    {
        static void Main(string[] args)
        {
            //FirstExercise
            Employee randomEmployee = new Employee("Jana", "Janevska", Role.Retailer, 700);
            randomEmployee.PrintInfo();


            //Secondexercise
            SalesPerson saleEmploy = new SalesPerson("Jovana", "Jovanovska");
            saleEmploy.AddSuccessRevenue();
            saleEmploy.PrintInfo();


            //ThirdExercise
            Manager managerEmploy = new Manager("Stefani", "Stefanovska", 3000);
            managerEmploy.AddBonus(200);
            managerEmploy.PrintInfo();


            Console.ReadLine();
        }
    }
}
