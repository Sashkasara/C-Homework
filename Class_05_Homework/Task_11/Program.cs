using System;

namespace Task_11
{
    class Program
    {
        //Create a function that goes through the array, incrementing (+1) for each odd number and decrementing (-1) for each even number and returns that array.

       // [1, 2, 3, 4, 5] -> [2, 1, 4, 3, 6]
        static void Main(string[] args)
        {
            Console.WriteLine("Difference in array");
            int[] exampleArray = { 54, -44, 542, 5, -922, 16, 666, 777 };
            differenceArray(exampleArray);
        }
        static void differenceArray(int[] array1)
        {
            int firstNumber = 0;
            int secondNumber= 0;
            foreach (int number in array1)
            {
                if (firstNumber < number)
                {
                    firstNumber= number;
                }
                if (secondNumber > number)
                {
                    secondNumber = number;
                }
            }
            int result = firstNumber - secondNumber;
            Console.WriteLine($"The difference between {firstNumber} and {secondNumber} is: {result}");
        }
    }
}
