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
		public Guid Id { get; set; }
		public string ShortName { get; set; }
		public string FullName { get; set; }
		public string Description { get; set; }
		public double Price { get; set; }
		public string Image { get; set; }
		public ImageSource ImageSource { get; set; }
		public PizzaCategories Category { get; set; }
		public PizzaSizes Size { get; set; }
		public Rating Rating { get; set; }
		public List<int> StringRating { get; set; } = new List<int>();

		public int Count { get; set; }
		public bool InStock { get; set; }

		public ProductModel() { }

		public ProductModel(Guid id, string shortName, string fullName, string description, double price, string imageName, ImageSource imageSource, PizzaCategories category, PizzaSizes size, Rating rating, int count)
		{
			Id = id;
			ShortName = shortName;
			FullName = fullName;
			Description = description;
			Price = price;
			Image = imageName;
			ImageSource = imageSource;
			Category = category;
			Size = size;
			Rating = rating;
			Count = count;
			InStock = count > 0;

			switch (rating)
			{
				case Rating.None:
					break;
				case Rating.One:
					StringRating.Add(1);
					break;
				case Rating.Two:
					StringRating.AddRange(new int[] { 1, 2 });
					break;
				case Rating.Three:
					StringRating.AddRange(new int[] { 1, 2, 3 });
					break;
				case Rating.Four:
					StringRating.AddRange(new int[] { 1, 2, 3, 4 });
					break;
				case Rating.Five:
					StringRating.AddRange(new int[] { 1, 2, 3, 4, 5 });
					break;
			}
		}

		public static Result<ProductModel> Create(Guid id, string shortName, string fullName, string description, double price, string imageName, PizzaCategories category, PizzaSizes size, Rating rating, int count)
		{
			Console.WriteLine("create rating: " + rating);
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

			if (string.IsNullOrWhiteSpace(imageName))
			{
				imageName = "default.png";
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

			ProductModel product =  new ProductModel(id, shortName, fullName, description, price, imageName, imageSource, category, size, rating, count);

			return Result.Success(product);
		}
	}
}
