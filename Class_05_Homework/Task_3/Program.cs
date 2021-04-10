using System;

namespace Task_3
{
    class Program
    {
        //Create a function which returns the greatest value stored in an array of real numbers which is specified as parameter.


        static void Main(string[] args)
        {
            int[] arrayOfNumbers = { 5, 4, 14, 55, 21, 11 };
            Console.WriteLine($"The biggest number is {getTheBiggestNumber(arrayOfNumbers)}");
        }
        static int getTheBiggestNumber(int[] arr)
        {
            int greatestValue = arr[0];
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > greatestValue)
                {
                    greatestValue = arr[i];
                }
            }
            return greatestValue;
        }
    }
}
