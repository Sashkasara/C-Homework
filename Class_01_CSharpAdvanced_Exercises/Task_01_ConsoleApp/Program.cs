using System;
using System.Collections.Generic;

namespace Task_01_ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {

            List<string> names = new List<string>();
            string text = Console.ReadLine();
            Console.WriteLine("Please enter names that you want to be searched");
     
            foreach(string name in names)
            {
                Console.WriteLine(name);
            }

            Console.ReadLine();
        }
        static List<string> EnterNamesFromScreen()
        {
            List<string> names = new List<string>();
            Console.WriteLine("Please enter names that you want to be searched");

            while (true)
            {
                string input = Console.ReadLine();
                if (input == "x" || input == "x")
                {
                    break;
                }
                names.Add(input);
            }
            return names;
        }
    }
}
