using _3.Other;

using Newtonsoft.Json;

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace _3.Models
{
	public class BookFile
	{
		[Required(ErrorMessage = "Name is required")]
		public string Name { get; set; }
		[Required(ErrorMessage = "BookType is required")]
		public string BookType { get; set; }
		[Required(ErrorMessage = "FileSize is required")]
		public string FileSize { get; set; }
		[Range(1, int.MaxValue, ErrorMessage = "PageCount must be a positive integer")]
		public int PageCount { get; set; }
		[UDCValidation(ErrorMessage = "Invalid UDC format. The format should be XXX.XX or XXX.XX.XX")]
		public string UDC { get; set; }
		[Range(1900, 2025, ErrorMessage = "Year must be between 1800 and the current year")]
		public int Year { get; set; }
		[Required(ErrorMessage = "UploadDate is required")]
		public DateTime UploadDate { get; set; }
		[Required(ErrorMessage = "Publisher is required")]
		public Publisher Publisher { get; set; }
		public List<Author> Authors { get; set; } = new List<Author>();

		public BookFile(string name, string type, List<Author> authors, string fileSize, int pageCount, string udc, int year, DateTime currentDate, Publisher publisher)
		{
			Name = name;
			BookType = type;
			FileSize = fileSize;
			PageCount = pageCount;
			UDC = udc;
			Year = year;
			UploadDate = currentDate;
			Authors = authors;
			Publisher = publisher;
		}
	}
}
