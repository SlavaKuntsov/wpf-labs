using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

using _4.MVVM.ViewModel;

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

			DataContext = modal;
		}

		private void Rectangle_MouseDown(object sender, MouseButtonEventArgs e)
		{
			this.Visibility = Visibility.Collapsed;
		}
		private void Rectangle_MouseDown(object sender, RoutedEventArgs e)
		{
			this.Visibility = Visibility.Collapsed;
		}
	}
}
