using System;

namespace Class_03_Homework_StudentGroupExercise
{
    class Program
    {
        static void Main(string[] args)
        {

            //Make a new console application called StudentGroup
            //Make 2 arrays called studentsG1 and studentsG2 and fill them with 5 student names.
            //Get a number from the console between 1 and 2 and print the students from that group in the console.
            //Ex: studentsG1["Zdravko", "Petko", "Stanko", "Branko", "Trajko"]
            //Test Data:
            //Enter student group: (there are 1 and 2 )
            //1
            //Expected Output:
            //The Students in G1 are:
            //Zdravko
            //Petko
            //Stanko
            //Branko
            //Trajko

            string[] studentsG1 = new string[] { "Zdravko", "Petko", "Stanko", "Branko", "Trajko" };
            string[] studentsG2 = new string[] { "Sashka", "Nikola", "Dame", "Emilija", "Stefan" };

            Console.WriteLine("Enter student group");
            string groupInput = Console.ReadLine();

            if (groupInput == "1")
            {
                Console.WriteLine("The students of group 1 are: ");
                foreach (string student in studentsG1)
                {
                    Console.WriteLine(student);
                }
            }
            else if (groupInput == "2")
            {
                Console.WriteLine("The students of group 2 are: ");
                foreach (string student in studentsG2)
                {
                    Console.WriteLine(student);
                }
            }
            else
            {
                Console.WriteLine("Please enter a valid value");
            }

            Console.ReadLine();
        }
    }
}
