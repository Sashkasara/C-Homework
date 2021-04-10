using System;

namespace Task_7
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create a function to find the number of times a substring appears in a given string.

            string sentence = "Success, accuracy";
            string substring = "cc";

            HowManyTimes(sentence, substring);
        }
        static void HowManyTimes(string str, string subString)
        {
            int start = 0;
            int y = -1;
            int index = -1;
            while (start != -1)
            {
                start = str.IndexOf(subString, index + 1);
                y += 1;
                index = start;
            }
            Console.WriteLine($"The string {subString} occurs {y} times in the sentence: {str}");
            Console.ReadLine();
        }
    }
}
