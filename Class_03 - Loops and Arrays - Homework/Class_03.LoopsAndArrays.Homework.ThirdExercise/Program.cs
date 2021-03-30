using System;

namespace Class_03.LoopsAndArrays.Homework.ThirdExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            // EXERCISE 3
            // Get an input from the console
            // print all number from 1 to that number
            // dont print numbers that can be divided by 3 or 7
            // if the number gets to 100  print message: the limit is reached

            Console.WriteLine("Enter a number");
            int input3 = int.Parse(Console.ReadLine());
            for (int i = 1; i <= input3; i++)
            {
                if (i % 3 == 0 || i % 7 == 0)
                {
                    continue;
                }
                if (i == 100)
                {
                    Console.WriteLine("The limit is reached");
                    break;
                }
                Console.WriteLine(i);
            }

            Console.ReadLine();
        }
    }
}
