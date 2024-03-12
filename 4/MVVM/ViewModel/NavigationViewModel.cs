using System.Windows.Input;

using _4.Utilities;

namespace _4.MVVM.ViewModel
{
	internal class NavigationViewModel : BaseViewModel
	{
		private object _currentView;
		public object CurrentView
		{
			get { return _currentView; }
			set { _currentView = value; OnPropertyChanged(nameof(CurrentView)); }
		}

		public ICommand HomeCommand { get; set; }
		public ICommand CatalogCommand { get; set; }

		private void Home(object obj) => CurrentView = new HomeViewModel();
		private void Catalog(object obj) => CurrentView = new CatalogViewModel();

		public NavigationViewModel()
		{
			HomeCommand = new RelayCommand(Home);
			CatalogCommand = new RelayCommand(Catalog);

			// Startup Page
			//CurrentView = new CatalogViewModel();
			CurrentView = new HomeViewModel();
		}
	}
}
