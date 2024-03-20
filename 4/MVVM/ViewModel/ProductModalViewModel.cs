using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using _4.Abstractions;
using _4.MVVM.Model;
using _4.Utilities;

namespace _4.MVVM.ViewModel
{
	public class ProductModalViewModel : BaseViewModel
	{
		private ProductModel _products;
		public ProductModel Product
		{
			get { return _products; }
			set { _products = value; OnPropertyChanged(nameof(Product)); }
		}
		public Dictionary<ProductAbstraction.PizzaSizes, string> PizzaSizesDictionary { get; set; }

		public ProductModalViewModel(ProductModel product, Dictionary<ProductAbstraction.PizzaSizes, string> pizzaSizesDictionary)
		{
			Product = product;
			PizzaSizesDictionary = pizzaSizesDictionary;
		}
	}
}
