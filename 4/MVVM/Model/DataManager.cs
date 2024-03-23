using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using _4.Utilities;

namespace _4.MVVM.Model
{
	public class DataManager
	{
		JsonActions json = new JsonActions();

		private static DataManager instance;
		private ObservableCollection<ProductModel> _products;

		public DataManager()
		{
			_products = new ObservableCollection<ProductModel>();

			ReadData();

			Console.WriteLine("load data length:" + _products.Count);
		}

		public static DataManager Instance
		{
			get
			{
				if (instance == null)
				{
					instance = new DataManager();
				}
				return instance;
			}
		}

		public void AddProduct(ProductModel product)
		{
			Console.WriteLine("add prod: " + product.ShortName);
			_products.Add(product);

			json.WriteNewProduct(product);
		}

		public void DeleteProduct(Guid id)
		{
			ProductModel product = _products.First(x => x.Id == id);

			Console.WriteLine("delete prod: " + product.Id);
			_products.Remove(product);

			List<ProductModel> productsList = new List<ProductModel>();

			foreach(var item in _products)
			{
				productsList.Add(item);
			}

			json.WriteAllProducts(productsList);
		}

		public ObservableCollection<ProductModel> GetAllProducts()
		{
			return _products;
		}

		private void ReadData()
		{
			var products = json.GetAllProducts();

			if (products.IsFailure)
			{
				return;
			}
			Console.WriteLine("load data:");
			foreach (var item in products.Value)
			{
				Console.WriteLine("load item: " + item.ShortName);
				_products.Add(item);
			}
		}
	}
}
