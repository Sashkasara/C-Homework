using System;

namespace Task_10
{
    class Program
    {
        //Create a function that takes a number as an argument and returns an array of numbers counting down from this number to zero.

            //5 -> [5, 4, 3, 2, 1, 0]

        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number");
            int number = int.Parse(Console.ReadLine());

            CountingNumbers(number);
        }

        static void CountingNumbers(int n)
        {
            int[] numbers = new int[n + 1];

            for (int i = n - 1; i >= 0; i--)
            {
                numbers[i] = i;
                Console.Write(numbers[i] + " ");
            }
            Console.ReadLine();
        }
    }
    
}
