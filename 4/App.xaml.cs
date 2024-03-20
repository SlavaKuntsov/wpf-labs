using System;
using System.Windows;

using _4.MVVM.ViewModel;

using Microsoft.Extensions.DependencyInjection;

namespace _4
{
	public partial class App : Application
	{
		protected override void OnStartup(StartupEventArgs e)
		{
			base.OnStartup(e);

			MainWindow mainWindow = new MainWindow();
			mainWindow.Show();
		}
	}
}