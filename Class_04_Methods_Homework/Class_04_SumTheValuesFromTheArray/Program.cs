using System;

namespace Class_04_SumTheValuesFromTheArray
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declare a new array of integers with 5 elements
            //●Initialize the array elements  with values from input
            //●Sum all the values and print the result in the console
            int[] numbersArray = new int[5];
            int sum = 0;
            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine("Please enter a number");
                string numberInput = Console.ReadLine();
                bool isValidNumber = int.TryParse(numberInput, out int number);
                if (isValidNumber)
                {
                    numbersArray[i - 1] = number;
                    Console.WriteLine($"The {i} number that was added in the array is: {number}");
                    sum += number;
                    continue;
                }
                Console.WriteLine("The added input was not valid number. The program will count it as 0.");
            }
            Console.WriteLine($"The sum of the added numbers is {sum}");
            Console.ReadLine();
        }
    }
}
