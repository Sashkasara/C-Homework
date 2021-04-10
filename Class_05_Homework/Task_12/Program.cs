using System;

namespace Task_12
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create a function that takes an array and returns the difference between the biggest and smallest numbers.

            //[10, 4, 1, 4, -10, -50, 32, 21] -> 82

            Console.WriteLine("Helllooooo");
            int[] someNumberArray = { 32, 45, 2, -8, -7, 9 };
            int[] alteredArray = changeArray(someNumberArray);
            Console.Write("The original array is array: ");
            foreach (int num in someNumberArray)
            {
                Console.Write($"{num}/");
            }
            Console.WriteLine("End of original array");
            Console.Write("Altered array is array: ");
            foreach (int num in alteredArray)
            {
                Console.Write($"{num}/");
            }
            Console.WriteLine("End of alttered array");
        }
        static int[] changeArray(int[] inputArray)
        {
            int[] result = new int[inputArray.Length];
            for (int i = 0; i < inputArray.Length; i++)
            {
                if (inputArray[i] % 2 == 0)
                {
                    result[i] = inputArray[i] - 1;
                }
                else
                {
                    result[i] = inputArray[i] + 1;
                }
            }
            return result;
        }
    }
}
