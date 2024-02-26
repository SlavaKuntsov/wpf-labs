using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace _2.Models
{
    public class BookFile
    {
        public string Name { get; set; }
        public string BookType { get; set; }
        public string FileSize { get; set; }
        public int PageCount { get; set; }
        public string UDC { get; set; }
        public int Year { get; set; }
        public DateTime UploadDate { get; set; }
        public Publisher Publisher { get; set; }
        public List<Author> Authors { get; set; } = new List<Author>();
        public BookFile(string name, string type, List<Author> authors, string fileSize, int pageCount, string udc, int year, DateTime currentDate, Publisher publisher)
        {
            Name = name;
            BookType = type;
            FileSize = fileSize;
            PageCount = pageCount;
            UDC= udc;
            Year = year;
            UploadDate = currentDate;
            Authors = authors;
            Publisher = publisher;

        }
    }
}
