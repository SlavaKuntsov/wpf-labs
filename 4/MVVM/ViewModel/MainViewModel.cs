using System.Collections.ObjectModel;
using _4.MVVM.Model;

namespace _4.MVVM.ViewModel
{
	public class MainViewModel
	{
		private ObservableCollection<ProductModel> Products { get; set; }

		public MainViewModel()
		{
			//Products = new ObservableCollection<ProductModel>();

			//for (int i = 0; i < 5; i++)
			//{
			//	Products.Add(new ProductModel
			//	{
			//		Name = $"Name {i}",
			//		Price = i
			//	});
			//}
		}
	}
}
