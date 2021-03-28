using System;

namespace HomeworkClass02_ThirdTask
{
    class Program
    {
        static void Main(string[] args)
        {
            //Swaping exercise
            Console.WriteLine("Enter the first number");
            int firstInput = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the second number");
            int secondInput = int.Parse(Console.ReadLine());

            int swap = firstInput;
            firstInput = secondInput;
            secondInput = swap;

            Console.WriteLine("After swaping ");
            Console.WriteLine("First number is: " + firstInput);
            Console.WriteLine("Second Number is " + secondInput);

            Console.ReadLine();
        }
    }
}
