using System;

namespace Class_04_UsingStringsExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //Try writing these strings in the console:Check your c:\drive
            //We will have "fair" elections
            //The \n sign means: new line
            string saying = @"Check your c:\drive";
            string saying2 = "We will have \"fair\" elections";
            string saying3 = @"The \n sign means: new line";
            //Console.WriteLine(saying);
            //Console.WriteLine(saying2);
            Console.WriteLine(saying3);
            
            Console.ReadLine();
        }
    }
}
