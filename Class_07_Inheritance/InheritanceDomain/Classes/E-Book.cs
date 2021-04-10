using System;
using System.Collections.Generic;
using System.Text;

namespace InheritanceDomain.Classes
{
    public class E_Book: Book // e-book nasleduva od book
    {
        public E_Book()
        {

        }
        public E_Book(string title, string author, BookGenre genre, DateTime publishedDate, int numberOfPages) : base(title, author, genre, int price)
        {
            this.MemorySize = memorySize;
        }
        public int MemorySize { get; set; }
        public string getDownloadLink()
        {
            return $"https://bookstore.com/downloads";
        }
        public override string GetBookInfo()
        {
            return base.PrintBookInfo() + { MemorySize};
        }
    }
}
