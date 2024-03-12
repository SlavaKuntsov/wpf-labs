using System;
using System.Windows.Controls;
using System.Windows.Input;

namespace _4.MVVM.View
{
	/// <summary>
	/// Логика взаимодействия для ProductCard.xaml
	/// </summary>
	public partial class ProductCardView : UserControl
	{
		public ProductCardView()
		{
			InitializeComponent();
		}

		public void ListViewItem_Click(object sender, MouseButtonEventArgs e)
		{
			ListViewItem item = sender as ListViewItem;
			if (item != null && item.IsSelected)
			{
				Console.WriteLine("MODEL");
			}
		}
	}
}
