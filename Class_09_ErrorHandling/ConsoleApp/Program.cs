
using Exeptions.Demo;
using System;
using System.Collections.Generic;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Compiletime error
            //int age = "Damjan";

            //
            DemoClass demoObj = new DemoClass();
            List<int> numbers = new List<int> { 32, 33, 56, 255, 24 };
            try
            {
                //int elementAtPositionFour = demoObj.getNumberAtCertainPositionParent(5, numbers);
            }
            catch (Exeption ex)
            {
                Console.WriteLine($"This is the error message: {ex.Message}");
                Console.WriteLine($"This is the error stacktrace: {ex.StackTrace}");
            }
            int elementAtPositionFour = demoObj.GetNumberAtCertainPosition(3, numbers);
            Console.WriteLine($"The element at position 4 is {elementAtPositionFour}");
            Console.ReadLine();
        }
    }
}
