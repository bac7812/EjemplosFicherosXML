   M S B A M L   `   `   `  ����E  AEjercicio6, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:Ejercicio6
Ejercicio6  5   	       Ejercicio6.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   *localclr-namespace:Ejercicio6     5   	   -   5          �Name$  Libros��5   	    � Title$ Libros��5   	   $	��370��6   $	��600��6%    � 
ResizeMode$ NoResize=�61   .��5	      � $��10q�6    � ColumnDefinitions 5
   
   �� 5      $	��100 �6   6-   �� 5      6!    � RowDefinitions 5   
   �� 5      $��50 �6   6*   �� 5      6   .+�5   
   �� -   5         ��Name$ 	VerButton��5      $	��Ver��6$   $
��Left=�62   $��5q�6M   $��Bottom=�6X   $��75��6s   $��0��6~   $��0��6�   6�   �� 5   
   -   5        $ anadirButton��5      $��Añadir��6'   $
��Left=�68   $��5q�6S   $	��Top=�6^   $��75��6v   $��0��6�   $��1��6�   6�   &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ DatosDataGrid��5      $
��Left=�6*   $��5q�6E   $	��Top=�6P   $	��450��6h   $	��300��6t   $��1��6�   $��2��6�   $��0��6�      AutoGenerateColumns .     Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn	   Header$	 Codigo��6%   1  +System.Windows.Controls.DataGridBoundColumn
   Binding
 65   �� *Codigo+  5      $	 Nº de ejemplares��6%   
 6?   �� *NumEjemplares+  5      $
	 ISBN��6%   
 63   �� *Isbn+  5      $	 Título��6%   
 65   �� *Titulo+  5      $	 Autor��6%   
 64   �� *Autor+  5      $	 Descripción��6%   
 6:   �� *Descripcion+5      5!      5"      