using Gardener.View;
using System.Windows;

namespace Gardener
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
