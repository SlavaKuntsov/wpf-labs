using System.ComponentModel.DataAnnotations;

namespace _3.Models
{
	public class Publisher
	{
		[Required(ErrorMessage = "Name is required")]
		public string Name { get; set; }
		[Required(ErrorMessage = "Country is required")]
		public string Country { get; set; }
		[Required(ErrorMessage = "City is required")]
		public string City { get; set; }
		[Range(1800, 2025, ErrorMessage = "Year founded must be between 1800 and the current year")]
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