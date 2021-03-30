using System;

namespace Class_03_LoopsAndArrays_Homework.SecondExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            // EXERCISE 2 
            //Get an input num from the console
            //Print all even numbers starting from 2
            // get another input num from the console
            //print all odd numbers starting from 1

            Console.WriteLine("Please enter a number");
            int num = int.Parse(Console.ReadLine());
            for (int i = 2; i <= num; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i + "is an even number");
                }
            }

            Console.WriteLine("Please enter another number");
            int num2 = int.Parse(Console.ReadLine());
            for (int i = 1; i <= num2; i++)
            {
                if (i % 2 != 0)
                {
                    Console.WriteLine(i + " is an odd number");
                }
            }
            Console.ReadLine();
        }
    }
}
