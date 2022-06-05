using ExcelDataReader;
using Pawnshop.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Windows;
using System.Windows.Controls;

namespace Pawnshop.View
{
	/// <summary>
	/// Логика взаимодействия для ResultView.xaml
	/// </summary>
	public partial class ResultView : Page
	{
		private IExcelDataReader _exсelDataReader;

		public ResultView()
		{
			InitializeComponent();
			Pledges = LoadPledgesData();
			//DataContext = this;
		}

		public Pledge Pledges { get; set; }

		private List<Pledge> LoadPledgesData()
		{
			FileStream stream = File.Open(Environment.CurrentDirectory + "/pledges.xlsx", FileMode.Open, FileAccess.Read);

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

			List<Pledge> pledges = new List<Pledge>();
			for (int row = 0; row <= dataTable.Rows.Count; row++)
			{
				Pledge pledge = new Pledge
				{
					Name = dataTable.Rows[row][0].ToString(),
					LastName = dataTable.Rows[row][1].ToString(),
					Patronymic = dataTable.Rows[row][2].ToString(),
					Phone = dataTable.Rows[row][3].ToString(),
					Passport = dataTable.Rows[row][4].ToString(),
					Thing = dataTable.Rows[row][5].ToString(),
					Sum = dataTable.Rows[row][6].ToString(),
				};
				pledges.Add(pledge);
			}
			_excelDataReader.Close();

			return pledges;
		}

		private void OnBackButtonClick(object sender, RoutedEventArgs e)
		{
			Helper.Navigation.Content = new MainView();
		}
	}
}
