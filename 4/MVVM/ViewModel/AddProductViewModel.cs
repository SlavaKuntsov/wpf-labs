using System;
using System.Collections.Generic;
using System.IO;
using System.Windows;
using System.Windows.Input;

using _4.MVVM.Model;
using _4.Utilities;

using Newtonsoft.Json;

using static _4.Abstractions.ProductAbstraction;

namespace _4.MVVM.ViewModel
{
	public class AddProductViewModel : BaseViewModel
	{
		public ICommand SaveCommand { get; set; }
		public Dictionary<PizzaCategories, string> PizzaCategoryDictionary { get; set; }

		private const string dataPath = "../../Data/Products.json";

		public AddProductViewModel(Dictionary<PizzaCategories, string> pizzaCategoryDictionary)
		{
			_product = new ProductModel();
			Category = PizzaCategories.Pizza;

			PizzaCategoryDictionary = pizzaCategoryDictionary;

			SaveCommand = new RelayCommand(Save);
		}

		private void Save(object obj)
		{
			var addedProduct = ProductModel.Create(ShortName, FullName, Description, Price, "cheesse.png", Category, Rating, Count);

			if (addedProduct.IsFailure)
			{
				MessageBox.Show(addedProduct.Error);
				return;
			}

			SaveToFile(addedProduct.Value);
		}

		private void SaveToFile(ProductModel product)
		{
			JsonSerializerSettings options = new JsonSerializerSettings
			{
				Formatting = Formatting.Indented,
				NullValueHandling = NullValueHandling.Ignore
			};

			if (File.Exists(dataPath))
			{
				string jsonRead = File.ReadAllText(dataPath);
				List<ProductModel> products = JsonConvert.DeserializeObject<List<ProductModel>>(jsonRead, options);

				products.Add(product);

				string jsonWrite = JsonConvert.SerializeObject(products, Formatting.Indented);
				File.WriteAllText(dataPath, jsonWrite);
			}
			else
			{
				Console.WriteLine("NOT EXIST");
			}
		}


		private ProductModel _product { get; set; }
		public ProductModel Product
		{
			get { return _product; }
			set { _product = value; OnPropertyChanged(nameof(Product)); }
		}
		public string ShortName
		{
			get { return _product.ShortName; }
			set { _product.ShortName = value; OnPropertyChanged(nameof(ShortName)); }
		}
		public string FullName
		{
			get { return _product.FullName; }
			set { _product.FullName = value; OnPropertyChanged(nameof(FullName)); }
		}
		public string Description
		{
			get { return _product.Description; }
			set { _product.Description = value; OnPropertyChanged(nameof(Description)); }
		}
		public PizzaCategories Category
		{
			get { return _product.Category; }
			set { _product.Category = value; OnPropertyChanged(nameof(Category)); }
		}
		public double SliderValue
		{
			get { return SliderValue; }
			set
			{
				SliderValue = value;
				OnPropertyChanged(nameof(SliderValue));
				Rating convertRating = ConvertSliderValueToRating(value);
				Rating = convertRating;
			}
		}
		public Rating Rating
		{
			get { return _product.Rating; }
			set { _product.Rating = value; OnPropertyChanged(nameof(Rating)); }
		}
		private string _priceString;
		public string PriceString
		{
			get { return _priceString; }
			set
			{
				_priceString = value;
				OnPropertyChanged(nameof(PriceString));
				double convertPrice;
				if (double.TryParse(value, out convertPrice))
				{
					Price = convertPrice;
				}
			}
		}
		public double Price
		{
			get { return _product.Price; }
			set { _product.Price = value; OnPropertyChanged(nameof(Price)); }
		}
		private string _countString;
		public string CountString
		{
			get { return _countString; }
			set
			{
				_countString = value;
				OnPropertyChanged(nameof(CountString));
				int convertCount;
				if (int.TryParse(value, out convertCount))
				{
					Count = convertCount;
				}
			}
		}
		public int Count
		{
			get { return _product.Count; }
			set { _product.Count = value; OnPropertyChanged(nameof(Count)); }
		}

		private Rating ConvertSliderValueToRating(double sliderValue)
		{
			switch (sliderValue)
			{
				case 1:
					return Rating.One;
				case 2:
					return Rating.Two;
				case 3:
					return Rating.Three;
				case 4:
					return Rating.Four;
				case 5:
					return Rating.Five;
				default:
					return Rating.None;
			}
		}
	}
}