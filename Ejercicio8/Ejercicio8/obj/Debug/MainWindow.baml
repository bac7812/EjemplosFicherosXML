   M S B A M L   `   `   `  ����E  AEjercicio8, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:Ejercicio8
Ejercicio8  5   	       Ejercicio8.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   *localclr-namespace:Ejercicio8     5   	   -   5          �Name$  
Biblioteca��5   	    � Title$ 
Biblioteca��5   	   $	��360��6   $	��620��6)   .��5	      � $��10q�6    � ColumnDefinitions 5
   
   �� 5      $��85 �6   6,   �� 5      $��85 �6   6,   �� 5      $��85 �6   6,   �� 5      6!   �� 5      $��85 �6   6,    � RowDefinitions 5   
   �� 5      $��40 �6   6*   �� 5      6   .+�5   
   �� -   5         ��Name$ anadirButton��5      $��Añadir��6'   $
��Left=�68   $��5q�6S   $	��Top=�6^   $��75��6v   $��0��6�   $��0��6�   6�   �� 5   
   -   5        $ modificarButton��5      $��	Modificar��6*   $
��Left=�6>   $��5q�6Y   $	��Top=�6d   $��75��6|   $��1��6�   $��0��6�   6�   �� 5   
   -   5        $ eliminarButton��5      $��Eliminar��6)   $
��Left=�6<   $��5q�6W   $	��Top=�6b   $��75��6z   $��2��6�   $��0��6�   6�   �� 5   
   -   5         ��Name$ buscarTextBox��5      $��Right=�6)   $��5q�6E    �� TextWrapping$
 Wrap=�6P   $	��Top=�6d   $	��159��6|   $��23��6�   $��14(�6�   $��3��6�   $��0��6�   �� 5   
   -   5        $ buscarButton��5      $��Buscar��6'   $
��Left=�68   $��5q�6S   $	��Top=�6^   $��75��6v   $��4��6�   $��0��6�   6�   &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ datosDataGrid��5      $
��Left=�6*   $��5q�6E   $	��Top=�6P   $	��250��6h   $	��570��6u   $��0��6�   $��5��6�   $��1��6�      AutoGenerateColumns .  	   Columns	 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn
   Header$
 Codigo��6%   1  +System.Windows.Controls.DataGridBoundColumn   Binding 65   �� *Codigo+  5       $
 Nº de ejemplares��6%    6?   �� *NumEjemplares+  5!      $

 ISBN��6%    63   �� *Isbn+  5"      $
 Título��6%    65   �� *Titulo+  5#      $
 Autor��6%    64   �� *Autor+  5$      $
 Descripción��6%    6:   �� *Descripcion+5&      5(      5)      