   M S B A M L   `   `   `  ����E  AEjercicio3, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:Ejercicio3
Ejercicio3  5   	       Ejercicio3.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   *localclr-namespace:Ejercicio3     5   	   -   5          �Name$  DirectorioArchivos��5   	    � Title$ Directorio y archivos��5   	   $	��600��6'   $	��700��64    � 
ResizeMode$ NoResize=�6@   .��5	      � $��10q�6    � ColumnDefinitions 5
   
   �� 5      6!   �� 5      6!   �� 5      6!    � RowDefinitions 5   
   �� 5      $��30 �6   6*   �� 5      $��35 �6   6*   �� 5      $	��215 �6   6+   �� 5      $	��215 �6   6+   �� 5      6   .+�5   
   �� -   5         ��Name$ directorioOrigenTextBlock��5      $
��Left=�67   $��5q�6R   $
��Wrap=�6]   $��Directorio origen:��6q   $	��Top=�6�   $��0��6�   $��0��6�   �� 5   
   -   5         ��Name$ directorioOrigenTextBox��5      $
��Left=�63   $��5q�6N    �� TextWrapping$
 Wrap=�6Y   $	��Top=�6m   $��23��6�   $	��172��6�   $��0��6�   $��1��6�   �� 5   
   -   5         ��Name$ directorioOrigenButton��5      $
��....��61   $��Right=�6@   $��8q�6\   $��Center=�6g   $��30��6�   $��0��6�   $��1��6�   6�   �� 5   
   -   5        	 ��Name$	 directorioOrigenListBox��5      $
��Left=�63   $��5q�6N   $	��Top=�6Y   $	��203��6q   $	��207��6~   $��0��6�   $��2��6�   �� 5   
   -   5        $ copiarButton��5      $��Copiar��6'   $��Center=�68   $��0,70,0,0q�6U   $	��Top=�6g   $��75��6   $��1��6�   $��2��6�   6�   �� 5   
   -   5        $ moverButton��5      $��Mover��6&   $��Center=�66   $��5q�6S   $��Center=�6^   $��75��6y   $��1��6�   $��2��6�   6�   �� 5   
   -   5        $ eliminarButton��5      $��Eliminar��6)   $��Center=�6<   $��0,0,0,70q�6Y   $��Bottom=�6k   $��75��6�   $��1��6�   $��2��6�   6�   �� 5    
   -	   5        $  directorioDestinoTextBlock��5       $
��Left=�68   $��5q�6S   $
��Wrap=�6^   $��Directorio destino:��6r   $	��Top=�6�   $��2��6�   $��0��6�   �� 5!   
   -
   5        $ directorioDestinoTextBox��5!      $
��Left=�64   $��5q�6O   $
 Wrap=�6Z   $	��Top=�6n   $��23��6�   $	��172��6�   $��2��6�   $��1��6�   �� 5"   
   -   5        $ directorioDestinoButton��5"      $
��....��62   $��Right=�6A   $��8q�6]   $��Center=�6h   $��30��6�   $��2��6�   $��1��6�   6�   �� 5#   
   -   5        $	 directorioDestinoListBox��5#      $
��Left=�64   $��5q�6O   $	��Top=�6Z   $	��203��6r   $	��207��6   $��2��6�   $��2��6�   &   System.Windows.Controls.DataGrid  5%   
   -   5        
  Name$ 
 directorioArchivosDataGrid��5%      $
��Left=�67   $��5q�6R   $��Center=�6]   $	��203��6x   $	��650��6�   $��0��6�   $��3��6�   $��3��6�   �� 5'   
   -   5        $ 	verButton��5'      $	��Ver��6$   $��Center=�62   $��5q�6O   $��Center=�6Z   $��75��6u   $��1��6�   $��4��6�   6�   5(      5)      