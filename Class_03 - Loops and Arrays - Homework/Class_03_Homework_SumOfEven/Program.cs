using System;

namespace Class_03_Homework_SumOfEven
{
    class Program
    {
        static void Main(string[] args)
        {
     //Make a console application called SumOfEven. Inside it create an array of 6 integers.
     //Get numbers from the input, find and print the sum of the even numbers from the array:

            //Test Data:
             //Enter integer no.1:
            //4
            //Enter integer no.1:
            //3
            //Enter integer no.1:
            //7
            //Enter integer no.1:
            //3
            //Enter integer no.1:
            //2
            //Enter integer no.1:
            //8
            //Expected Output:
            //The result is: 14


            int[] arrayOfNumbers = new int[6];
            int sum = 0;

            for (int i = 0; i < arrayOfNumbers.Length; i++)
            {
                Console.Write("Enter a number: ");
                string numberInput = Console.ReadLine();
                bool conversionToNumber = int.TryParse(numberInput, out int num);

                if (!conversionToNumber)
                {
                    i--;
                    continue;
                }

                arrayOfNumbers[i] = num;
            }

            foreach (int number in arrayOfNumbers)
            {
                if (number % 2 == 0)
                {
                    sum += number;
                }
            }

            Console.WriteLine($"The result is: {sum}.");
            Console.ReadLine();
        }
    }
}
