using System;

namespace Task_8
{
    class Program
    {
        //Create a function to take one parameter n and calculate what day of the week is n days from this moment.

        static void dayOftheWeek(int number)
        {
            DateTime todayDate = DateTime.Now;
            Console.WriteLine($"Today is: {todayDate}");
            Console.WriteLine(todayDate.AddDays(number));
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number");
            bool checkInput = int.TryParse(Console.ReadLine(), out int inputNumber);
            if (checkInput)
            {
                dayOftheWeek(inputNumber);
            }
            else
            {
                Console.WriteLine("Only numbers allowed");
            }
            Console.ReadLine();
        }
    }
}
