using System;

namespace HomeworkClass2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Task 01
            Console.WriteLine("Enter the first number: ");
            bool firstNumber = double.TryParse(Console.ReadLine(), out double firstParsedNumber);

            Console.WriteLine("Enter the second number: ");
            bool secondNumber = double.TryParse(Console.ReadLine(), out double secondParsedNumber);;

            Console.WriteLine("Enter the operation sign: + , - , / , * ");
            string operatorInput = Console.ReadLine();

            if (firstNumber && secondNumber)
           
            {
                if (operatorInput == "+") {
                    double addition = firstParsedNumber + secondParsedNumber;
                    Console.WriteLine("The sum of the to first and the second numbers is: " + addition);
                }
                if (operatorInput == "-") {
                        double substractResult = firstParsedNumber - secondParsedNumber;
                        Console.WriteLine("Substraction from the first and the second number is: " + substractResult);
                    }
                if (operatorInput == "*") {
                    double multiplication = firstParsedNumber * secondParsedNumber;
                    Console.WriteLine("Multiplication from the first and the second number is: " + multiplication);
                }
                if (operatorInput == "/") {
                    double division = firstParsedNumber / secondParsedNumber;
                    Console.WriteLine("The result from dividing the two numbers is: " + division);
                }
            }
            Console.ReadLine();
            
            
            }
        }
    }

