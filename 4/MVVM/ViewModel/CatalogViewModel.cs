using System.Collections.Generic;
using System.IO;

using _4.MVVM.Model;

using Newtonsoft.Json;

namespace _4.MVVM.ViewModel
{
	public class CatalogViewModel : Utilities.BaseViewModel
	{
		private readonly PageModel _pageModel;
		public List<ProductModel> Products
		{
			get { return _pageModel.Products; }
			set { _pageModel.Products = value; OnPropertyChanged(nameof(Products)); }
		}

		public const string dataPath = "../../Data/Products.json";


		public CatalogViewModel()
		{
			_pageModel = new PageModel();

			//Products = new List<ProductModel>()
			//{
			//	new ProductModel("4 Сыра", "pizzaaa", "оч вкусная пицца", 21, "cheesse.png", Abstractions.ProductAbstraction.Category.Pizza, Abstractions.ProductAbstraction.Rating.Four, 14),
			//	new ProductModel("Баварская", "pizzaaa", "оч вкусная пицца", 20, "bav.png", Abstractions.ProductAbstraction.Category.Pizza, Abstractions.ProductAbstraction.Rating.Four, 14),
			//	new ProductModel("Карбонара", "pizzaaa", "оч вкусная пицца", 18, "karb.png", Abstractions.ProductAbstraction.Category.Pizza, Abstractions.ProductAbstraction.Rating.Four, 14),
			//	new ProductModel("Пепперони", "pizzaaa", "оч вкусная пицца", 13, "pep.png", Abstractions.ProductAbstraction.Category.Pizza, Abstractions.ProductAbstraction.Rating.Four, 14),
			//	new ProductModel("Пепперони", "pizzaaa", "оч вкусная пицца", 13, "pep.png", Abstractions.ProductAbstraction.Category.Pizza, Abstractions.ProductAbstraction.Rating.Four, 14),
			//	new ProductModel("Пепперони", "pizzaaa", "оч вкусная пицца", 13, "pep.png", Abstractions.ProductAbstraction.Category.Pizza, Abstractions.ProductAbstraction.Rating.Four, 14),
			//};


			// Запись
			//string json = JsonConvert.SerializeObject(Products, Formatting.Indented);
			//File.WriteAllText(dataPath, json);


			// Чтение
			//string json = File.ReadAllText(dataPath);
			//Products = JsonConvert.DeserializeObject<List<ProductModel>>(json);




			JsonSerializerSettings options = new JsonSerializerSettings
			{
				Formatting = Formatting.Indented,
				NullValueHandling = NullValueHandling.Ignore
			};



			if (File.Exists(dataPath))
			{
				string jsonRead = File.ReadAllText(dataPath);
				Products = JsonConvert.DeserializeObject<List<ProductModel>>(jsonRead, options);

				foreach (var product in Products)
				{
					product.CreateImageSource(product.Image);
					System.Console.WriteLine(product.ImageSource);
				}

				string jsonWrite = JsonConvert.SerializeObject(Products, Formatting.Indented);
				File.WriteAllText(dataPath, jsonWrite);
			}
			else
			{
				System.Console.WriteLine("NOT EXIST");
			}
		}
	}
}