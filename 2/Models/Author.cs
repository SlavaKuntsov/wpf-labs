using System;
using System.Xml.Linq;

namespace _2.Models
{
    public class Author
    {
        public Guid ID { get; set; }
        public string FullName { get; set; }
        public string Country { get; set; }
        public Author(string fullname, string country)
        {
            ID = Guid.NewGuid();
            FullName = fullname;
            Country = country;
        }
    }
}