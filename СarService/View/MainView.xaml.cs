using System.Windows;
using System.Windows.Controls;

namespace СarService.View
{
	/// <summary>
	/// Логика взаимодействия для MainView.xaml
	/// </summary>
	public partial class MainView : Page
	{
		public MainView()
		{
			InitializeComponent();
		}

		private void OnShowAutopartButtonClick(object sender, RoutedEventArgs e)
		{
			Helper.Navigation.Content = new ResultView();
		}

		private void OnExitButtonClick(object sender, RoutedEventArgs e)
		{
			Application.Current.Shutdown();
		}
	}
}
