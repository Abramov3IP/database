   M S B A M L   `   `   `  ����A  =KingIT, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:KingITKingIT  5   	       KingIT.Admin   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   &localclr-namespace:KingIT     5   	     � Title$  Admin��5   	   $	��450��6   $��720.931��6$   .��5	      � $��0,0,2,0q�6   .+�5
   
   &   System.Windows.Controls.DataGrid  -   5        $��	AdminGrid��5
      $
��Left=�6$   $	��327��6?   $��	36,23,0,0q�6L   $	��Top=�6_   $	��642��6w      AutoGenerateColumns .     
IsReadOnly .    Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ Фамилия��6%      Width5  /System.Windows.Controls.DataGridLengthConverter$ 90 6W   1  +System.Windows.Controls.DataGridBoundColumn   Binding 66   ��  �� Path$ Surname�6W     5      $ Имя��6%   $ 90 6P    62   �� $
 Name�6P     5      $ Отчество��6%   $ 90 6[    67   �� $ 
Patronymic�6[   5  /System.Windows.Controls.DataGridHyperlinkColumn  5      $ 
Логин��6*   $ 80 6X    69   �� $ Login�6X     5      $ Пароль��6%   $ 50 6W    65   �� $ Password�6W     5      $ Пол��6%   $ 90 6R    62   �� $ Gender�6R     5      $ Телефон��6%   $ 90 6W    66   �� $ TeleNum�6W    � ContextMenu 5      �� 5      .@�5      m� -   5        $��Удалить��5      60   m� 5      -   5        $ ��Редактировать��5      66   m� 5      -   5        $��Добавить��5      61   5      5      �� 5   
   -   5        $��SearchTextBox��5      $
��Left=�6'   $��30��6B   $��
36,366,0,0q�6N   	 �� TextWrapping$
	 Wrap=�6b   $�� ��6v   $	��Top=�6~   $	��248��6�   6�   �� 5   
   $��
Поиск��6   $
��Left=�6    $��289,366,0,0q�6;   $	��Top=�6P   $��30��6h   $��70��6t   $��18(�6   5      5       