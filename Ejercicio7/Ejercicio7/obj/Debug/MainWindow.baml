   M S B A M L   `   `   `  ����E  AEjercicio7, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:Ejercicio7
Ejercicio7  5   	       Ejercicio7.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   *localclr-namespace:Ejercicio7     5   	   -   5          �Name$  Jornadas��5   	    � Title$ Jornadas��5   	   $	��385��6   $	��540��6'    � 
ResizeMode$ NoResize=�63   .��5	      � $��10q�6    � ColumnDefinitions 5
   
   �� 5      6!   �� 5      $��60 �6   6,   �� 5      $��90 �6   6,    � RowDefinitions 5   
   �� 5      $��35 �6   6*   �� 5      $��30 �6   6*   �� 5      6   �� 5      6   .+�5   
   �� -   5         ��Name$ TemporadaAnoTextBlock��5      $��Right=�63   $��5q�6O   $
��Wrap=�6Z   $��
Temporada:��6n   $��Center=�6�   $��0��6�   $��0��6�   �� 5   
   -   5         ��Name$ TemporadaAnoTextBox��5      $
��Left=�6/   $��5q�6J    �� TextWrapping$
 Wrap=�6U   $��Center=�6i   $��22��6�   $��50��6�   $��0��6�   $��1��6�   �� 5   
   -   5        $( "consultarTemporadaEquiposTextBlock��5      $
��Left=�6@   $��5q�6[   $
��Wrap=�6f   $��Consultar las jornadas:��6z   $��Center=�6�   $��1��6�   $��0��6�   �� 5   
   -   5         ��Name$&  consultarTemporadaEquiposListBox��5      $
��Left=�6<   $	��250��6W   $��5q�6d   $��Center=�6o   $	��400��6�   $��2��6�   $��2��6�   $��2��6�   $��0��6�   � 5   
   $��2��6   $��2��6!   	 � Orientation$	 
Horizontal=�61   .+�5      �� -   5        
 ��Name$
 anadirButton��5      $��Añadir��6+   $
��Left=�6<   $��5q�6W   $��Center=�6b   $��80��6}   $��22��6�   6�   �� 5      -   5        $
 consultarButton��5      $��	Consultar��6.   $
��Left=�6B   $��5q�6]   $��Center=�6h   $��80��6�   $��22��6�   6�   �� 5      -   5        $
 registrarButton��5      $��	Registrar��6.   $
��Left=�6B   $��5q�6]   $��Center=�6h   $��80��6�   $��22��6�   6�   �� 5       -	   5        $
 clasificarButton��5       $��
Clasificar��6/   $
��Left=�6D   $��5q�6_   $��Center=�6j   $��80��6�   $��22��6�   6�   5!      5#      5$      