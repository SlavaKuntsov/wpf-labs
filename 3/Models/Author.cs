using System;
using System.ComponentModel.DataAnnotations;

namespace _3.Models
{
	public class Author
	{
		public Guid ID { get; set; }
		[Required(ErrorMessage = "FullName is required")]
		public string FullName { get; set; }
		[Required(ErrorMessage = "Country is required")]
		public string Country { get; set; }
		public Author(string fullname, string country)
		{
			ID = Guid.NewGuid();
			FullName = fullname;
			Country = country;
		}
	}
}