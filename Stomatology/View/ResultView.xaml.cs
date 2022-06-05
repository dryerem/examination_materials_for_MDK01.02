using ExcelDataReader;
using Stomatology.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Windows;
using System.Windows.Controls;

namespace Stomatology.View
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
			Equipments = LoadEquipmentData();
			DataContext = this;
		}

		public List<Equipment> Equipments { get; set; }

		private List<Equipment> LoadEquipmentData()
		{
			FileStream stream = File.Open(Environment.CurrentDirectory + "/equipment.xlsx", FileMode.Open, FileAccess.Read);

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

			List<Equipment> equipments = new List<Equipment>();
			for (int row = 1; row < dataTable.Rows.Count; row++)
			{
				Equipment equipment = new Equipment
				{
					Name = dataTable.Rows[row][0],
					InventoryNumber = dataTable.Rows[row][1],
					Cab = int.Parse(dataTable.Rows[row][2]),
					Count = int.Parse(dataTable.Rows[row][3]),
				};
				equipments.Add(equipment);
			}
			_excelDataReader.Close();

			return equipments;
		}

		private void OnBackButtonClick(object sender, RoutedEventArgs e)
		{
			Helper.Navigation.Content = new MainView();
		}
	}
}
