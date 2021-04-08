using System;
using System.Collections.Generic;
using System.Text;

namespace Enumerations
{
    public class Book
    {
        public Book(string title, string author, BookGenre genre, int numberOfPages, double price)
        {
            this.Title = title;
            this.Author = author;
            this.Genre = genre;
            this.NumberOfPages = NumberOfPages;
            this.Price = price;
        }
        public string ISBN { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public BookGenre Genre { get; set; }
        public int NumberOfPages { get; set; }
        public double Price { get; set; }
        public DateTime PublishedDate { get; set; }
        public void PrintBookInfo()
        {
            Console.WriteLine($"The book {Title} from the author {Author} of genre {Genre} is price {Price}");
        }
    }
  
}
