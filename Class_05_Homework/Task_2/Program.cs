using System;

namespace Task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create a function to say whether a string is symmetric (a palindrome). For example, "RADAR" is a palindrome.


            int num;
            int n;
            int reversedNum = 0;
            int r;
            Console.WriteLine("Enter the number :");
            num = Convert.ToInt32(Console.ReadLine());
            n = num;
            while (n != 0)
            {
                r = n % 10;
                reversedNum = reversedNum * 10 + r;
                n = n / 10;
            }
            if (num == reversedNum)
                Console.WriteLine("Given number {0} is palindrome number", num);
            else
                Console.WriteLine("Given number {0} is not a palindrome number", num);

            Console.ReadKey();

        }
    }
}
