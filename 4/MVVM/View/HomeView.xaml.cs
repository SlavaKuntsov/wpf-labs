using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

using _4.MVVM.ViewModel;

namespace _4.MVVM.View
{
	public partial class HomeView : UserControl
	{
		HomeViewModel home = new HomeViewModel();
		public HomeView()
		{
			InitializeComponent();

			DataContext = home;
		}
	}
}
