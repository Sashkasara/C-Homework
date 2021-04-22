using AbstractClasses.Entities;
using System;
using System.Collections.Generic;

namespace AbstractClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            Developer developer = new Developer("Bob", 44, 345678,
                new List<string> { "JS", "c#", "html", "CSS" }, 6);
            Tester tester = new Tester("Jill Mayne", 32, 5433344, 540);
            Operations operations = new Operations("Greg Gregsky", 34, 434333334,
                new List<string> { "Optimus", "ProtoBeat" });


            Console.ReadLine();
        }
    }
}
