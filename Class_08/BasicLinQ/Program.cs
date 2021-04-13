using System;
using System.Collections;
using System.Collections.Generic;

namespace BasicLinQ
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>() { 1, 3, 4, 5, 6, 75, 7, 37, 4, 55, };

            List<int> numbersBiggerThanTen = new List<int>();
            foreach (int number in numbers)
            {
                if (number > 10)
                {
                    numbersBiggerThanTen.Add(number);
                }
            }
            GoTroughCollection(numbersBiggerThanTen, "numbersBiggerThanTen");
            List<int> numbersBiggerThanTen = new List<int>();
            

            Console.ReadLine();
        }
        static void GoTroughCollection(IEnumerable collection, string name)
        {
            Console.WriteLine($"Collection {name} items: ");
            foreach (var item in collection)
            {
                Console.WriteLine($"{item}, ");
            }
            Console.WriteLine();
        }
    }
}
