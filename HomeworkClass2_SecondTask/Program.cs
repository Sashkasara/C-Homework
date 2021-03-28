using System;

namespace HomeworkClass2_SecondTask
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please write first number: ");
            bool firstInput = int.TryParse(Console.ReadLine(), out int firstParsedNumber);

            Console.WriteLine("Please write second number");
            bool secondInput = int.TryParse(Console.ReadLine(), out int secondParsedNumber);

            Console.WriteLine("Please write third number");
            bool thirdInput = int.TryParse(Console.ReadLine(), out int thirdParsedNumber);

            Console.WriteLine("Please write fourth number");
            bool fourthInput = int.TryParse(Console.ReadLine(), out int fourthParsedNumber);

           if (firstInput && secondInput && thirdInput && fourthInput)
            {
                int result = (firstParsedNumber + secondParsedNumber + thirdParsedNumber + fourthParsedNumber) / 4;
                Console.WriteLine("The average of the four numbers is " + result);
            }



            Console.ReadLine();
        }
    }
}
