using System;

namespace Test.test
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ENTER YOUR NAME");
            string name = Console.ReadLine();
            Console.WriteLine("The name of the user is" + name);

            Console.WriteLine("Please enter your age");
            string ageInput = Console.ReadLine();

            //3 methods of data conversion
            //1 Try.Parse(value)

            int ageParse = int.Parse(ageInput);
            int bob = int.Parse("Bob"); //cannot

            // 2.Convert.ToType()
            int ageConvert = Convert.ToInt32(ageInput);
            int stringConvertToInteger = Convert.ToInt32("Bob"); //cannot
            //testtt

        }
    }
}
