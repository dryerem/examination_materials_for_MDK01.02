using ExcelDataReader;
using Gardener.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Windows;
using System.Windows.Controls;

namespace Gardener.View
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
			Plots = LoadPlotsData();
			//DataContext = this;
		}

		public List<Plot> Plots { get; set; }

		private List<Plot> LoadPlotsData()
		{
			FileStream stream = File.Open(Assembly.GetExecutingAssembly().Location + "/plots.xlsx", FileMode.Open, FileAccess.Read);

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

			List<Plot> plots = new List<Plot>();
			for (int row = 0; row < dataTable.Rows.Count; row++)
			{
				Plot plot = new Plot
				{
					Site = dataTable.Rows[row][0].ToString(),
					Renter = dataTable.Rows[row][1].ToString(),
					Debt = double.Parse(dataTable.Rows[row][2].ToString()),
					Address = dataTable.Rows[row][3].ToString()
				};
				plots.Add(plot);
			}
			_excelDataReader.Close();

			return plots;
		}

		private void OnBackButtonClick(object sender, RoutedEventArgs e)
		{
			Helper.Navigation.Content = new MainView();
		}
	}
}
