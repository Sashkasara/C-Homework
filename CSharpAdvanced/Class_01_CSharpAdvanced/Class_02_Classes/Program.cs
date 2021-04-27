using System;

namespace Class_02_Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            bool isValid = int.TryParse(input, out int num);
            if (isValid)
            {

            }
            Console.ReadLine();
        }
    }
}
