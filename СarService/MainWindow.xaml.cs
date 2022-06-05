using System.Windows;
using СarService.View;

namespace СarService
{
	/// <summary>
	/// Логика взаимодействия для MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		public MainWindow()
		{
			InitializeComponent();
			navFrame.Content = new MainView();
			Helper.Navigation = navFrame;
		}
	}
}
