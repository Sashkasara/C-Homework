using System;

namespace Task_9
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create a function to take one parameter n to display the date of past n years from current date and to tell what day it was.
            //The parameter should not be larger that 20.
            Console.WriteLine("Please enter a number between 0-20");
            int years = int.Parse(Console.ReadLine());
            if (years <= 20)
            {
                PastYears(years);
            }
            else
            {
                Console.WriteLine("Please enter a shorter input");
            }
        }
        static void PastYears(int n)
        {
            DateTime currentDate = DateTime.Today;
            Console.WriteLine($"The current date is {currentDate}");
            DateTime newYears = currentDate.AddYears(-n);
            Console.WriteLine($"The date {n} years ago was {newYears}, the day was the {newYears.Day}th and the year {newYears.Year}");
            Console.ReadLine();
        }
    }
}
