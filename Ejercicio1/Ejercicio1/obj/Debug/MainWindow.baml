   M S B A M L   `   `   `  ����E  AEjercicio1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:Ejercicio1
Ejercicio1  5   	       Ejercicio1.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   *localclr-namespace:Ejercicio1     5   	   -   5          �Name$  FrasesCelebres��5   	    � Title$ Frases celebres��5   	   $	��375��6!   $
��1228��6.    � 
ResizeMode$ NoResize=�6;   .��5	      �  � ColumnDefinitions 5
   
   �� 5      $	��120 �6   6-   �� 5      $��90 �6   6,   �� 5      $��90 �6   6,   �� 5      $��90 �6   6,   �� 5      6!    � RowDefinitions 5   
   �� 5      6   �� 5      6   �� 5      6   �� 5      6   �� 5      6   �� 5      6   �� 5      6   �� 5      6   �� 5      6   �� 5      6   .+�5   
   �� -   5         ��Name$ NombreArchivoTextBlock��5      $
��Left=�64   $��5q�6O   $
��Wrap=�6Z   $��Nombre del archivo:��6n   $��Bottom=�6�   $��0��6�   $��2��6�   $��0��6�   �� 5   
   -   5         ��Name$ NombreArchivoTextBox��5      $
��Left=�60   $��23��6K   $��5q�6W    �� TextWrapping$
 Wrap=�6b   $	��Top=�6v   $	��120��6�   $��0��6�   $��2��6�   $��1��6�   �� 5   
   -   5         ��Name$ SeleccionarButton��5      $��Seleccionar��6,   $��Right=�6B   $��5q�6^   $��Center=�6i   $��75��6�   $��1��6�   $��1��6�   6�   �� 5    
   -   5        $ 	VerButton��5       $	��Ver��6$   $
��Left=�62   $��5q�6M   $��Center=�6X   $��75��6s   $��2��6~   $��1��6�   6�   �� 5"   
   -   5        $ BuscarAutorTextBlock��5"      $
��Left=�62   $��5q�6M   $
��Wrap=�6X   $��Buscar autor:��6l   $��Bottom=�6�   $��0��6�   $��2��6�   $��2��6�   �� 5#   
   -   5        $ BuscarAutorTextBox��5#      $
��Left=�6.   $��23��6I   $��5q�6U   $
 Wrap=�6`   $	��Top=�6t   $	��120��6�   $��0��6�   $��2��6�   $��3��6�   �� 5$   
   -   5        $ BuscarButton��5$      $��Buscar��6'   $��Right=�68   $��5q�6T   $��Center=�6_   $��75��6z   $��1��6�   $��3��6�   6�   �� 5&   
   -	   5        $ NuevaFraseTextBlock��5&      $
��Left=�61   $��5q�6L   $
��Wrap=�6W   $��Nueva frase:��6k   $��Bottom=�6   $��0��6�   $��2��6�   $��4��6�   �� 5'   
   -
   5        $ NuevaFraseTextBox��5'      $
��Left=�6-   $��23��6H   $��5q�6T   $
 Wrap=�6_   $	��Top=�6s   $	��120��6�   $��0��6�   $��2��6�   $��5��6�   �� 5(   
   -   5        $ NuevoAutorTextBlock��5(      $
��Left=�61   $��5q�6L   $
��Wrap=�6W   $��Nuevo autor:��6k   $��Bottom=�6   $��0��6�   $��2��6�   $��6��6�   �� 5)   
   -   5        $ NuevoAutorTextBox��5)      $
��Left=�6-   $��23��6H   $��5q�6T   $
 Wrap=�6_   $	��Top=�6s   $	��120��6�   $��0��6�   $��2��6�   $��7��6�   �� 5*   
   -   5        $ AñadirButton��5*      $��Añadir��6'   $��Right=�68   $��5q�6T   $��Center=�6_   $��75��6z   $��1��6�   $��7��6�   6�   &   System.Windows.Controls.DataGrid  5,   
   -   5        	  Name$	 FrasesCelebresDataGrid��5,      $
��Left=�63   $	��259��6N   $��5,5,0,0q�6[   $	��Top=�6l   $	��890��6�   $��2��6�   $��3��6�   $��1��6�   $��8��6�   
   AutoGenerateColumns
 .     Columns 5-      0  *System.Windows.Controls.DataGridTextColumn  5.      ,  &System.Windows.Controls.DataGridColumn   Header$ Frase��6%   1  +System.Windows.Controls.DataGridBoundColumn   Binding 64   �� *frase+  5/      $ Autor��6%    64   �� *autor+51      �� 53   
   -   5        $ AnteriorButton��53      $��Anterior��6)   $
��Left=�6<   $��5q�6W   $��Center=�6b   $��75��6}   $��3��6�   $��9��6�   6�   �� 54   
   -   5        $ SiguienteButton��54      $��	Siguiente��6*   $
��Left=�6>   $��5q�6Y   $��Center=�6d   $��75��6   $��4��6�   $��9��6�   6�   55      56      