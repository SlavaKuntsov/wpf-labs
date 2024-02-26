namespace _2.Models
{
    public class Publisher
    {
        public string Name { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public int YearFounded { get; set; }
        public bool IsPrivate { get; set; }
        public Publisher(string name, string country, string city, int yearFounded, bool isPrivate)
        {
            Name = name;
            Country = country;
            City = city;
            YearFounded = yearFounded;
            IsPrivate = isPrivate;
        }
    }
}