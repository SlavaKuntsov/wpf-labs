using System;
using System.Collections.Generic;
using System.IO;
using System.Windows;

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

		private const string dataPath = "../../Data/Products.json";


		public CatalogViewModel()
		{
			_pageModel = new PageModel();

			//Products = new List<ProductModel>()
			//{
			//	new ProductModel("4 Сыра", "pizzaaa", "оч вкусная пицца", 21, "cheesse.png", Abstractions.ProductAbstraction.PizzaCategories.Pizza, Abstractions.ProductAbstraction.Rating.Four, 14),
			//	new ProductModel("Баварская", "pizzaaa", "оч вкусная пицца", 20, "bav.png", Abstractions.ProductAbstraction.PizzaCategories.Pizza, Abstractions.ProductAbstraction.Rating.Four, 14),
			//	new ProductModel("Карбонара", "pizzaaa", "оч вкусная пицца", 18, "karb.png", Abstractions.ProductAbstraction.PizzaCategories.Pizza, Abstractions.ProductAbstraction.Rating.Four, 14),
			//	new ProductModel("Пепперони", "pizzaaa", "оч вкусная пицца", 13, "pep.png", Abstractions.ProductAbstraction.PizzaCategories.Pizza, Abstractions.ProductAbstraction.Rating.Four, 14),
			//	new ProductModel("Пепперони", "pizzaaa", "оч вкусная пицца", 13, "pep.png", Abstractions.ProductAbstraction.PizzaCategories.Pizza, Abstractions.ProductAbstraction.Rating.Four, 14),
			//	new ProductModel("Пепперони", "pizzaaa", "оч вкусная пицца", 13, "pep.png", Abstractions.ProductAbstraction.PizzaCategories.Pizza, Abstractions.ProductAbstraction.Rating.Four, 14),
			//};

			JsonSerializerSettings options = new JsonSerializerSettings
			{
				Formatting = Formatting.Indented,
				NullValueHandling = NullValueHandling.Ignore
			};

			if (File.Exists(dataPath))
			{
				string jsonRead = File.ReadAllText(dataPath);
				Products = JsonConvert.DeserializeObject<List<ProductModel>>(jsonRead, options);

				string jsonWrite = JsonConvert.SerializeObject(Products, Formatting.Indented);
				File.WriteAllText(dataPath, jsonWrite);
			}
			else
			{
				Console.WriteLine("NOT EXIST");
				MessageBox.Show("NOT EXIST");
			}
		}
	}
}