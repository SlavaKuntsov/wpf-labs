using System.Windows;

using _4.MVVM.ViewModel;

namespace _4
{
	public partial class MainWindow : Window
	{
		readonly NavigationViewModel navigation = new NavigationViewModel();
		public MainWindow()
		{
			InitializeComponent();
		}

		private void DragWindow_MouseDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
		{
			if (e.ChangedButton == System.Windows.Input.MouseButton.Left)
			{
				DragMove();
			}
		}

		private void ButtonMinimize_Click(object sender, RoutedEventArgs e)
		{
			Application.Current.MainWindow.WindowState = WindowState.Minimized;
		}

		private void WindowStateButton_Click(object sender, RoutedEventArgs e)
		{
			if (Application.Current.MainWindow.WindowState != WindowState.Maximized)
			{
				Application.Current.MainWindow.WindowState = WindowState.Maximized;
				//this.MaxHeight = SystemParameters.WorkArea.Height + SystemParameters.BorderWidth * 2;
				//this.MaxWidth = SystemParameters.WorkArea.Width + SystemParameters.BorderWidth * 2;
			}
			else
			{
				Application.Current.MainWindow.WindowState = WindowState.Normal;
			}
		}

		private void CloseButton_Click(object sender, RoutedEventArgs e)
		{
			Application.Current.Shutdown();
		}
	}
}
