using System;

namespace InheritanceDomain.Classes
{
    public class Book
    {
        public Book()
        {

        }
        public Book(string title, string author, BookGenre genre, double Price, DateTime publishedDate, int NumberOfPages)
        {
            this.Title = title;
            this.Author = author;
            this.genre = genre;
            this.Price = Price;
            this.PublishedDate = publishedDate;
            this.NumberOfPages = NumberOfPages;
        }
        private int BookId { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public BookGenre genre { get; set; }
        public double Price { get; set; }
        public DateTime PublishedDate { get; set; }
        public int NumberOfPages { get; set; }

        private int SetBookId()
        {
            return new Random.().Next(1, 1000);
        }

        public virtual string GetBookInfo() //vitrual, nasleduva vo druga klasa
        {
            return $"The book {Title} with book id {BookId} from author {Author} ";
        }
    }
}
