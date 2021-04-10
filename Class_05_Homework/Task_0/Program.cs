using System;

namespace Task_0
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create a function that calculates the result of raising an integer to another integer
            //(eg 5 raised to 3 = 5^3 = 5 × 5 × 5 = 125).


            Console.WriteLine("Enter an integer");
            int number = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter another integer");
            int number2 = int.Parse(Console.ReadLine());

            Console.WriteLine("The final result is " + CalculateResult(number, number2));
        }
        static int CalculateResult(int number, int number2)
        {
            int result = 1;
            for (int i = 1; i <= number2; i++)
            {
                result *= number;
            }
            return result;
        }
    }

}
