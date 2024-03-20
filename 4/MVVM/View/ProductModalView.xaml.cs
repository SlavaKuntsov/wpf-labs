using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

using _4.Abstractions;
using _4.MVVM.Model;
using _4.MVVM.ViewModel;

using static _4.Abstractions.ProductAbstraction;

namespace _4.MVVM.View
{
	/// <summary>
	/// Логика взаимодействия для ProductModal.xaml
	/// </summary>
	public partial class ProductModalView : UserControl
	{
		ProductModalViewModel modal;
		public ProductModalView()
		{
			InitializeComponent();

			//var productAbstraction = new ProductAbstraction();
			//var PizzaSizesDictionary = productAbstraction.PizzaSizesDictionary;

			//modal = new ProductModalViewModel(PizzaSizesDictionary);
			DataContext = modal;
		}

		private void Rectangle_MouseDown(object sender, MouseButtonEventArgs e)
		{
			this.Visibility = Visibility.Collapsed;
		}
	}
}
