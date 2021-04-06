using System;


namespace FirstExerciseFromClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Human human = new Human();
            Console.WriteLine("Write your first name");
            human.FirstName = Console.ReadLine();
            Console.WriteLine("Write your last name");
            human.LastName = Console.ReadLine();
            Console.WriteLine("Enter you age");
            human.Age = int.Parse(Console.ReadLine());

            string personalStats = human.GetPersonStats();
            Console.WriteLine(personalStats);

            Console.ReadLine();
        }
    }
}
