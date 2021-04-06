using System;

namespace ThirdExercise_StudentClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Student[] students = new Student[5];

            students[0] = new Student("sashka", "SEDC", "3");
            students[1] = new Student("filip", "SEDC", "2");
            students[2] = new Student("trajan", "SEDC", "4");
            students[3] = new Student("ljubica", "SEDC", "5");
            students[4] = new Student("jovana", "SEDC", "2");

            Console.WriteLine("Please enter your name");
            string userInput = Console.ReadLine();

            for(int i = 0; i< students.Length; i++)
            {
                string parsedInput = userInput.ToLower();
                if (students[i].Name == parsedInput)
                {
                    Console.WriteLine($"{students[i].Name} Academy: {students[i].Academy} Group: {students[i].Group}");
                    break;
                }
                else
                {
                    Console.WriteLine("You are not in the academy"); // 5 pati loop.. you are not in the academy
                }
            }
            Console.ReadLine();
        }
    }
}
