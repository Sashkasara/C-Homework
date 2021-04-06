using System;

namespace Task1and2_DivideBy2and3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Task 01 & 02 divide by 3 and by 2
            //Write a program that will print out all numbers from the range 1-N (N is input from keyboard, N>2) that divide with 3.
            // same task but must divide by 3 and by 2
            Console.WriteLine("Enter a number bigger then 1 and smaller the 30");
            bool input = int.TryParse(Console.ReadLine(), out int numberN);
            int defaultResult = 0;

            if (input && numberN > 1 && numberN < 30)
            {
                Console.WriteLine("You entered the number: " + numberN);


                //Task number divide by 3

                for (int i = 1; i < numberN; i++)
                {
                    if (i % 3 == 0)
                    {
                        Console.WriteLine(i);
                    }
                }
            }
        }
    }
}
    
    
