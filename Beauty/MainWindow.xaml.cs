using Beauty.View;
using System.Windows;

namespace Beauty
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
