using System;
using InheritanceDomain.Classes;
using Classesss.Classes;


namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            //Book newBook = new Book();
            //User damjan = new User();
            //Console.WriteLine("Hello World!");
           // E_Book electronicBook = new E_Book();
            Book bookWithId = new Book("title", "author", BookGenre.Adventure, 10.5, DateTime.Now, 200);
            string regularBookInfo = bookWithId.GetBookInfo();

            E_Book electronicBook = new E_Book()
            {
                Author = "electronic book",
                NumberOfPages = 100;
                MemorySize
           
            }
        }
    }
}
