using System;
using System.IO;
using System.Windows.Media;
using System.Windows.Media.Imaging;

using static _4.Abstractions.ProductAbstraction;

namespace _4.MVVM.Model
{
	public class ProductModel
	{
		public string ShortName { get; set; }
		public string FullName { get; set; }
		public string Description { get; set; }
		public double Price { get; set; }
		public string Image { get; set; }
		public Category Category { get; set; }
		public Rating Rating { get; set; }
		public int Count { get; set; }
		public bool InStock { get; set; }

		public ImageSource ImageSource { get; set; }

		public ProductModel(string shortName, string fullName, string description, double price, string imageName, Category category, Rating rating, int count)
		{
			ShortName = shortName;
			FullName = fullName;
			Description = description;
			Price = price;
			Image = imageName;
			Category = category;
			Rating = rating;
			Count = count;
			InStock = count > 0;
			Console.WriteLine("price ", price);
			Console.WriteLine("imageName ", imageName);
		}

		public void CreateImageSource(string imageName)
		{

			string currentDirectory = AppDomain.CurrentDomain.BaseDirectory;

			string assetsDirectory = Path.Combine(currentDirectory, "..", "..", "Assets", "pizza");
			string imagePath = Path.Combine(assetsDirectory, imageName);

			if (string.IsNullOrEmpty(imagePath) || !Directory.Exists(assetsDirectory))
			{
				return;
			}

			ImageSource = new BitmapImage(new Uri(imagePath));
		}
	}
}
