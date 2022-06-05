# examination_materials_for_MDK01.02
Экзаменационные материалы для МДК 01.02

[Beaty - VAR 12]

- В файле ResultView.xaml.cs раскомментировать 23 строчку (DataContext = this) - отвечает за привязку данных к форме
- В файле ResultView.xaml.cs в цикле заменить <= на < (выход за пределы диапазона)
- В файле ResultView.xaml.cs в строке 53 неверный формат даты (ddMMyyyy) из-за чего будет краш, исправить на dd.MM.yyyy или
dd,MM,yyyy в зависимости от локали винды

[Fitness - VAR 14]
 
- В файле Emloyee.cs пропущена буква в слова Age (Ag)
- В файле Helper.cs не подключена ссылка (using System.Windows.Controls;)
- В файле MainView.xaml.cs в методе OnShowEmloyesButtonClick заменить new MainView() на ResultView
- В файле ResultView.xaml.cs исправить название пространства имен (Fitnessss > Fitness)

[Gardener - VAR 11]

- Подключить библиотеки ExcelDataReader.dll и ExcelDataReader.DataSet.dll (лежат в папке bin/Debug)
- В файле ResultView.xaml.cs раскомментировать строку 23 
- В файле ResultView.xaml.cs в строке 30 заменить Assembly.GetExecutingAssembly().Location на Environment.CurrentDirectory
(в первом случае путь включает имя exe файла, во втором текущая директория, где исполняется программа)

[Pawnshop - VAR 10]

- В файле ResultView.xaml.cs раскомментировать 23 строчку (DataContext = this) - отвечает за привязку данных к форме
- В файле ResultView.xaml.cs в цикле заменить <= на < (выход за пределы диапазона)
- В файле ResultView.xaml.cs в строке 17 в имени переменной русская с, заменить на англ
- В файле ResultView.xaml.cs свойство должно возвращать список (public Pledge Pledges { get; set; } > public List<Pledge> Pledges { get; set; })
- В файле ResultView.xaml.cs в строке 56 строка должна кастится к даблу (double.Parse(...))

[Stomatology - VAR 13]

- В файле ResultView.xaml в 1 строке указать корректное имя класса (должно соотестовать названию класса в ResultView.xaml.cs)
Подключить библиотеки ExcelDataReader.dll и ExcelDataReader.DataSet.dll (лежат в папке bin/Debug)
- В файле Helper.cs добавить модификатор static после public
- В файле ResultView.xaml исправить цикл, исправить row = 1 на row = 0
- В файле ResultView.xaml в строках 50-53 добавить .ToString()

[CarService - VAR 20 | 9]

- Подключить библиотеки ExcelDataReader.dll и ExcelDataReader.DataSet.dll (лежат в папке bin/Debug)
- В файле Helper.cs добавить модификатор static после public
- В файле App.xaml исправить StartupUri на MainWindow.xaml (убрать лишнюю w в конце)
- В файле ResultView.xaml в строках 50-53 добавить .ToString()
