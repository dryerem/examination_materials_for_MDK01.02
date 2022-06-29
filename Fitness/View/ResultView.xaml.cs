using ExcelDataReader;
using Fitness.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Windows;
using System.Windows.Controls;

namespace Fitness.View
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
			Emloyees = LoadEmloyeeData();
			DataContext = this;
		}

		public List<Emloyee> Emloyees { get; set; }

		private List<Emloyee> LoadEmloyeeData()
		{
			FileStream stream = File.Open(Environment.CurrentDirectory + "/emloyees.xlsx", FileMode.Open, FileAccess.Read);

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

			List<Emloyee> emloyees = new List<Emloyee>();
			for (int row = 0; row < dataTable.Rows.Count; row++)
			{
				Emloyee emloyee = new Emloyee
				{
					Name = dataTable.Rows[row][0].ToString(),
					LastName = dataTable.Rows[row][1].ToString(),
					Patronymic = dataTable.Rows[row][2].ToString(),
					Age = int.Parse(dataTable.Rows[row][3].ToString()),
					DateOfBirdth = DateTime.ParseExact(dataTable.Rows[row][4].ToString(), "dd.MM.yyyy",
					 System.Globalization.CultureInfo.InvariantCulture),
					Salary = double.Parse(dataTable.Rows[row][5].ToString()),
					Position = dataTable.Rows[row][6].ToString(),
				};
				emloyees.Add(emloyee);
			}
			_excelDataReader.Close();

			return emloyees;
		}

		private void OnBackButtonClick(object sender, RoutedEventArgs e)
		{
			Helper.Navigation.Content = new MainView();
		}
	}
}
