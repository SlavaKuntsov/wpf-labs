using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Windows.Input;
using System.Windows.Media;

using _4.MVVM.Model;
using _4.Utilities;

using static _4.Abstractions.ProductAbstraction;

namespace _4.MVVM.ViewModel
{
	public class CatalogViewModel : Utilities.BaseViewModel
	{
		private readonly PageModel _pageModel;
		private DataManager _dataManager;

		//public Dictionary<PizzaCategories, string> PizzaCategoryDictionary { get; set; }
		//JsonActions json = new JsonActions();


		public CatalogViewModel()
		{
			_pageModel = new PageModel();
			_dataManager = DataManager.Instance;

			Products = _dataManager.GetAllProducts();
			Products.CollectionChanged += Products_CollectionChanged;

			//var products = json.GetAllProducts();

			//if (products.IsFailure)
			//{
			//	Products = null;
			//	Console.WriteLine(products.Error);
			//}

			//Products = products.Value;
		}

		private void Products_CollectionChanged(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
		{
			Console.WriteLine("ИЗМЕНЕН-------------------------------------");
			Products = _dataManager.GetAllProducts();
		}

		public ObservableCollection<ProductModel> Products
		{
			get { return _pageModel.Products; }
			set { _pageModel.Products = value; OnPropertyChanged(nameof(Products)); }
		}
	}
}