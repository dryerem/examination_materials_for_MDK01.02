   M S B A M L   `   `   `  ����B  >Fitness, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:Fitness.ViewFitness.View  5          Fitness.View.ResultView   5      W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      ,localclr-namespace:Fitness.View     5        N� Title$  
ResultView��5	       N� 
Background
 �����.��5      ]� ��. $��10q�6%   .+�5   
   � $	��Top=�6   $��0, 10, 0, 10q�6$   .+�5      �� -   5        $��
Назад��5      $��70��6%   $��35��60   $
��Left=�6<   $��10, 0, 0, 0q�6W   6l   �� 5      $)��#Список сотрудников��6   $��Center=�62   $��Center=�6O   $��24(�6j   5      &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ 
ResultGrid��5         AutoGenerateColumns .  ��6C   �� *
Emloyees+   Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ Имя��6%   1  +System.Windows.Controls.DataGridBoundColumn   Binding 62   �� *Name+  5      $ Фамилия��6%    66   �� *
LastName+  5      $ Отчество��6%    67   �� *
Patronymic+  5      $ Возраст��6%    66   �� *Age+  5      $ Дата рождения��6%    6<   �� *DateOfBirdth+  5      $ Зарплата��6%    67   �� *Salary+  5      $ Должность��6%    68   �� *
Position+5      5      5      