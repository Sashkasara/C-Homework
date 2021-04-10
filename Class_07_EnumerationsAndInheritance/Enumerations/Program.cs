using System;

namespace Enumerations
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Blue;

            Book newWorld = new Book("New world", "Dan Brown", BookGenre.Sci_Fi, 300, 7.50 );
            newWorld.PrintBookInfo();
            Console.WriteLine($"The enum sci_fi is of type {newWorld.Genre.GetTypeCode()}");
            Console.WriteLine($"The enum of newWorld is {newWorld.Genre}");
            Console.WriteLine($"The number of the enum in background{(int)newWorld.Genre}"); // daj mi go integerot 
            Book CsharpInDepth = new Book("CSharp in depth", "Robert SOmething", BookGenre.Biography, 200, 10.5);
            Console.WriteLine($"The number of the enum in background{(int)CsharpInDepth.Genre}");

            string myCustomGenre = "Fitness"; // thriller postoi, ako piseeme drug genre sto ne postoi ke vrati false
            bool isMyCustomGenreValid = Enum.TryParse(myCustomGenre, out BookGenre genre);
            Console.WriteLine($"The {myCustomGenre} {isMyCustomGenreValid} exist");
            Console.WriteLine(genre);

            
            Console.ReadLine();
        }
    }
}
