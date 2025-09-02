using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADVC_C_04
{
    public class Book
    {
        public string ISBN { get; set; }
        public string Title { get; set; }
        public string[] Authors { get; set; }
        public DateTime PublicationDate { get; set; }
        public decimal Price { get; set; }

        public Book(string isbn, string title, string[] authors, DateTime pubDate, decimal price)
        {
            ISBN = isbn;
            Title = title;
            Authors = authors;
            PublicationDate = pubDate;
            Price = price;
        }

        public override string ToString()
        {
            return $"ISBN: {ISBN}\n" +
                   $"Title: {Title}\n" +
                   $"Authors: {string.Join(", ", Authors)}\n" +
                   $"Publication Date: {PublicationDate.ToShortDateString()}\n" +
                   $"Price: {Price:C}";
        }
    }

}
