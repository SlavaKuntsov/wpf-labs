using System;
using System.Collections.Generic;
using System.Windows.Input;

using _4.Abstractions;
using _4.MVVM.Model;
using _4.Utilities;

namespace _4.MVVM.ViewModel
{
	public class ProductModalViewModel : BaseViewModel
	{
		public ICommand DeleteCommand { get; set; }

		public Dictionary<ProductAbstraction.PizzaSizes, string> PizzaSizesDictionary { get; set; }
		public event EventHandler CloseRequested;

		private ProductModel _product;
		public ProductModel Product
		{
			get { return _product; }
			set { _product = value; OnPropertyChanged(nameof(Product)); }
		}

		public ProductModalViewModel(ProductModel product, Dictionary<ProductAbstraction.PizzaSizes, string> pizzaSizesDictionary)
		{
			Product = product;
	
			PizzaSizesDictionary = pizzaSizesDictionary;

			DeleteCommand = new RelayCommand(Delete);
		}

		private void Delete(object obj)
		{
			DataManager.Instance.DeleteProduct(_product.Id);

			Console.WriteLine("Элемент успешно удален из JSON.");
		}
	}
}
