# examination_materials_for_MDK01.02
Экзаменационные материалы для МДК 01.02

# Подсказки
1) Helper.cs должен выглядеть так:

```cpp
public static class Helper
{
    public static Frame Navigation { get; set; }
}
```

класс и поле должны быть с модификатором static! 

2) Все сторонние либы (dll файлы) лежат в папке bin/Debug в каждом проекте. Подключать их нужно через ссылки в обозревателе решений

3) В Pawnshop можно просто скопировать имя переменной, которая объявлена в классе и заменить (дальше по коду встречается русская буква в имени переменной вместо англ)

4) Все файлы с расширением .xaml это или страницы приложения, окно имеет имя MainWindow.xaml. Все .xaml файлы раскрпываются по анлогии с вин формами и можно увидеть .xaml.cs файлы - файлы с кодом. Смотреть туда. 

5) Все закоментированные строки должны быть раскомментированы 

# Ошибки

[Beaty - VAR 12]

- В файле ResultView.xaml.cs раскомментировать 23 строчку (DataContext = this) - отвечает за привязку данных к форме
- В файле ResultView.xaml.cs в цикле заменить <= на < (выход за пределы диапазона)
- В файле ResultView.xaml.cs в строке 53 неверный формат даты (ddMMyyyy) из-за чего будет краш, исправить на dd.MM.yyyy (потому что в файле экселя дата через точку)

[Fitness - VAR 14]
 
- В файле Emloyee.cs пропущена буква в слова Age (Ag)
- В файле Helper.cs не подключена ссылка (using System.Windows.Controls;)
- В файле MainView.xaml.cs в методе OnShowEmloyesButtonClick заменить new MainView() на ResultView

[Gardener - VAR 11]

- Подключить библиотеки ExcelDataReader.dll и ExcelDataReader.DataSet.dll (лежат в папке bin/Debug)
- В файле ResultView.xaml.cs раскомментировать строку 23 
- В файле ResultView.xaml.cs в строке 30 Assembly.GetExecutingAssembly().Location возвращает путь к исполняемому файлу. Решается несколькими способами, один из которых относительный путь. Можно просто оставить имя файла. 

[Pawnshop - VAR 10]

- В файле ResultView.xaml.cs раскомментировать 23 строчку (DataContext = this) - отвечает за привязку данных к форме
- В файле ResultView.xaml.cs в цикле заменить <= на < (выход за пределы диапазона)
- В файле ResultView.xaml.cs в строке 17 в имени переменной русская с, заменить на англ
- В файле ResultView.xaml.cs свойство должно возвращать список (public Pledge Pledges { get; set; } > public List<Pledge> Pledges { get; set; })
- В файле ResultView.xaml.cs в строке 56 строка должна кастится к даблу (double.Parse(...))

[Stomatology - VAR 13]

Подключить библиотеки ExcelDataReader.dll и ExcelDataReader.DataSet.dll (лежат в папке bin/Debug)
- В файле Helper.cs добавить модификатор static после public
- В файле ResultView.xaml исправить цикл, исправить row = 1 на row = 0
- В файле ResultView.xaml в строках 50-53 добавить .ToString()

[CarService - VAR 20 | 9]

- Подключить библиотеки ExcelDataReader.dll и ExcelDataReader.DataSet.dll (лежат в папке bin/Debug)
- В файле Helper.cs добавить модификатор static после public
- В файле ResultView.xaml в строках 50-53 добавить .ToString()
