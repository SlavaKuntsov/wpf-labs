using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Media;
using System.Windows.Media.Imaging;

using CSharpFunctionalExtensions;

using static _4.Abstractions.ProductAbstraction;

namespace _4.MVVM.Model
{
	public class ProductModel
	{
		//	visible
		public string ShortName { get; set; }
		public string FullName { get; set; }
		public string Description { get; set; }
		public double Price { get; set; }
		public string Image { get; set; }
		public PizzaCategories Category { get; set; }
		public Rating Rating { get; set; }
		public int Count { get; set; }

		//	hidden
		public bool InStock { get; set; }
		public PizzaSizes PizzaSizes { get; set; }
		public Dictionary<PizzaSizes, string> PizzaSizesDictionary { get; set; }
		public ImageSource ImageSource { get; set; }
		public List<int> StringRating { get; set; } = new List<int>();

		public ProductModel() { }

		public ProductModel(string shortName, string fullName, string description, double price, string imageName, ImageSource imageSource, PizzaCategories category, Rating rating, int count)
		{
			ShortName = shortName;
			FullName = fullName;
			Description = description;
			Price = price;
			Image = imageName;
			ImageSource = imageSource;
			Category = category;
			Rating = rating;
			Count = count;
			InStock = count > 0;

			if (category == PizzaCategories.Pizza)
			{
				PizzaSizes = PizzaSizes.Medium;
			}
			else
			{
				PizzaSizes = PizzaSizes.NotAPizza;
			}

			PizzaSizesDictionary = new Dictionary<PizzaSizes, string>
			{
				{ PizzaSizes.Small, "Маленькая" },
				{ PizzaSizes.Medium, "Средняя" },
				{ PizzaSizes.Big, "Большая" },
			};

			for (int i = 1; i <= ((int)rating); i++)
			{
				StringRating.Add(i);
			}
		}

		public static Result<ProductModel> Create(string shortName, string fullName, string description, double price, string imageName, PizzaCategories category, Rating rating, int count)
		{
			if (
				string.IsNullOrWhiteSpace(shortName) ||
				string.IsNullOrWhiteSpace(fullName) ||
				string.IsNullOrEmpty(description))
			{
				return Result.Failure<ProductModel>("ShortName, FullName or Description can not be empty");
			}

			if (price <= 0 || count <= 0)
			{
				return Result.Failure<ProductModel>("Price or Count must be greater than 0");
			}

			string currentDirectory = AppDomain.CurrentDomain.BaseDirectory;

			string assetsDirectory = Path.Combine(currentDirectory, "..", "..", "Assets", "pizza");
			string imagePath = Path.Combine(assetsDirectory, imageName);


			if (string.IsNullOrEmpty(imageName))
			{
				return Result.Failure<ProductModel>("ImageName is can not be empty");
			}
			if (!Directory.Exists(assetsDirectory))
			{
				return Result.Failure<ProductModel>("Directory not exist");
			}

			ImageSource imageSource = new BitmapImage(new Uri(imagePath));

			ProductModel product =  new ProductModel(shortName, fullName, description, price, imageName, imageSource, category, rating, count);

			return Result.Success(product);
		}

		//public void CreateImageSource(string imageName)
		//{
		//	string currentDirectory = AppDomain.CurrentDomain.BaseDirectory;

		//	string assetsDirectory = Path.Combine(currentDirectory, "..", "..", "Assets", "pizza");
		//	string imagePath = Path.Combine(assetsDirectory, imageName);

		//	if (string.IsNullOrEmpty(imageName) || !Directory.Exists(assetsDirectory))
		//	{
		//		return;
		//	}

		//	ImageSource = new BitmapImage(new Uri(imagePath));
		//}
	}
}
