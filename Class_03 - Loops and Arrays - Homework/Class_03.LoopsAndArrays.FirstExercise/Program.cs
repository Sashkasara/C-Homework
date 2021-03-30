using System;

namespace Class_03.LoopsAndArrays.FirstExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            // EXERCISE 1
            // get an input from the console
            //print all the numbers from 1 to that number
            //get another input number from the console
            //print all the numbers from that number to 1

            Console.WriteLine("Enter a number:");
            int input = int.Parse(Console.ReadLine());
            for (int i = 1; i <= input; i++)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("Enter another number:");
            int input1 = int.Parse(Console.ReadLine());
            for (int i = input1; i >= 1; i--)
            {
                Console.WriteLine(i);
            }
            Console.ReadLine();

        }
    }
}
