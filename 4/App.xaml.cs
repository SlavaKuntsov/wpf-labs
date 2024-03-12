using System.Windows;

using _4.MVVM.ViewModel;

using Microsoft.Extensions.DependencyInjection;

namespace _4
{
	public partial class App : Application
	{
		//private readonly ServiceProvider _serviceProvider;

		//public App()
		//{
		//	IServiceCollection services = new ServiceCollection();

		//	services.AddSingleton<MainWindow>(provider => new MainWindow()
		//	{
		//		DataContext	= provider.GetRequiredService<MainViewModel>()
		//	});
		//	services.AddSingleton<MainViewModel>();
		//	services.AddSingleton<HomeViewModel>();
		//	services.AddSingleton<CatalogViewModel>();

		//	_serviceProvider = services.BuildServiceProvider();
		//}

		protected override void OnStartup(StartupEventArgs e)
		{
			base.OnStartup(e);

			MainWindow mainWindow = new MainWindow();
			mainWindow.Show();
		}
	}
}