   M S B A M L   `   `   `  ����E  AEjercicio8, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:Ejercicio8
Ejercicio8  5   	        Ejercicio8.ModificarWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   *localclr-namespace:Ejercicio8     5   	     � Title$  Modificación��5      $	��285��6   $	��725��6*    � 
ResizeMode$ NoResize=�66   .��5	      � $��10q�6    � ColumnDefinitions 5
   
   �� 5      $��80 �6   6,   �� 5      $	��150 �6   6-   �� 5      $	��120 �6   6-   �� 5      $	��150 �6   6-   �� 5      $��60 �6   6,   �� 5      $	��150 �6   6-    � RowDefinitions 5   
   �� 5      $��40 �6   6*   �� 5      $��40 �6   6*   �� 5      $��40 �6   6*   �� 5      $��80 �6   6*   �� 5      $��40 �6   6*   .+�5   
   �� -   5         ��Name$ CodigoTextBlock��5      $
��Left=�6-   $��5q�6H   $
��Wrap=�6S   $��Código:��6g   $	��Top=�6v   $��0��6�   $��0��6�   �� 5   
   -   5         ��Name$ CodigoTextBox��5      $
��Left=�6)   $��23��6D   $��5q�6P    �� TextWrapping$
 Wrap=�6[   $	��Top=�6o   $	��120��6�   $��1��6�   $��0��6�   {�.  6�   �� 5   
   -   5        $ NumEjemplaresTextBlock��5      $
��Left=�64   $��5q�6O   $
��Wrap=�6Z   $��Nº de ejemplares:��6n   $	��Top=�6�   $��2��6�   $��0��6�   �� 5   
   -   5        $ NumEjemplaresTextBox��5      $
��Left=�60   $��23��6K   $��5q�6W   $
 Wrap=�6b   $	��Top=�6v   $	��120��6�   $��3��6�   $��0��6�   �� 5    
   -   5        $ ISBNTextBlock��5       $
��Left=�6+   $��5q�6F   $
��Wrap=�6Q   $��ISBN:��6e   $	��Top=�6r   $��4��6�   $��0��6�   �� 5!   
   -   5        $ ISBNTextBox��5!      $
��Left=�6'   $��23��6B   $��5q�6N   $
 Wrap=�6Y   $	��Top=�6m   $	��120��6�   $��5��6�   $��0��6�   �� 5#   
   -   5        $ TituloTextBlock��5#      $
��Left=�6-   $��5q�6H   $
��Wrap=�6S   $��Título:��6g   $	��Top=�6v   $��0��6�   $��1��6�   �� 5$   
   -   5        $ TituloTextBox��5$      $
��Left=�6)   $��23��6D   $��5q�6P   $
 Wrap=�6[   $	��Top=�6o   $	��600��6�   $��1��6�   $��5��6�   $��1��6�   �� 5&   
   -	   5        $ AutorTextBlock��5&      $
��Left=�6,   $��5q�6G   $
��Wrap=�6R   $��Autor:��6f   $	��Top=�6t   $��0��6�   $��2��6�   �� 5'   
   -
   5        $ AutorTextBox��5'      $
��Left=�6(   $��23��6C   $��5q�6O   $
 Wrap=�6Z   $	��Top=�6n   $	��600��6�   $��1��6�   $��5��6�   $��2��6�   �� 5)   
   -   5        $ DescripcionTextBlock��5)      $
��Left=�62   $��5q�6M   $
��Wrap=�6X   $��Descripción:��6l   $	��Top=�6�   $��0��6�   $��3��6�   �� 5*   
   -   5        $ DescripcionTextBox��5*      $
��Left=�6.   $��66��6I   $��5q�6U   $
 Wrap=�6`   $	��Top=�6t   $	��600��6�   $��1��6�   $��5��6�   $��3��6�   � 5,   
   $��4��6   $��2��6$   $��5��68    � Orientation$ Vertical=�6E   .+�5-      �� -   5         ��Name$ GuardarButton��5-      $��Guardar��6,   $
��Left=�6>   $��5q�6Y   $	��Top=�6d   $��75��6|   6�   �� 5.      -   5        $ CerrarButton��5.      $��Cerrar��6+   $
��Left=�6<   $��5q�6W   $	��Top=�6b   $��75��6z   6�   5/      51      52      