using System;

namespace Task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a function that will give stats about an integer number.The function should write the stats in console.The stats required are:

            //Whats the value of the number
            //How many digits the number has
            //Is the number odd or even
            //Is the number positive
            //I.e. if the user enters the number 25, the response should be

           //The number 25 is a 2 digit number, it's odd and it's a positive number.

            Console.WriteLine("Enter a number");
            int num = int.Parse(Console.ReadLine());
            NumberStats(num);
        }
        static void NumberStats(int number)
        {
            int n = number;

            int digits = 0;
            while (n != 0)
            {
                digits++;
                n = n / 10;
            }

           
            if (number % 2 == 0)
            {
                Console.WriteLine($"The number {number} is even number");
            }
            else
            {
                Console.WriteLine($"The number {number} is odd number");
            }

           
            if (number > 0)
            {
                Console.WriteLine($"The number {number} is positive number");
            }
            else
            {
                Console.WriteLine($"The number {number} is negative number");
            }

            Console.WriteLine($"The number {number} has {digits} digits");
            Console.ReadLine();
        }
    }
}
