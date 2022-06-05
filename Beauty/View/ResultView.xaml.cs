using Beauty.Models;
using ExcelDataReader;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Windows;
using System.Windows.Controls;

namespace Beauty.View
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
			Clients = LoadClientsData();
			//DataContext = this;
		}

		public List<Client> Clients { get; set; }

		private List<Client> LoadClientsData()
		{
			FileStream stream = File.Open(Environment.CurrentDirectory + "/entryes_of_clients.xlsx", FileMode.Open, FileAccess.Read);

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

			List<Client> clients = new List<Client>();
			for (int row = 0; row <= dataTable.Rows.Count; row++)
			{
				Client client = new Client
				{
					Name = dataTable.Rows[row][0].ToString(),
					LastName = dataTable.Rows[row][1].ToString(),
					Patronymic = dataTable.Rows[row][2].ToString(),
					DateOfEntry = DateTime.ParseExact(dataTable.Rows[row][3].ToString(), "ddMMyyyy",
					 System.Globalization.CultureInfo.InvariantCulture),
					ServiceType = dataTable.Rows[row][4].ToString(),
				};
				clients.Add(client);
			}
			_excelDataReader.Close();

			return clients;
		}

		private void OnBackButtonClick(object sender, RoutedEventArgs e)
		{
			Helper.Navigation.Content = new MainView();
		}
	}
}
