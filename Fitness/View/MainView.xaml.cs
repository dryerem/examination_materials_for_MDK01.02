using System.Windows;
using System.Windows.Controls;

namespace Fitness.View
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

		private void OnShowEmloyesButtonClick(object sender, RoutedEventArgs e)
		{
			Helper.Navigation.Content = new MainView();
		}

		private void OnExitButtonClick(object sender, RoutedEventArgs e)
		{
			Application.Current.Shutdown();
		}
	}
}
