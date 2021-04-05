using System;

namespace Class_04_SumAndSubstractExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create 2 methods called Sum and Subtract●Sum will accept two numbers as parameters and return a result
            //from summing the two numbers●Subtract will accept two numbers as parameters and return a result from 
            //subtracting the two numbers●Ask a person from the console to enter -or +●Then ask the person to enter
            //two numbers●Call the corresponding method(sum or subtract ) and return the result to the console
            Console.WriteLine("Please enter operator");
            string insertOperator = Console.ReadLine();
            Console.WriteLine("Please enter first number");
            string firstNumInput = Console.ReadLine();
            Console.WriteLine("Please enter second number");
            string secondNumberInput = Console.ReadLine();
            bool isFirstNumberValid = int.TryParse(firstNumInput, out int firstNumber);
            bool isSecondNumberValid = int.TryParse(secondNumberInput, out int secondNumber);
            if (insertOperator == "+")
            {
                if (isFirstNumberValid && isSecondNumberValid)
                {
                    int sumResult = Sum(firstNumber, secondNumber);
                    Console.WriteLine(sumResult);
                }
                else
                {
                    Console.WriteLine("The input numbers were not valid");
                }
            }
            else if (insertOperator == "-")
            {
                if (isFirstNumberValid && isSecondNumberValid)
                {
                    int substractResult = Substract(firstNumber, secondNumber);
                    Console.WriteLine("The substraction result is " + substractResult);
                }
                else
                {
                    Console.WriteLine("The numbers were not valid");
                }

            }
            else
            {
                Console.WriteLine("The operator is not valid");
            }

            Console.ReadLine();
        }
        static int Sum(int num1, int num2)
        {
            return num1 + num2;
        }

        static int Substract(int num1, int num2)
        {
            return num1 - num2;
        }
    }

}
