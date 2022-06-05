using ExcelDataReader;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Windows;
using System.Windows.Controls;
using СarService.Model;

namespace СarService.View
{
	/// <summary>
	/// Логика взаимодействия для ResultView.xaml
	/// </summary>
	public partial class ResultView : Page
	{
		private IExcelDataReader _excelDataReader;

		public ResultView()
		{
			InitializeComponent();
			Autoparts = LoadAutopartData();
			DataContext = this;
		}

		public List<Autopart> Autoparts { get; set; }

		private List<Autopart> LoadAutopartData()
		{
			FileStream stream = File.Open(Environment.CurrentDirectory + "/autopart.xlsx", FileMode.Open, FileAccess.Read);

			_excelDataReader = ExcelReaderFactory.CreateOpenXmlReader(stream);

			var conf = new ExcelDataSetConfiguration
			{
				ConfigureDataTable = _ => new ExcelDataTableConfiguration
				{
					UseHeaderRow = false
				}
			};

			DataSet dataSet = _excelDataReader.AsDataSet(conf);
			DataTable dataTable = dataSet.Tables[0];

			List<Autopart> autoparts = new List<Autopart>();
			for (int row = 0; row < dataTable.Rows.Count; row++)
			{
				Autopart autopart = new Autopart
				{
					Name = dataTable.Rows[row][0],
					Auto = dataTable.Rows[row][1],
					Cost = double.Parse(dataTable.Rows[row][2]),
				};
				autoparts.Add(autopart);
			}
			_excelDataReader.Close();

			return autoparts;
		}

		private void OnBackButtonClick(object sender, RoutedEventArgs e)
		{
			Helper.Navigation.Content = new MainView();
		}
	}
}
